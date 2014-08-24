namespace WinFormExtensions
{
    partial class DirectoryPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button.AutoSize = true;
            this.button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button.Location = new System.Drawing.Point(445, 5);
            this.button.Name = "button";
            this.button.Padding = new System.Windows.Forms.Padding(22, 1, 22, 1);
            this.button.Size = new System.Drawing.Size(85, 25);
            this.button.TabIndex = 1;
            this.button.Text = "选择";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "选择文件所在的目录";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(4, 7);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(434, 20);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.button, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(533, 35);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // DirectoryPicker
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DirectoryPicker";
            this.Size = new System.Drawing.Size(533, 35);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DirectoryPicker_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DirectoryPicker_DragEnter);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
