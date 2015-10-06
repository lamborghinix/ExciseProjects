using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace FileExplorer
{
    public class FileInfoWrapper
    {
        public FileInfo myFileInfo {
            get; set; }
        public string fullName
        {
            get { return myFileInfo.FullName; }
            set { }
        }
    }
}
