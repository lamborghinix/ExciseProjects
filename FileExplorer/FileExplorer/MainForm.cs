using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace FileExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog myFolderBrowserDialog = new FolderBrowserDialog();
            if(myFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtScanDirectory.Text = myFolderBrowserDialog.SelectedPath;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if(txtScanDirectory.Text == string.Empty)
            {
                MessageBox.Show("先指定要扫描的路径。");
                return;
            }
            List<FileInfo> myFileInfoList;
            string executeMessage;
            if(!FileOperator.GetFilesInfoInPath(txtScanDirectory.Text, out myFileInfoList, out executeMessage))
            {
                MessageBox.Show(executeMessage);
            }
            string saveFileName=  DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
            if (FileOperator.SaveFilesInfoToTxt(saveFileName, myFileInfoList, out executeMessage))
            {
                MessageBox.Show("保存文件信息到文件"+ saveFileName + "成功");
                return;
            }
            else
            {
                MessageBox.Show("保存文件信息失败。" + executeMessage);
                return;
            }

        }
    }
}
