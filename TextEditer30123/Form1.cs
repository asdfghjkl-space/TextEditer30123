using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditer30123
{
    public partial class Form1 : Form
    {
        //現在編集中のファイル
        private string fileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //アプリケーションの終了
            Application.Exit();
        }

        //上書き保存
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.fileName != "" )
            {
                FileSave(fileName);
            }
            else
            {
                SaveNameAToolStripMenuItem_Click(sender,e);
            }
        }

        //立地テキストを指定し、内容を保存
        private void FileSave(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(sfdFileSave.FileName, false, Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(rtTextArea.Text);
            }
        }

        //名前を付けて保存
        private void SaveNameAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                FileSave(sfdFileSave.FileName);
            }
        }

        //開く
        private void OpenOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofdFileOpen.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdFileOpen.FileName,Encoding.GetEncoding("utf-8"),false))
                {
                    rtTextArea.Text = sr.ReadToEnd();
                }
            }
        }

    }
}
