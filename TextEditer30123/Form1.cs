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
            //ファイル名がなければ新規作成
            if(this.fileName == "" )
            {
                FileSave(fileName);
            }
            //ファイル名があれば上書き保存
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

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtTextArea.Text == "")
            {
                Clear();
            }
            else
            {
                DialogResult result = MessageBox.Show("ファイルを保存しますか？", "質問", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    if (File.Exists(fileName))
                    {
                        SaveNameAToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        if (sfdFileSave.ShowDialog() == DialogResult.OK)
                        {
                            FileSave(sfdFileSave.FileName);
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    Clear();
                }

            }
        }

        private void Clear()
        {
            rtTextArea.Text = "";
        }

        private void 元に戻すUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Undo();
        }

        private void やり直しRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Redo();
        }

        private void 切り取りTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Cut();
        }

        private void コピーCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Copy();
        }

        private void 貼り付けPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Paste();
        }

        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Text = rtTextArea.Text.Remove(rtTextArea.SelectionStart, rtTextArea.SelectionLength);
        }
    }
}
