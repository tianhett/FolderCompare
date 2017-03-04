namespace FolderCompare
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnter1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tgvList1 = new AdvancedDataGridView.TreeGridView();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.fName = new AdvancedDataGridView.TreeGridColumn();
            this.fSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CancelMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcludeMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearExcludeMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyExcludeMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnter2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tgvList2 = new AdvancedDataGridView.TreeGridView();
            this.icon2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.fName2 = new AdvancedDataGridView.TreeGridColumn();
            this.fSize2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CancelMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcludeMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearExcludeMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyExcludeMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.imageStrip = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFielDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelSame1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelSame2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelSamilar1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelSamilar2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelSelect1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelSelect2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopySimalr1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopySimalr2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRoboCopy1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRoboCopy2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopySelect1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopySelect2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExclude = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcludeSelect1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcludeSelect2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearExclude1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearExclude2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgvList1)).BeginInit();
            this.cMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgvList2)).BeginInit();
            this.cMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnEnter1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnOpen1);
            this.groupBox1.Controls.Add(this.txtPath1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件夹1";
            // 
            // btnEnter1
            // 
            this.btnEnter1.Image = global::FolderCompare.Properties.Resources.enter;
            this.btnEnter1.Location = new System.Drawing.Point(412, 21);
            this.btnEnter1.Name = "btnEnter1";
            this.btnEnter1.Size = new System.Drawing.Size(30, 23);
            this.btnEnter1.TabIndex = 4;
            this.btnEnter1.UseVisualStyleBackColor = true;
            this.btnEnter1.Click += new System.EventHandler(this.btnEnter1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tgvList1);
            this.panel1.Location = new System.Drawing.Point(19, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 425);
            this.panel1.TabIndex = 3;
            // 
            // tgvList1
            // 
            this.tgvList1.AllowUserToAddRows = false;
            this.tgvList1.AllowUserToDeleteRows = false;
            this.tgvList1.AllowUserToOrderColumns = true;
            this.tgvList1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tgvList1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tgvList1.ColumnHeadersHeight = 20;
            this.tgvList1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.fName,
            this.fSize,
            this.mDate,
            this.fullName});
            this.tgvList1.ContextMenuStrip = this.cMenuStrip1;
            this.tgvList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgvList1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tgvList1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tgvList1.ImageList = null;
            this.tgvList1.Location = new System.Drawing.Point(0, 0);
            this.tgvList1.Name = "tgvList1";
            this.tgvList1.RowHeadersVisible = false;
            this.tgvList1.RowHeadersWidth = 20;
            this.tgvList1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tgvList1.Size = new System.Drawing.Size(481, 425);
            this.tgvList1.TabIndex = 3;
            // 
            // icon
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.icon.DefaultCellStyle = dataGridViewCellStyle5;
            this.icon.FillWeight = 50F;
            this.icon.HeaderText = "";
            this.icon.Name = "icon";
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.icon.Width = 25;
            // 
            // fName
            // 
            this.fName.DefaultNodeImage = null;
            this.fName.HeaderText = "名称";
            this.fName.Name = "fName";
            this.fName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fName.Width = 180;
            // 
            // fSize
            // 
            this.fSize.HeaderText = "大小";
            this.fSize.Name = "fSize";
            this.fSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mDate
            // 
            this.mDate.FillWeight = 150F;
            this.mDate.HeaderText = "修改日期";
            this.mDate.Name = "mDate";
            this.mDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mDate.Width = 150;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "路径";
            this.fullName.Name = "fullName";
            this.fullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fullName.Visible = false;
            // 
            // cMenuStrip1
            // 
            this.cMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelMenu1,
            this.DeleteMenu1,
            this.ExcludeMenu1,
            this.ClearExcludeMenu1,
            this.CopyExcludeMenu1});
            this.cMenuStrip1.Name = "cMenuStrip1";
            this.cMenuStrip1.Size = new System.Drawing.Size(125, 114);
            // 
            // CancelMenu1
            // 
            this.CancelMenu1.Image = global::FolderCompare.Properties.Resources.clear;
            this.CancelMenu1.Name = "CancelMenu1";
            this.CancelMenu1.Size = new System.Drawing.Size(124, 22);
            this.CancelMenu1.Text = "取消选择";
            this.CancelMenu1.Click += new System.EventHandler(this.CancelMenu1_Click);
            // 
            // DeleteMenu1
            // 
            this.DeleteMenu1.Image = global::FolderCompare.Properties.Resources.delete;
            this.DeleteMenu1.Name = "DeleteMenu1";
            this.DeleteMenu1.Size = new System.Drawing.Size(124, 22);
            this.DeleteMenu1.Text = "删除";
            this.DeleteMenu1.Click += new System.EventHandler(this.DeleteMenu1_Click);
            // 
            // ExcludeMenu1
            // 
            this.ExcludeMenu1.Image = global::FolderCompare.Properties.Resources.exclude;
            this.ExcludeMenu1.Name = "ExcludeMenu1";
            this.ExcludeMenu1.Size = new System.Drawing.Size(124, 22);
            this.ExcludeMenu1.Text = "排除";
            this.ExcludeMenu1.Click += new System.EventHandler(this.ExcludeMenu1_Click);
            // 
            // ClearExcludeMenu1
            // 
            this.ClearExcludeMenu1.Image = global::FolderCompare.Properties.Resources.clear_exclude;
            this.ClearExcludeMenu1.Name = "ClearExcludeMenu1";
            this.ClearExcludeMenu1.Size = new System.Drawing.Size(124, 22);
            this.ClearExcludeMenu1.Text = "取消排除";
            this.ClearExcludeMenu1.Click += new System.EventHandler(this.ClearExcludeMenu1_Click);
            // 
            // CopyExcludeMenu1
            // 
            this.CopyExcludeMenu1.Image = global::FolderCompare.Properties.Resources.copy;
            this.CopyExcludeMenu1.Name = "CopyExcludeMenu1";
            this.CopyExcludeMenu1.Size = new System.Drawing.Size(124, 22);
            this.CopyExcludeMenu1.Text = "复制";
            this.CopyExcludeMenu1.ToolTipText = "将文件夹1选中的节点复制到文件夹2";
            this.CopyExcludeMenu1.Click += new System.EventHandler(this.CopyExcludeMenu1_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen1.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen1.Image")));
            this.btnOpen1.Location = new System.Drawing.Point(448, 21);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(30, 23);
            this.btnOpen1.TabIndex = 1;
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.AllowDrop = true;
            this.txtPath1.Location = new System.Drawing.Point(19, 21);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(388, 21);
            this.txtPath1.TabIndex = 0;
            this.txtPath1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPath1_DragEnter);
            this.txtPath1.Enter += new System.EventHandler(this.txtPath1_Enter);
            this.txtPath1.Leave += new System.EventHandler(this.txtPath1_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnter2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.btnOpen2);
            this.groupBox2.Controls.Add(this.txtPath2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 487);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件夹2";
            // 
            // btnEnter2
            // 
            this.btnEnter2.Image = global::FolderCompare.Properties.Resources.enter;
            this.btnEnter2.Location = new System.Drawing.Point(414, 21);
            this.btnEnter2.Name = "btnEnter2";
            this.btnEnter2.Size = new System.Drawing.Size(30, 23);
            this.btnEnter2.TabIndex = 5;
            this.btnEnter2.UseVisualStyleBackColor = true;
            this.btnEnter2.Click += new System.EventHandler(this.btnEnter2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tgvList2);
            this.panel2.Location = new System.Drawing.Point(18, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 425);
            this.panel2.TabIndex = 4;
            // 
            // tgvList2
            // 
            this.tgvList2.AllowUserToAddRows = false;
            this.tgvList2.AllowUserToDeleteRows = false;
            this.tgvList2.AllowUserToOrderColumns = true;
            this.tgvList2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tgvList2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tgvList2.ColumnHeadersHeight = 20;
            this.tgvList2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon2,
            this.fName2,
            this.fSize2,
            this.mDate2,
            this.fullName2});
            this.tgvList2.ContextMenuStrip = this.cMenuStrip2;
            this.tgvList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tgvList2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tgvList2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tgvList2.ImageList = null;
            this.tgvList2.Location = new System.Drawing.Point(0, 0);
            this.tgvList2.Name = "tgvList2";
            this.tgvList2.RowHeadersVisible = false;
            this.tgvList2.RowHeadersWidth = 20;
            this.tgvList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tgvList2.Size = new System.Drawing.Size(481, 425);
            this.tgvList2.TabIndex = 0;
            // 
            // icon2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.icon2.DefaultCellStyle = dataGridViewCellStyle6;
            this.icon2.FillWeight = 50F;
            this.icon2.HeaderText = "";
            this.icon2.Name = "icon2";
            this.icon2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.icon2.Width = 25;
            // 
            // fName2
            // 
            this.fName2.DefaultNodeImage = null;
            this.fName2.HeaderText = "名称";
            this.fName2.Name = "fName2";
            this.fName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fName2.Width = 180;
            // 
            // fSize2
            // 
            this.fSize2.HeaderText = "大小";
            this.fSize2.Name = "fSize2";
            this.fSize2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mDate2
            // 
            this.mDate2.FillWeight = 150F;
            this.mDate2.HeaderText = "修改日期";
            this.mDate2.Name = "mDate2";
            this.mDate2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mDate2.Width = 150;
            // 
            // fullName2
            // 
            this.fullName2.HeaderText = "路径";
            this.fullName2.Name = "fullName2";
            this.fullName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fullName2.Visible = false;
            // 
            // cMenuStrip2
            // 
            this.cMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CancelMenu2,
            this.DeleteMenu2,
            this.ExcludeMenu2,
            this.ClearExcludeMenu2,
            this.CopyExcludeMenu2});
            this.cMenuStrip2.Name = "cMenuStrip2";
            this.cMenuStrip2.Size = new System.Drawing.Size(125, 114);
            // 
            // CancelMenu2
            // 
            this.CancelMenu2.Image = global::FolderCompare.Properties.Resources.clear;
            this.CancelMenu2.Name = "CancelMenu2";
            this.CancelMenu2.Size = new System.Drawing.Size(124, 22);
            this.CancelMenu2.Text = "取消选择";
            this.CancelMenu2.Click += new System.EventHandler(this.CancelMenu2_Click);
            // 
            // DeleteMenu2
            // 
            this.DeleteMenu2.Image = global::FolderCompare.Properties.Resources.delete;
            this.DeleteMenu2.Name = "DeleteMenu2";
            this.DeleteMenu2.Size = new System.Drawing.Size(124, 22);
            this.DeleteMenu2.Text = "删除";
            this.DeleteMenu2.Click += new System.EventHandler(this.DeleteMenu2_Click);
            // 
            // ExcludeMenu2
            // 
            this.ExcludeMenu2.Image = global::FolderCompare.Properties.Resources.exclude;
            this.ExcludeMenu2.Name = "ExcludeMenu2";
            this.ExcludeMenu2.Size = new System.Drawing.Size(124, 22);
            this.ExcludeMenu2.Text = "排除";
            this.ExcludeMenu2.Click += new System.EventHandler(this.ExcludeMenu2_Click);
            // 
            // ClearExcludeMenu2
            // 
            this.ClearExcludeMenu2.Image = global::FolderCompare.Properties.Resources.clear_exclude;
            this.ClearExcludeMenu2.Name = "ClearExcludeMenu2";
            this.ClearExcludeMenu2.Size = new System.Drawing.Size(124, 22);
            this.ClearExcludeMenu2.Text = "取消排除";
            this.ClearExcludeMenu2.Click += new System.EventHandler(this.ClearExcludeMenu2_Click);
            // 
            // CopyExcludeMenu2
            // 
            this.CopyExcludeMenu2.Image = global::FolderCompare.Properties.Resources.copy;
            this.CopyExcludeMenu2.Name = "CopyExcludeMenu2";
            this.CopyExcludeMenu2.Size = new System.Drawing.Size(124, 22);
            this.CopyExcludeMenu2.Text = "复制";
            this.CopyExcludeMenu2.ToolTipText = "将文件夹2选中的节点复制到文件夹1";
            this.CopyExcludeMenu2.Click += new System.EventHandler(this.CopyExcludeMenu2_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen2.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen2.Image")));
            this.btnOpen2.Location = new System.Drawing.Point(450, 20);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(30, 23);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.AllowDrop = true;
            this.txtPath2.Location = new System.Drawing.Point(20, 22);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(388, 21);
            this.txtPath2.TabIndex = 0;
            this.txtPath2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPath2_DragEnter);
            this.txtPath2.Enter += new System.EventHandler(this.txtPath2_Enter);
            this.txtPath2.Leave += new System.EventHandler(this.txtPath2_Leave);
            // 
            // imageStrip
            // 
            this.imageStrip.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageStrip.ImageSize = new System.Drawing.Size(16, 16);
            this.imageStrip.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFielDelete,
            this.ToolStripMenuItemFileCopy,
            this.ToolStripMenuItemFileExclude});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFielDelete
            // 
            this.ToolStripMenuItemFielDelete.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStripMenuItemFielDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelSame1,
            this.btnDelSame2,
            this.btnDelSamilar1,
            this.btnDelSamilar2,
            this.btnDelSelect1,
            this.btnDelSelect2});
            this.ToolStripMenuItemFielDelete.Name = "ToolStripMenuItemFielDelete";
            this.ToolStripMenuItemFielDelete.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItemFielDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.ToolStripMenuItemFielDelete.Size = new System.Drawing.Size(82, 21);
            this.ToolStripMenuItemFielDelete.Text = "文件删除(F)";
            this.ToolStripMenuItemFielDelete.ToolTipText = "文件删除";
            // 
            // btnDelSame1
            // 
            this.btnDelSame1.Image = global::FolderCompare.Properties.Resources.trash3;
            this.btnDelSame1.Name = "btnDelSame1";
            this.btnDelSame1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.btnDelSame1.Size = new System.Drawing.Size(200, 22);
            this.btnDelSame1.Text = "删除1相同文件";
            this.btnDelSame1.ToolTipText = "删除文件夹1的绿色节点";
            this.btnDelSame1.Click += new System.EventHandler(this.btnDelSame1_Click);
            // 
            // btnDelSame2
            // 
            this.btnDelSame2.Image = global::FolderCompare.Properties.Resources.trash3;
            this.btnDelSame2.Name = "btnDelSame2";
            this.btnDelSame2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.btnDelSame2.Size = new System.Drawing.Size(200, 22);
            this.btnDelSame2.Text = "删除2相同文件";
            this.btnDelSame2.ToolTipText = "删除文件夹2的绿色节点";
            this.btnDelSame2.Click += new System.EventHandler(this.btnDelSame2_Click);
            // 
            // btnDelSamilar1
            // 
            this.btnDelSamilar1.Image = global::FolderCompare.Properties.Resources.trash;
            this.btnDelSamilar1.Name = "btnDelSamilar1";
            this.btnDelSamilar1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.btnDelSamilar1.Size = new System.Drawing.Size(200, 22);
            this.btnDelSamilar1.Text = "删除1相似文件";
            this.btnDelSamilar1.ToolTipText = "删除文件夹1的红色节点";
            this.btnDelSamilar1.Click += new System.EventHandler(this.btnDelSamilar1_Click);
            // 
            // btnDelSamilar2
            // 
            this.btnDelSamilar2.Image = global::FolderCompare.Properties.Resources.trash;
            this.btnDelSamilar2.Name = "btnDelSamilar2";
            this.btnDelSamilar2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnDelSamilar2.Size = new System.Drawing.Size(200, 22);
            this.btnDelSamilar2.Text = "删除2相似文件";
            this.btnDelSamilar2.ToolTipText = "删除文件夹2的红色节点";
            this.btnDelSamilar2.Click += new System.EventHandler(this.btnDelSamilar2_Click);
            // 
            // btnDelSelect1
            // 
            this.btnDelSelect1.Image = global::FolderCompare.Properties.Resources.trash1;
            this.btnDelSelect1.Name = "btnDelSelect1";
            this.btnDelSelect1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.btnDelSelect1.Size = new System.Drawing.Size(200, 22);
            this.btnDelSelect1.Text = "删除1选择文件";
            this.btnDelSelect1.ToolTipText = "删除文件夹1的选中节点";
            this.btnDelSelect1.Click += new System.EventHandler(this.btnDelSelect1_Click);
            // 
            // btnDelSelect2
            // 
            this.btnDelSelect2.Image = global::FolderCompare.Properties.Resources.trash1;
            this.btnDelSelect2.Name = "btnDelSelect2";
            this.btnDelSelect2.ShortcutKeyDisplayString = "";
            this.btnDelSelect2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6)));
            this.btnDelSelect2.Size = new System.Drawing.Size(200, 22);
            this.btnDelSelect2.Text = "删除2选择文件";
            this.btnDelSelect2.ToolTipText = "删除文件夹2的选中节点";
            this.btnDelSelect2.Click += new System.EventHandler(this.btnDelSelect2_Click);
            // 
            // ToolStripMenuItemFileCopy
            // 
            this.ToolStripMenuItemFileCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopySimalr1,
            this.btnCopySimalr2,
            this.btnRoboCopy1,
            this.btnRoboCopy2,
            this.btnCopySelect1,
            this.btnCopySelect2});
            this.ToolStripMenuItemFileCopy.Name = "ToolStripMenuItemFileCopy";
            this.ToolStripMenuItemFileCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItemFileCopy.Size = new System.Drawing.Size(84, 21);
            this.ToolStripMenuItemFileCopy.Text = "文件复制(C)";
            this.ToolStripMenuItemFileCopy.ToolTipText = "文件复制";
            // 
            // btnCopySimalr1
            // 
            this.btnCopySimalr1.Image = global::FolderCompare.Properties.Resources.copy_samilar;
            this.btnCopySimalr1.Name = "btnCopySimalr1";
            this.btnCopySimalr1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.btnCopySimalr1.Size = new System.Drawing.Size(217, 22);
            this.btnCopySimalr1.Text = "复制1相似文件";
            this.btnCopySimalr1.ToolTipText = "复制文件夹1的红色节点到文件夹2";
            this.btnCopySimalr1.Click += new System.EventHandler(this.btnCopySimalr1_Click);
            // 
            // btnCopySimalr2
            // 
            this.btnCopySimalr2.Image = global::FolderCompare.Properties.Resources.copy_samilar;
            this.btnCopySimalr2.Name = "btnCopySimalr2";
            this.btnCopySimalr2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.btnCopySimalr2.Size = new System.Drawing.Size(217, 22);
            this.btnCopySimalr2.Text = "复制2相似文件";
            this.btnCopySimalr2.ToolTipText = "复制文件夹2的红色节点到文件夹1";
            this.btnCopySimalr2.Click += new System.EventHandler(this.btnCopySimalr2_Click);
            // 
            // btnRoboCopy1
            // 
            this.btnRoboCopy1.Image = global::FolderCompare.Properties.Resources.copy_add;
            this.btnRoboCopy1.Name = "btnRoboCopy1";
            this.btnRoboCopy1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.btnRoboCopy1.Size = new System.Drawing.Size(217, 22);
            this.btnRoboCopy1.Text = "增量复制文件夹1";
            this.btnRoboCopy1.ToolTipText = "从文件夹1中复制文件夹2没有的节点到文件夹2";
            this.btnRoboCopy1.Click += new System.EventHandler(this.btnRoboCopy1_Click);
            // 
            // btnRoboCopy2
            // 
            this.btnRoboCopy2.Image = global::FolderCompare.Properties.Resources.copy_add;
            this.btnRoboCopy2.Name = "btnRoboCopy2";
            this.btnRoboCopy2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.btnRoboCopy2.Size = new System.Drawing.Size(217, 22);
            this.btnRoboCopy2.Text = "增量复制文件夹2";
            this.btnRoboCopy2.ToolTipText = "从文件夹2中复制文件夹1没有的节点到文件夹1";
            this.btnRoboCopy2.Click += new System.EventHandler(this.btnRoboCopy2_Click);
            // 
            // btnCopySelect1
            // 
            this.btnCopySelect1.Image = global::FolderCompare.Properties.Resources.copy;
            this.btnCopySelect1.Name = "btnCopySelect1";
            this.btnCopySelect1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.btnCopySelect1.Size = new System.Drawing.Size(217, 22);
            this.btnCopySelect1.Text = "复制1选择文件";
            this.btnCopySelect1.ToolTipText = "复制文件夹1选中的节点到文件夹2";
            this.btnCopySelect1.Click += new System.EventHandler(this.btnCopySelect1_Click);
            // 
            // btnCopySelect2
            // 
            this.btnCopySelect2.Image = global::FolderCompare.Properties.Resources.copy;
            this.btnCopySelect2.Name = "btnCopySelect2";
            this.btnCopySelect2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.btnCopySelect2.Size = new System.Drawing.Size(217, 22);
            this.btnCopySelect2.Text = "复制2选择文件";
            this.btnCopySelect2.ToolTipText = "复制文件夹2选中的节点到文件夹1";
            this.btnCopySelect2.Click += new System.EventHandler(this.btnCopySelect2_Click);
            // 
            // ToolStripMenuItemFileExclude
            // 
            this.ToolStripMenuItemFileExclude.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcludeSelect1,
            this.btnExcludeSelect2,
            this.btnClearExclude1,
            this.btnClearExclude2});
            this.ToolStripMenuItemFileExclude.Name = "ToolStripMenuItemFileExclude";
            this.ToolStripMenuItemFileExclude.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.ToolStripMenuItemFileExclude.Size = new System.Drawing.Size(83, 21);
            this.ToolStripMenuItemFileExclude.Text = "文件排除(E)";
            // 
            // btnExcludeSelect1
            // 
            this.btnExcludeSelect1.Image = global::FolderCompare.Properties.Resources.exclude;
            this.btnExcludeSelect1.Name = "btnExcludeSelect1";
            this.btnExcludeSelect1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.btnExcludeSelect1.Size = new System.Drawing.Size(234, 22);
            this.btnExcludeSelect1.Text = "排除1选择文件";
            this.btnExcludeSelect1.ToolTipText = "选择文件夹1中所需要排除的文件";
            this.btnExcludeSelect1.Click += new System.EventHandler(this.btnExcludeSelect1_Click);
            // 
            // btnExcludeSelect2
            // 
            this.btnExcludeSelect2.Image = global::FolderCompare.Properties.Resources.exclude;
            this.btnExcludeSelect2.Name = "btnExcludeSelect2";
            this.btnExcludeSelect2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.btnExcludeSelect2.Size = new System.Drawing.Size(234, 22);
            this.btnExcludeSelect2.Text = "排除2选择文件";
            this.btnExcludeSelect2.ToolTipText = "选择文件夹2中所需要排除的文件";
            this.btnExcludeSelect2.Click += new System.EventHandler(this.btnExcludeSelect2_Click);
            // 
            // btnClearExclude1
            // 
            this.btnClearExclude1.Image = global::FolderCompare.Properties.Resources.clear_exclude;
            this.btnClearExclude1.Name = "btnClearExclude1";
            this.btnClearExclude1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.btnClearExclude1.Size = new System.Drawing.Size(234, 22);
            this.btnClearExclude1.Text = "清除1排除文件";
            this.btnClearExclude1.ToolTipText = "清除文件夹1中排除的文件";
            this.btnClearExclude1.Click += new System.EventHandler(this.btnClearExclude1_Click);
            // 
            // btnClearExclude2
            // 
            this.btnClearExclude2.Image = global::FolderCompare.Properties.Resources.clear_exclude;
            this.btnClearExclude2.Name = "btnClearExclude2";
            this.btnClearExclude2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.btnClearExclude2.Size = new System.Drawing.Size(234, 22);
            this.btnClearExclude2.Text = "清除2排除文件";
            this.btnClearExclude2.ToolTipText = "清除文件夹2中排除的文件";
            this.btnClearExclude2.Click += new System.EventHandler(this.btnClearExclude2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1024, 487);
            this.splitContainer1.SplitterDistance = 512;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 512);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件对比";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tgvList1)).EndInit();
            this.cMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tgvList2)).EndInit();
            this.cMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AdvancedDataGridView.TreeGridView tgvList2;
        private System.Windows.Forms.ImageList imageStrip;
        private AdvancedDataGridView.TreeGridView tgvList1;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private AdvancedDataGridView.TreeGridColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewImageColumn icon2;
        private AdvancedDataGridView.TreeGridColumn fName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSize2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName2;
        private System.Windows.Forms.Button btnEnter1;
        private System.Windows.Forms.Button btnEnter2;
        private System.Windows.Forms.ContextMenuStrip cMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CancelMenu1;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu1;
        private System.Windows.Forms.ContextMenuStrip cMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem CancelMenu2;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFielDelete;
        private System.Windows.Forms.ToolStripMenuItem btnDelSame1;
        private System.Windows.Forms.ToolStripMenuItem btnDelSame2;
        private System.Windows.Forms.ToolStripMenuItem btnDelSamilar1;
        private System.Windows.Forms.ToolStripMenuItem btnDelSamilar2;
        private System.Windows.Forms.ToolStripMenuItem btnDelSelect1;
        private System.Windows.Forms.ToolStripMenuItem btnDelSelect2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileCopy;
        private System.Windows.Forms.ToolStripMenuItem btnCopySelect1;
        private System.Windows.Forms.ToolStripMenuItem btnCopySelect2;
        private System.Windows.Forms.ToolStripMenuItem btnRoboCopy1;
        private System.Windows.Forms.ToolStripMenuItem btnRoboCopy2;
        private System.Windows.Forms.ToolStripMenuItem btnCopySimalr1;
        private System.Windows.Forms.ToolStripMenuItem btnCopySimalr2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExclude;
        private System.Windows.Forms.ToolStripMenuItem btnExcludeSelect1;
        private System.Windows.Forms.ToolStripMenuItem btnExcludeSelect2;
        private System.Windows.Forms.ToolStripMenuItem btnClearExclude1;
        private System.Windows.Forms.ToolStripMenuItem btnClearExclude2;
        private System.Windows.Forms.ToolStripMenuItem ExcludeMenu1;
        private System.Windows.Forms.ToolStripMenuItem ClearExcludeMenu1;
        private System.Windows.Forms.ToolStripMenuItem ExcludeMenu2;
        private System.Windows.Forms.ToolStripMenuItem ClearExcludeMenu2;
        private System.Windows.Forms.ToolStripMenuItem CopyExcludeMenu1;
        private System.Windows.Forms.ToolStripMenuItem CopyExcludeMenu2;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}