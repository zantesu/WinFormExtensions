namespace WinFormExtensions {
    partial class DirectoryPickerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.directoryToDirectory = new WinFormExtensions.DirectoryToDirectory();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.AutoSize = true;
            this.okBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okBtn.Location = new System.Drawing.Point(366, 159);
            this.okBtn.Name = "okBtn";
            this.okBtn.Padding = new System.Windows.Forms.Padding(22, 1, 22, 1);
            this.okBtn.Size = new System.Drawing.Size(85, 25);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(457, 159);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(22, 1, 22, 1);
            this.cancelBtn.Size = new System.Drawing.Size(85, 25);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // directoryToDirectory
            // 
            this.directoryToDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryToDirectory.AutoSize = true;
            this.directoryToDirectory.Location = new System.Drawing.Point(14, 14);
            this.directoryToDirectory.Margin = new System.Windows.Forms.Padding(5);
            this.directoryToDirectory.Name = "directoryToDirectory";
            this.directoryToDirectory.Size = new System.Drawing.Size(533, 128);
            this.directoryToDirectory.SourceDescription = "标签";
            this.directoryToDirectory.SourceDirectory = "";
            this.directoryToDirectory.TabIndex = 0;
            this.directoryToDirectory.TargetDescription = "标签";
            this.directoryToDirectory.TargetDirectory = "";
            // 
            // DirectoryPickerForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(554, 196);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.directoryToDirectory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectoryPickerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirectoryPickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DirectoryToDirectory directoryToDirectory;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}