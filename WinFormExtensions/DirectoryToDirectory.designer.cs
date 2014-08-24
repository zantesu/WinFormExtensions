namespace WinFormExtensions
{
    partial class DirectoryToDirectory
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
            this.sourceLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetPicker = new WinFormExtensions.DirectoryPicker();
            this.sourcePicker = new WinFormExtensions.DirectoryPicker();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceLabel
            // 
            this.sourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(3, 0);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(31, 13);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "标签";
            // 
            // targetLabel
            // 
            this.targetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(3, 65);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(31, 13);
            this.targetLabel.TabIndex = 1;
            this.targetLabel.Text = "标签";
            // 
            // targetPicker
            // 
            this.targetPicker.AllowDrop = true;
            this.targetPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.targetPicker.AutoSize = true;
            this.targetPicker.Location = new System.Drawing.Point(0, 87);
            this.targetPicker.Margin = new System.Windows.Forms.Padding(0);
            this.targetPicker.Name = "targetPicker";
            this.targetPicker.SelectedPath = "";
            this.targetPicker.Size = new System.Drawing.Size(533, 33);
            this.targetPicker.TabIndex = 3;
            // 
            // sourcePicker
            // 
            this.sourcePicker.AllowDrop = true;
            this.sourcePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sourcePicker.AutoSize = true;
            this.sourcePicker.Location = new System.Drawing.Point(0, 22);
            this.sourcePicker.Margin = new System.Windows.Forms.Padding(0);
            this.sourcePicker.Name = "sourcePicker";
            this.sourcePicker.SelectedPath = "";
            this.sourcePicker.Size = new System.Drawing.Size(533, 33);
            this.sourcePicker.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.sourceLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.targetPicker, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.targetLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.sourcePicker, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(533, 130);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // DirectoryToDirectory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "DirectoryToDirectory";
            this.Size = new System.Drawing.Size(533, 130);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label targetLabel;
        private DirectoryPicker sourcePicker;
        private DirectoryPicker targetPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
