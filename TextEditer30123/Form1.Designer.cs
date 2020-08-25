namespace TextEditer30123
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.rtTextArea = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveNameAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字コードCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.fdForm = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // rtTextArea
            // 
            this.rtTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextArea.Location = new System.Drawing.Point(0, 24);
            this.rtTextArea.Name = "rtTextArea";
            this.rtTextArea.Size = new System.Drawing.Size(800, 426);
            this.rtTextArea.TabIndex = 0;
            this.rtTextArea.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.文字コードCToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenOToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveNameAToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitXToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.FileFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.NewToolStripMenuItem.Text = "新規作成(&N)";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenOToolStripMenuItem
            // 
            this.OpenOToolStripMenuItem.Name = "OpenOToolStripMenuItem";
            this.OpenOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenOToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.OpenOToolStripMenuItem.Text = "開く(&O)...";
            this.OpenOToolStripMenuItem.Click += new System.EventHandler(this.OpenOToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SaveToolStripMenuItem.Text = "上書き保存(&S)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveNameAToolStripMenuItem
            // 
            this.SaveNameAToolStripMenuItem.Name = "SaveNameAToolStripMenuItem";
            this.SaveNameAToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SaveNameAToolStripMenuItem.Text = "名前を付けて保存(&A)...";
            this.SaveNameAToolStripMenuItem.Click += new System.EventHandler(this.SaveNameAToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // ExitXToolStripMenuItem
            // 
            this.ExitXToolStripMenuItem.Name = "ExitXToolStripMenuItem";
            this.ExitXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitXToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ExitXToolStripMenuItem.Text = "終了(&X)";
            this.ExitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すUToolStripMenuItem,
            this.やり直しRToolStripMenuItem,
            this.toolStripSeparator2,
            this.切り取りTToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けPToolStripMenuItem,
            this.削除DToolStripMenuItem,
            this.toolStripSeparator3,
            this.色ToolStripMenuItem,
            this.フォントToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 元に戻すUToolStripMenuItem
            // 
            this.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem";
            this.元に戻すUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.元に戻すUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.元に戻すUToolStripMenuItem.Text = "元に戻す(&U)";
            this.元に戻すUToolStripMenuItem.Click += new System.EventHandler(this.元に戻すUToolStripMenuItem_Click);
            // 
            // やり直しRToolStripMenuItem
            // 
            this.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem";
            this.やり直しRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.やり直しRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.やり直しRToolStripMenuItem.Text = "やり直し(&R)";
            this.やり直しRToolStripMenuItem.Click += new System.EventHandler(this.やり直しRToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // 切り取りTToolStripMenuItem
            // 
            this.切り取りTToolStripMenuItem.Name = "切り取りTToolStripMenuItem";
            this.切り取りTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.切り取りTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.切り取りTToolStripMenuItem.Text = "切り取り(&T)";
            this.切り取りTToolStripMenuItem.Click += new System.EventHandler(this.切り取りTToolStripMenuItem_Click);
            // 
            // コピーCToolStripMenuItem
            // 
            this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
            this.コピーCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.コピーCToolStripMenuItem.Text = "コピー(&C)";
            this.コピーCToolStripMenuItem.Click += new System.EventHandler(this.コピーCToolStripMenuItem_Click);
            // 
            // 貼り付けPToolStripMenuItem
            // 
            this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
            this.貼り付けPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼り付けPToolStripMenuItem.Text = "貼り付け(&P)";
            this.貼り付けPToolStripMenuItem.Click += new System.EventHandler(this.貼り付けPToolStripMenuItem_Click);
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.削除DToolStripMenuItem.Text = "削除(&D)";
            this.削除DToolStripMenuItem.Click += new System.EventHandler(this.削除DToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // 色ToolStripMenuItem
            // 
            this.色ToolStripMenuItem.Name = "色ToolStripMenuItem";
            this.色ToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.色ToolStripMenuItem.Text = "色...";
            // 
            // フォントToolStripMenuItem
            // 
            this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
            this.フォントToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.フォントToolStripMenuItem.Text = "フォント...";
            // 
            // 文字コードCToolStripMenuItem
            // 
            this.文字コードCToolStripMenuItem.Name = "文字コードCToolStripMenuItem";
            this.文字コードCToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.文字コードCToolStripMenuItem.Text = "文字コード(&C)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtTextArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "テキストエディタ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private System.Windows.Forms.RichTextBox rtTextArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字コードCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveNameAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem やり直しRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 切り取りTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.FontDialog fdForm;
    }
}

