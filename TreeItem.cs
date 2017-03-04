using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolderCompare
{
    public class TreeItem : IComparable
    {
        private string _folderName;
        private string _fileName;
        private long _fileSize;
        private DateTime _modifyTime;
        private string _fullName;
        private int _type;
        private int _level;

        #region 封装字段
        public string FolderName
        {
            get { return _folderName; }
            set { _folderName = value; }
        }
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public long FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
        public DateTime ModifyTime
        {
            get { return _modifyTime; }
            set { _modifyTime = value; }
        }
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public List<int> IndexList;
        #endregion

        public TreeItem(string folderName, string fileName, long fileSize, DateTime modifyTime, string fullName, int type, List<int> indexList, int level)
        {
            this._folderName = folderName;
            this._fileName = fileName;
            this._fileSize = fileSize;
            this._modifyTime = modifyTime;
            this._fullName = fullName;
            this._type = type;
            this.IndexList = indexList;
            this._level = level;
        }

        public int CompareTo(object obj)
        {
            TreeItem temp = obj as TreeItem;
            if (temp != null)
            {
                if (!string.IsNullOrEmpty(temp.FolderName))
                {
                    if (this._type == temp.Type)
                    {
                        switch (temp.Type)
                        {
                            case 0:
                                #region 文件夹比较
                                if (this._fileName == temp.FileName)
                                {
                                    return 0;
                                }
                                #endregion
                                break;
                            case 1:
                                #region 文件比较
                                if (this._folderName == temp.FolderName)
                                {
                                    if (this._fileName == temp.FileName)
                                    {
                                        if (this._fileSize == temp.FileSize)
                                        {
                                            if (this._modifyTime == temp.ModifyTime)
                                            {
                                                return 0;
                                            }
                                            else
                                            {
                                                return 1;
                                            }
                                        }
                                        else
                                        {
                                            return 1;
                                        }
                                    }
                                }
                                #endregion
                                break;
                        }
                    }
                }
                else
                {
                    if (this._type == temp.Type)
                    {
                        switch (temp.Type)
                        {
                            case 0:
                                #region 文件夹比较
                                if (this._fileName == temp.FileName)
                                {
                                    return 0;
                                }
                                #endregion
                                break;
                            case 1:
                                #region 文件比较
                                if (this._fileName == temp.FileName)
                                {
                                    if (this._fileSize == temp.FileSize)
                                    {
                                        if (this._modifyTime == temp.ModifyTime)
                                        {
                                            return 0;
                                        }
                                        else
                                        {
                                            return 1;
                                        }
                                    }
                                    else
                                    {
                                        return 1;
                                    }
                                }
                                #endregion
                                break;
                        }
                    }
                }
            }
            return -1;
        }

    }
}
