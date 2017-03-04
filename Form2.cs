using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using AdvancedDataGridView;

namespace FolderCompare
{
    public partial class Form2 : Form
    {
        Dictionary<string, TreeItem> dic1;
        Dictionary<string, TreeItem> dic2;
        Dictionary<string, Thread> threadDic;
        Dictionary<string, string> dicSame;
        Dictionary<string, string> dicSamilar;
        Dictionary<string, TreeItem> dicExclude1;
        Dictionary<string, TreeItem> dicExclude2;
        Dictionary<string, Color> colorDic;
        SynchronizationContext m_context;
        List<string> commonList;
        List<string> exceptList1;
        List<string> exceptList2;
        const string pathTip = "拖动文件夹到此或者输入文件夹路径";
        static string originPath1 = "";
        static string originPath2 = "";

        public Form2()
        {
            InitializeComponent();
            InitData();
            SetStyle();
        }

        private void InitData()
        {
            txtPath1.Text = pathTip;
            txtPath2.Text = pathTip;
            dic1 = new Dictionary<string, TreeItem>();
            dic2 = new Dictionary<string, TreeItem>();
            dicSame = new Dictionary<string, string>();
            dicSamilar = new Dictionary<string, string>();
            dicExclude1 = new Dictionary<string, TreeItem>();
            dicExclude2 = new Dictionary<string, TreeItem>();
            threadDic = new Dictionary<string, Thread>();
            m_context = SynchronizationContext.Current;
            commonList = new List<string>();
            exceptList1 = new List<string>();
            exceptList2 = new List<string>();
            InitColorDic();
            InitToolTip(this.btnEnter1, "载入文件");
            InitToolTip(this.btnOpen1, "浏览文件夹");
            InitToolTip(this.btnEnter2, "载入文件");
            InitToolTip(this.btnOpen2, "浏览文件夹");
        }

        private void InitColorDic()
        {
            colorDic = new Dictionary<string, Color>()
            {
                {"red", Color.Red},
                {"green", Color.Green},
                {"blue", Color.Blue},
                {"black", Color.Black},
                {"orange", Color.Orange}
            };
        }

        private void InitToolTip(Control control, string caption)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            //toolTip1.ToolTipTitle = "Hello";
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(control, caption);
        }

        private void SetStyle()
        {
            icon.DefaultCellStyle.NullValue = null;
            icon2.DefaultCellStyle.NullValue = null;
            this.imageStrip.ImageSize = new System.Drawing.Size(16, 16);
            this.imageStrip.TransparentColor = System.Drawing.Color.Magenta;
            this.imageStrip.ImageSize = new Size(16, 16);
            this.imageStrip.Images.AddStrip(Properties.Resources.folder);
            this.imageStrip.Images.AddStrip(Properties.Resources.file);
            tgvList1.ImageList = imageStrip;
            tgvList2.ImageList = imageStrip;
        }

