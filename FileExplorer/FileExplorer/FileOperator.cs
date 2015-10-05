using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;
using System.Threading;

namespace FileExplorer
{
    public class FileOperator
    {
        //获取路径下全部文件的FileInfo的公开方法
        public  static bool GetFilesInfoInPath(string SourcePath, out List<FileInfo> FilesInfoList,  out string ExecuteMessage)
        {
            if (SourcePath == string.Empty)
            {
                ExecuteMessage = "Empty source Paths!";
                FilesInfoList = null;
                return false;
            }
            if(!Directory.Exists(SourcePath))
            {
                ExecuteMessage = "Not exist sourcePath: " + SourcePath;
                FilesInfoList = null;
                return false;
            }
            List<FileInfo> myFileInfoList = new List<FileInfo>();
            try
            {
                Thread readThread = new Thread(delegate ()
                {
                    myFileInfoList = GetDirectoryFilesInfo(SourcePath);
                }); readThread.Start(); readThread.Join();
            }
            catch (Exception ex)
            {
                FilesInfoList = null;
                ExecuteMessage = "Get files Info Failure. " + ex.ToString();
                return false;
            }

            FilesInfoList = myFileInfoList;
            if (FilesInfoList.Count < 1)
            {
                ExecuteMessage = "No file in directory " + SourcePath;
            }
            else
            {
                ExecuteMessage = "Get filesInfoList";
            }
            return true;

        }
        /// <summary>
        /// 获取路径下所有文件的FileInfo的递归私有方法
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <returns></returns>
        private static List<FileInfo> GetDirectoryFilesInfo(string sourcePath)
        {
            string[] files = Directory.GetFiles(sourcePath);
            string[] subDirectories = Directory.GetDirectories(sourcePath);
            List<FileInfo> myFilesInfoList = new List<FileInfo>();
            if(files!=null && files.Length>0)
            {
                foreach (string file in files)
                {
                    myFilesInfoList.Add(new FileInfo(file));
                }
            }
            if(subDirectories!=null && subDirectories.Length>0)
            {
                foreach(string dir in subDirectories)
                {
                    myFilesInfoList.AddRange(GetDirectoryFilesInfo(dir));
                }
            }
            return myFilesInfoList;
        }

        public static bool SaveFilesInfoToTxt(string saveFilePath, List<FileInfo> filesInfoList, out string executeMessage)
        {
            if(filesInfoList==null || filesInfoList.Count<1)
            {
                executeMessage = "No infomation to save.";
                return false;
            }
            string partExecuteMessage;
            if (!CheckCreateSaveFile(saveFilePath, out partExecuteMessage))
            {
                executeMessage = "Check file failure or Create File failure ";
                return false;
            }
            try
            {
                Thread writeThread = new Thread(delegate ()
                {
                    StreamWriter sw = new StreamWriter(saveFilePath, false, Encoding.Unicode);
                    foreach (FileInfo f in filesInfoList)
                    {
                        sw.WriteLine(f.FullName + ",    " + f.CreationTime + ",    " + f.LastWriteTime + ",    " + f.Length);
                    }
                }
                );writeThread.Start();writeThread.Join();
                executeMessage = "saveFile successfully.";
                return true;
            }
            catch (Exception ex)
            {
                executeMessage = "save Files failure. " + ex.ToString();
                return false;
            }
            
        }

        private static bool CheckCreateSaveFile(string saveFilePath, out string partExecuteMessage)
        {
            if(File.Exists(saveFilePath))
            {
                partExecuteMessage = string.Empty;
                return true;
            }
            else
            {
                try
                {
                    FileStream fs = File.Create(saveFilePath);
                    fs.Close();
                    partExecuteMessage = "Create file successfully.";
                    return true;
                }
                catch (Exception ex)
                {
                    partExecuteMessage = "Create file failure. " + ex.ToString();
                    return false;
                }
                
            }

        }
    }
}