        internal class AttachmentColumnHeader : DataGridViewColumnHeaderCell
        {
            public Image _image;
            public AttachmentColumnHeader(Image img) : base()
            {
                this._image = img;
            }
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
                graphics.DrawImage(_image, cellBounds.X + 4, cellBounds.Y + 2);
            }
            protected override object GetValue(int rowIndex)
            {
                return null;
            }
        }

        private void txtPath1_DragEnter(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            txtPath1.Text = path;
            DealWithFolderRead(1);
        }

        private void txtPath1_Enter(object sender, EventArgs e)
        {
            if (txtPath1.Text.Equals(pathTip))
            {
                txtPath1.Text = "";
            }
        }

        private void txtPath1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath1.Text))
            {
                txtPath1.Text = pathTip;
            }
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtPath1.Text = fbd.SelectedPath;
                DealWithFolderRead(1);
            }
        }

        private void btnEnter1_Click(object sender, EventArgs e)
        {
            DealWithFolderRead(1);
        }

        private void txtPath2_DragEnter(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            txtPath2.Text = path;
            DealWithFolderRead(2);
        }

        private void txtPath2_Enter(object sender, EventArgs e)
        {
            if (txtPath2.Text.Equals(pathTip))
            {
                txtPath2.Text = "";
            }
        }

        private void txtPath2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath2.Text))
            {
                txtPath2.Text = pathTip;
            }
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtPath2.Text = fbd.SelectedPath;
                DealWithFolderRead(2);
            }
        }

        private void btnEnter2_Click(object sender, EventArgs e)
        {
            DealWithFolderRead(2);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void DealWithFolderRead(int type)
        {
            switch (type)
            {
                case 1:
                    if (!string.IsNullOrEmpty(txtPath1.Text) && !txtPath1.Text.Equals(pathTip))
                    {
                        Thread thread1 = new Thread(Folder1Read);
                        thread1.IsBackground = true;
                        thread1.Start(txtPath1.Text);
                        if(!threadDic.ContainsKey(txtPath1.Text))
                        {
                            threadDic.Add(txtPath1.Text, thread1);
                        }
                        else
                        {
                            threadDic[txtPath1.Text] = thread1;
                        }
                    }
                    break;
                case 2:
                    if (!string.IsNullOrEmpty(txtPath2.Text) && !txtPath2.Text.Equals(pathTip))
                    {
                        Thread thread2 = new Thread(Folder2Read);
                        thread2.IsBackground = true;
                        thread2.Start(txtPath2.Text);
                        if (!threadDic.ContainsKey(txtPath2.Text))
                        {
                            threadDic.Add(txtPath2.Text, thread2);
                        }
                        else
                        {
                            threadDic[txtPath2.Text] = thread2;
                        }
                    }
                    break;
            }
        }

        #region 读取路径1，构造目录文件树
        public void Folder1Read(object param)
        {
            string path = param as string;
            try
            {
                m_context.Post(CreateTreeGridView1, path);
            }
            catch (Exception ex)
            {
                threadDic[path].Abort();
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateTreeGridView1(object param)
        {
            string path = param as string;
            tgvList1.Nodes.Clear();
            dic1.Clear();
            dicSame.Clear();
            dicSamilar.Clear();
            Recursion(tgvList1, null, path, path, dic1);
            tgvList1.ClearSelection();
            //重新构造排除文件的字典
            if (!originPath1.Equals(txtPath1.Text))
            {
                originPath1 = txtPath1.Text;
                dicExclude1.Clear();
            }
            else
            {
                ResetExcludeDic(dic1, dicExclude1);
            }
            //对比
            DealWithCompareData(dic1, dic2);
        }
        #endregion

        #region 读取路径2，构造目录文件树
        public void Folder2Read(object param)
        {
            string path = param as string;
            try
            {
                m_context.Post(CreateTreeGridView2, path);
            }
            catch (Exception ex)
            {
                threadDic[path].Abort();
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateTreeGridView2(object param)
        {
            string path = param as string;
            tgvList2.Nodes.Clear();
            dic2.Clear();
            dicSame.Clear();
            dicSamilar.Clear();
            Recursion(tgvList2, null, path, path, dic2);
            tgvList2.ClearSelection();
            //重新构造排除文件的字典
            if (!originPath2.Equals(txtPath2.Text))
            {
                originPath2 = txtPath2.Text;
                dicExclude2.Clear();
            }
            else
            {
                ResetExcludeDic(dic2, dicExclude2);
            }
            //对比
            DealWithCompareData(dic1, dic2);
        }
        #endregion

        #region 递归路径，构造目录文件树
        public void Recursion(TreeGridView tgv, TreeGridNode node, string path, string top, Dictionary<string, TreeItem> dic)
        {
            bool isFirst = false;
            if (node == null)
            {
                isFirst = true;
            }
            Font boldFont = new Font(tgv.DefaultCellStyle.Font, FontStyle.Bold);
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                if (dirs.Length > 0)
                {
                    foreach (var each in dirs)
                    {
                        string folderKey = each.FullName.Replace(top, "");
                        if (isFirst)
                        {
                            node = tgv.Nodes.Add(null, each.Name, "", each.LastWriteTime, each.FullName);
                            node.ImageIndex = 0;
                            node.DefaultCellStyle.Font = boldFont;
                            List<int> indexList = new List<int>();
                            indexList.Add(tgv.Nodes.Count - 1);
                            TreeItem item = new TreeItem(null, each.Name, 0, each.LastWriteTime, each.FullName, 0, indexList, node.Level);
                            dic.Add(folderKey, item);
                            Recursion(tgv, node, each.FullName, top, dic);
                        }
                        else
                        {
                            TreeGridNode childNode = node.Nodes.Add(null, each.Name, "", each.LastWriteTime, each.FullName);
                            childNode.ImageIndex = 0;
                            childNode.DefaultCellStyle.Font = boldFont;
                            string parentKey = each.Parent.FullName.Replace(top, "");
                            List<int> indexList = new List<int>();
                            indexList.AddRange(dic[parentKey].IndexList);
                            indexList.Add(node.Nodes.Count - 1);
                            TreeItem item = new TreeItem(null, each.Name, 0, each.LastWriteTime, each.FullName, 0, indexList, childNode.Level);
                            dic.Add(folderKey, item);
                            Recursion(tgv, childNode, each.FullName, top, dic);
                        }
                    }
                }
                FileInfo[] files = dir.GetFiles();
                if (files.Length > 0)
                {
                    foreach (var each in files)
                    {
                        string fileKey = each.FullName.Replace(top, "");
                        double tempSize = (double)each.Length / 1024;
                        long size = each.Length / 1024;
                        if (tempSize > size)
                        {
                            size++;
                        }
                        if (isFirst)
                        {
                            node = tgv.Nodes.Add(null, each.Name, size + "KB", each.LastWriteTime, each.FullName);
                            node.ImageIndex = 1;
                            List<int> indexList = new List<int>();
                            indexList.Add(tgv.Nodes.Count - 1);
                            TreeItem item = new TreeItem(null, each.Name, each.Length, each.LastWriteTime, each.FullName, 1, indexList, node.Level);
                            dic.Add(fileKey, item);
                        }
                        else
                        {
                            TreeGridNode childNode = node.Nodes.Add(null, each.Name, size + "KB", each.LastWriteTime, each.FullName);
                            childNode.ImageIndex = 1;
                            string parentKey = each.Directory.FullName.Replace(top, "");
                            List<int> indexList = new List<int>();
                            indexList.AddRange(dic[parentKey].IndexList);
                            indexList.Add(node.Nodes.Count - 1);
                            string folderName = each.DirectoryName.Replace(top, "");
                            TreeItem item = new TreeItem(folderName, each.Name, each.Length, each.LastWriteTime, each.FullName, 1, indexList, childNode.Level);
                            dic.Add(fileKey, item);
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Directory is not exists.");
            }
        }
        #endregion

        #region 对比文件路径，设置树的样式
        public void DealWithCompareData(Dictionary<string, TreeItem> dic1, Dictionary<string, TreeItem> dic2)
        {
            if (dic1.Count > 0 && dic2.Count > 0)
            {
                commonList = dic1.Keys.Intersect(dic2.Keys).ToList();
                exceptList1 = dic1.Keys.Except(dic2.Keys).ToList();
                exceptList2 = dic2.Keys.Except(dic1.Keys).ToList();
                if (commonList.Count > 0)
                {
                    foreach (string key in commonList)
                    {
                        int compareResult = dic2[key].CompareTo(dic1[key]);
                        if (compareResult == 0)
                        {
                            dicSame.Add(dic2[key].FullName, dic1[key].FullName);
                            SetTreeGridViewStyle(tgvList1, dic1, key, "green");
                            SetTreeGridViewStyle(tgvList2, dic2, key, "green");
                        }
                        else if (compareResult == 1)
                        {
                            dicSamilar.Add(dic2[key].FullName, dic1[key].FullName);
                            SetTreeGridViewStyle(tgvList1, dic1, key, "red");
                            SetTreeGridViewStyle(tgvList2, dic2, key, "red");
                        }
                    }
                }
                if (exceptList1.Count > 0)
                {
                    SetDifferentStyle(tgvList1, dic1, exceptList1, "black");
                }
                if (exceptList2.Count > 0)
                {
                    SetDifferentStyle(tgvList2, dic2, exceptList2, "black");
                }
            }
            if (dicExclude1.Count > 0)
            {
                foreach (string key in dicExclude1.Keys)
                {
                    SetTreeGridViewStyle(tgvList1, dicExclude1, key, "orange");
                }
            }
            if (dicExclude2.Count > 0)
            {
                foreach (string key in dicExclude2.Keys)
                {
                    SetTreeGridViewStyle(tgvList2, dicExclude2, key, "orange");
                }
            }
        }

        public void SetTreeGridViewStyle(TreeGridView tgv, Dictionary<string, TreeItem> dic, string key, string colorName)
        {
            if (dic.Count > 0)
            {
                if (dic[key].IndexList.Count > 0)
                {
                    TreeGridNode tempNode = new TreeGridNode();
                    for (int i = 0; i < dic[key].IndexList.Count; i++)
                    {
                        if (i == 0)
                        {
                            tempNode = tgv.Nodes.ElementAt(dic[key].IndexList[i]);
                        }
                        else
                        {
                            tempNode = tempNode.Nodes.ElementAt(dic[key].IndexList[i]);
                        }
                        if (i == dic[key].IndexList.Count - 1)
                        {
                            tempNode.DefaultCellStyle.ForeColor = colorDic[colorName];
                        }
                    }
                }
            }
        }

        public void SetDifferentStyle(TreeGridView tgv, Dictionary<string, TreeItem> dic, List<string> keyList, string colorName)
        {
            if (keyList.Count > 0)
            {
                foreach (string key in keyList)
                {
                    if (dic[key].IndexList.Count > 0)
                    {
                        TreeGridNode tempNode = new TreeGridNode();
                        for (int i = 0; i < dic[key].IndexList.Count; i++)
                        {
                            if (i == 0)
                            {
                                tempNode = tgv.Nodes.ElementAt(dic[key].IndexList[i]);
                            }
                            else
                            {
                                tempNode = tempNode.Nodes.ElementAt(dic[key].IndexList[i]);
                            }
                            tempNode.DefaultCellStyle.ForeColor = colorDic[colorName];
                        }
                    }
                }
            }
        }
        #endregion

        #region 菜单栏

        #region 文件删除
        private void btnDelSame1_Click(object sender, EventArgs e)
        {
            if (dicSame.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要删除文件夹1中的绿色节点么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //排除功能
                    List<string> pathList = dicSame.Values.ToList();
                    List<string> exculdePathList = dicExclude1.Values.Select(o => o.FullName).ToList();
                    pathList.RemoveAll(o => { return exculdePathList.Contains(o); });
                    if (pathList.Count > 0)
                    {
                        DeleteAllFile(pathList, 1);
                        btnEnter1.PerformClick();
                        btnEnter2.PerformClick();
                    }
                }
            }
        }

        private void btnDelSame2_Click(object sender, EventArgs e)
        {
            if (dicSame.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要删除文件夹2中的绿色节点么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //排除功能
                    List<string> pathList = dicSame.Keys.ToList();
                    List<string> exculdePathList = dicExclude2.Values.Select(o => o.FullName).ToList();
                    pathList.RemoveAll(o => { return exculdePathList.Contains(o); });
                    if (pathList.Count > 0)
                    {
                        DeleteAllFile(pathList, 2);
                        btnEnter1.PerformClick();
                        btnEnter2.PerformClick();
                    }
                }
            }
        }

        private void btnDelSamilar1_Click(object sender, EventArgs e)
        {
            if (dicSamilar.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要删除文件夹1中的绿色和红色节点么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //排除功能
                    List<string> pathList = dicSamilar.Values.ToList();
                    List<string> exculdePathList = dicExclude1.Values.Select(o => o.FullName).ToList();
                    pathList.RemoveAll(o => { return exculdePathList.Contains(o); });
                    if (pathList.Count > 0)
                    {
                        DeleteAllFile(pathList, 1);
                        btnEnter1.PerformClick();
                        btnEnter2.PerformClick();
                    }
                }
            }
        }

        private void btnDelSamilar2_Click(object sender, EventArgs e)
        {
            if (dicSamilar.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要删除文件夹1中的绿色和红色节点么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //排除功能
                    List<string> pathList = dicSamilar.Keys.ToList();
                    List<string> exculdePathList = dicExclude2.Values.Select(o => o.FullName).ToList();
                    pathList.RemoveAll(o => { return exculdePathList.Contains(o); });
                    if (pathList.Count > 0)
                    {
                        DeleteAllFile(pathList, 2);
                        btnEnter1.PerformClick();
                        btnEnter2.PerformClick();
                    }
                }
            }
        }

        private void btnDelSelect1_Click(object sender, EventArgs e)
        {
            var rows = tgvList1.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要删除文件夹1中的选中节点么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //排除功能
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string key = rows[i].Cells[4].Value.ToString().Replace(txtPath1.Text, "");
                        if(!dicExclude1.ContainsKey(key))
                        {
                            DeleteFolderAndFile(rows[i].Cells[4].Value.ToString());
                        }
                    }
                    btnEnter1.PerformClick();
                    btnEnter2.PerformClick();
                }
            }
        }

        private void btnDelSelect2_Click(object sender, EventArgs e)
        {
            var rows = tgvList2.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要删除文件夹1中的选中节点么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //排除功能
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string key = rows[i].Cells[4].Value.ToString().Replace(txtPath1.Text, "");
                        if (!dicExclude2.ContainsKey(key))
                        {
                            DeleteFolderAndFile(rows[i].Cells[4].Value.ToString());
                        }
                    }
                    btnEnter1.PerformClick();
                    btnEnter2.PerformClick();
                }
            }
        }
        #endregion

        #region 文件复制
        private void btnCopySimalr1_Click(object sender, EventArgs e)
        {
            if (dicSamilar.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要将文件夹1的红色节点覆盖到文件夹2么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (string key in dicSamilar.Keys)
                    {
                        string curKey = dicSamilar[key].Replace(txtPath1.Text, "");
                        if (!dicExclude1.ContainsKey(curKey))
                        {
                            string dirName = Path.GetDirectoryName(key) + "\\";
                            string cmd = string.Format(" xcopy /E /Y {0} {1} ", dicSamilar[key], dirName);
                            string output = "";
                            CmdHelper.RunCmd(cmd, out output);
                        }
                    }
                    btnEnter1.PerformClick();
                    btnEnter2.PerformClick();
                }
            }
        }

        private void btnCopySimalr2_Click(object sender, EventArgs e)
        {
            if (dicSamilar.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要将文件夹2的红色节点覆盖到文件夹1么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (string key in dicSamilar.Keys)
                    {
                        string curKey = key.Replace(txtPath2.Text, "");
                        if (!dicExclude2.ContainsKey(curKey))
                        {
                            string dirName = Path.GetDirectoryName(dicSamilar[key]) + "\\";
                            string cmd = string.Format(" xcopy /E /Y {0} {1} ", key, dirName);
                            string output = "";
                            CmdHelper.RunCmd(cmd, out output);
                        }
                    }
                    btnEnter1.PerformClick();
                    btnEnter2.PerformClick();
                }
            }
        }

        private void btnRoboCopy1_Click(object sender, EventArgs e)
        {
            if (exceptList1.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要将文件夹1增量复制到文件夹2么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (string key in exceptList1)
                    {
                        if (!dicExclude1.ContainsKey(key))
                        {
                            string fileName = txtPath1.Text + key;
                            string dirName = Path.GetDirectoryName(fileName);
                            string targetName = dirName.Replace(txtPath1.Text, txtPath2.Text) + "\\";
                            string cmd = string.Format(" xcopy /E /Y {0} {1} ", fileName, targetName);
                            string output = "";
                            CmdHelper.RunCmd(cmd, out output);
                        }
                    }
                    btnEnter1.PerformClick();
                    btnEnter2.PerformClick();
                }
            }
        }

        private void btnRoboCopy2_Click(object sender, EventArgs e)
        {
            if (exceptList2.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要将文件夹2增量复制到文件夹1么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    foreach (string key in exceptList2)
                    {
                        if (!dicExclude2.ContainsKey(key))
                        {
                            string fileName = txtPath2.Text + key;
                            string dirName = Path.GetDirectoryName(fileName);
                            string targetName = dirName.Replace(txtPath2.Text, txtPath1.Text) + "\\";
                            string cmd = string.Format(" xcopy /E /Y {0} {1} ", fileName, targetName);
                            string output = "";
                            CmdHelper.RunCmd(cmd, out output);
                        }
                    }
                    btnEnter2.PerformClick();
                    btnEnter1.PerformClick();
                }
            }
        }

        private void btnCopySelect1_Click(object sender, EventArgs e)
        {
            var rows = tgvList1.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要将文件夹1选中的文件复制到文件夹2么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string fileName = rows[i].Cells[4].Value.ToString();
                        string key = fileName.Replace(txtPath1.Text, "");
                        if (!dicExclude1.ContainsKey(key))
                        {
                            string dirName = Path.GetDirectoryName(fileName);
                            string targetName = dirName.Replace(txtPath1.Text, txtPath2.Text) + "\\";
                            string cmd = string.Format(" xcopy /E /Y {0} {1} ", fileName, targetName);
                            string output = "";
                            CmdHelper.RunCmd(cmd, out output);
                        }
                    }
                    tgvList1.ClearSelection();
                    btnEnter1.PerformClick();
                    btnEnter2.PerformClick();
                }
            }
        }

        private void btnCopySelect2_Click(object sender, EventArgs e)
        {
            var rows = tgvList2.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("你确定要将文件夹2选中的文件复制到文件夹1么？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < rows.Count; i++)
                    {
                        string fileName = rows[i].Cells[4].Value.ToString();
                        string key = fileName.Replace(txtPath2.Text, "");
                        if (!dicExclude2.ContainsKey(key))
                        {
                            string dirName = Path.GetDirectoryName(fileName);
                            string targetName = dirName.Replace(txtPath2.Text, txtPath1.Text) + "\\";
                            string cmd = string.Format(" xcopy /E /Y {0} {1} ", fileName, targetName);
                            string output = "";
                            CmdHelper.RunCmd(cmd, out output);
                        }
                    }
                    tgvList2.ClearSelection();
                    btnEnter2.PerformClick();
                    btnEnter1.PerformClick();
                }
            }
        }
        #endregion

        #region 文件排除
        private void btnExcludeSelect1_Click(object sender, EventArgs e)
        {
            var rows = tgvList1.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    string key = rows[i].Cells[4].Value.ToString().Replace(txtPath1.Text, "");
                    BuildExcludeDictionary(key, rows[i].Cells[4].Value.ToString(), dic1, dicExclude1, tgvList1);
                }
                tgvList1.ClearSelection();
            }
        }

        private void btnExcludeSelect2_Click(object sender, EventArgs e)
        {
            var rows = tgvList2.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    string key = rows[i].Cells[4].Value.ToString().Replace(txtPath2.Text, "");
                    BuildExcludeDictionary(key, rows[i].Cells[4].Value.ToString(), dic2, dicExclude2, tgvList2);
                }
                tgvList2.ClearSelection();
            }
        }

        private void btnClearExclude1_Click(object sender, EventArgs e)
        {
            if (dicExclude1.Count > 0)
            {
                dicExclude1.Clear();
                tgvList1.ClearSelection();
                btnEnter1.PerformClick();
            }
        }

        private void btnClearExclude2_Click(object sender, EventArgs e)
        {
            if (dicExclude2.Count > 0)
            {
                dicExclude2.Clear();
                tgvList2.ClearSelection();
                btnEnter2.PerformClick();
            }
        }
        #endregion

        #endregion

        #region 右键菜单

        #region 取消
        private void CancelMenu1_Click(object sender, EventArgs e)
        {
            tgvList1.ClearSelection();
        }

        private void CancelMenu2_Click(object sender, EventArgs e)
        {
            tgvList2.ClearSelection();
        }
        #endregion

        #region 删除
        private void DeleteMenu1_Click(object sender, EventArgs e)
        {
            btnDelSelect1.PerformClick();
        }

        private void DeleteMenu2_Click(object sender, EventArgs e)
        {
            btnDelSelect2.PerformClick();
        }
        #endregion

        #region 排除
        private void ExcludeMenu1_Click(object sender, EventArgs e)
        {
            var rows = tgvList1.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    string key = rows[i].Cells[4].Value.ToString().Replace(txtPath1.Text, "");
                    BuildExcludeDictionary(key, rows[i].Cells[4].Value.ToString(), dic1, dicExclude1, tgvList1);
                }
                tgvList1.ClearSelection();
            }
        }

        private void ExcludeMenu2_Click(object sender, EventArgs e)
        {
            var rows = tgvList2.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    string key = rows[i].Cells[4].Value.ToString().Replace(txtPath2.Text, "");
                    BuildExcludeDictionary(key, rows[i].Cells[4].Value.ToString(), dic2, dicExclude2, tgvList2);
                }
                tgvList2.ClearSelection();
            }
        }
        #endregion

        #region 取消排除
        private void ClearExcludeMenu1_Click(object sender, EventArgs e)
        {
            var rows = tgvList1.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    string key = rows[i].Cells[4].Value.ToString().Replace(txtPath1.Text, "");
                    CancelExcludeSelect(key, rows[i].Cells[4].Value.ToString(), dic1, dicExclude1);
                }
                tgvList1.ClearSelection();
                btnEnter1.PerformClick();
            }
        }

        private void ClearExcludeMenu2_Click(object sender, EventArgs e)
        {
            var rows = tgvList2.SelectedRows;
            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    string key = rows[i].Cells[4].Value.ToString().Replace(txtPath2.Text, "");
                    CancelExcludeSelect(key, rows[i].Cells[4].Value.ToString(), dic2, dicExclude2);
                }
                tgvList2.ClearSelection();
                btnEnter2.PerformClick();
            }
        }
        #endregion

        #region 复制
        private void CopyExcludeMenu1_Click(object sender, EventArgs e)
        {
            btnCopySelect1.PerformClick();
        }

        private void CopyExcludeMenu2_Click(object sender, EventArgs e)
        {
            btnCopySelect2.PerformClick();
        }
        #endregion

        #endregion

        #region 其他

        #region 删除目录及其下子目录和文件
        private void DeleteAllFile(List<string> filePathList, int type)
        {
            if (filePathList.Count > 0)
            {
                List<string> folderPathList = new List<string>();
                foreach (var each in filePathList)
                {
                    if (File.Exists(each))
                    {
                        File.Delete(each);
                        folderPathList.Add(new FileInfo(each).DirectoryName);
                    }
                    else if (Directory.Exists(each))
                    {
                        folderPathList.Add(each);
                    }
                }
                folderPathList = folderPathList.Distinct().ToList();
                foreach (var each in folderPathList)
                {
                    switch (type)
                    {
                        case 1:
                            if (!each.Equals(txtPath1.Text))
                            {
                                DeleteAllFolder(each, type);
                            }
                            break;
                        case 2:
                            if (!each.Equals(txtPath2.Text))
                            {
                                DeleteAllFolder(each, type);
                            }
                            break;
                    }
                }
            }
        }

        private void DeleteAllFolder(string path, int type)
        {
            if (!string.IsNullOrEmpty(path))
            {
                if (Directory.Exists(path))
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    if (dir.GetDirectories().Count() == 0 && dir.GetFiles().Count() == 0)
                    {
                        Directory.Delete(path);
                        switch (type)
                        {
                            case 1:
                                if (!dir.Parent.FullName.Equals(txtPath1.Text))
                                {
                                    DeleteAllFolder(dir.Parent.FullName, type);
                                }
                                break;
                            case 2:
                                if (!dir.Parent.FullName.Equals(txtPath2.Text))
                                {
                                    DeleteAllFolder(dir.Parent.FullName, type);
                                }
                                break;
                        }
                    }
                }
            }
        }

        public void DeleteFolderAndFile(string dir)
        {
            if (Directory.Exists(dir)) //如果存在这个文件夹删除之
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    if (File.Exists(d))
                    {
                        File.Delete(d); //直接删除其中的文件
                    }
                    else
                    {
                        DeleteFolderAndFile(d); //递归删除子文件夹
                    }
                }
                Directory.Delete(dir, true); //删除已空文件夹
            }
            else if (File.Exists(dir))
            {
                File.Delete(dir);
            }
        }
        #endregion

        public void BuildExcludeDictionary(string key, string fullName, Dictionary<string, TreeItem> dic, Dictionary<string, TreeItem> excludeDic, TreeGridView tgvList)
        {
            if (Directory.Exists(fullName))
            {
                List<string> keyList = dic.Keys.Where(o => o.Contains(key + "\\") || o.Equals(key)).ToList();
                if (keyList.Count > 0)
                {
                    foreach (string each in keyList)
                    {
                        if (!excludeDic.ContainsKey(each))
                        {
                            excludeDic.Add(each, dic[each]);
                            SetTreeGridViewStyle(tgvList, excludeDic, each, "orange");
                        }
                    }
                }
            }
            else
            {
                if (!excludeDic.ContainsKey(key))
                {
                    excludeDic.Add(key, dic[key]);
                    SetTreeGridViewStyle(tgvList, excludeDic, key, "orange");
                }
            }
        }

        public void ResetExcludeDic(Dictionary<string, TreeItem> dic, Dictionary<string, TreeItem> excludeDic)
        {
            if (excludeDic.Count > 0)
            {
                List<string> keyList = excludeDic.Keys.ToList();
                excludeDic.Clear();
                foreach (string each in keyList)
                {
                    excludeDic.Add(each, dic[each]);
                }
            }
        }

        public void CancelExcludeSelect(string key, string fullName, Dictionary<string, TreeItem> dic, Dictionary<string, TreeItem> excludeDic)
        {
            if (Directory.Exists(fullName))
            {
                List<string> keyList = dic.Keys.Where(o => o.Contains(key + "\\") || o.Equals(key)).ToList();
                if (keyList.Count > 0)
                {
                    foreach (string each in keyList)
                    {
                        excludeDic.Remove(each);
                    }
                }
            }
            else
            {
                excludeDic.Remove(key);
            }
        }

        #endregion

        

       

    }
}
