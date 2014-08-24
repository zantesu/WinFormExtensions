using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormExtensions {
    /// <summary>
    /// 一个包含下拉列表和浏览按钮的文件夹选择工具
    /// </summary>
    public partial class DirectoryPicker : UserControl {
        public DirectoryPicker() {
            InitializeComponent();
        }

        public delegate void EventHandler(object sender, EventArgs e);

        public event EventHandler SelectedPathChanged;

        /// <summary>
        /// 当前被选中的文件夹地址
        /// </summary>
        public string SelectedPath {
            get { return textBox.Text.Trim(); }
            set { textBox.Text = value; }
        }

        private void ButtonClick(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK) {
                SelectedPath = folderBrowserDialog.SelectedPath;
            }
        }

        public bool CheckDirectory() {
            if (string.IsNullOrWhiteSpace(textBox.Text)) {
                WinFormExtension.ShowMessage("请选择一个目录", "目录不能为空");
                button.Focus();
                return false;
            }

            if (Directory.Exists(SelectedPath)) {
                return true;
            }

            WinFormExtension.ShowMessage(string.Format("\"{0}\"不是有效的目录,请重新选择", SelectedPath), "目录无效");
            button.Focus();
            return false;
        }

        private void DirectoryPicker_DragDrop(object sender, DragEventArgs e) {
            textBox.Text = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
        }

        private void DirectoryPicker_DragEnter(object sender, DragEventArgs e) {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void textBox_TextChanged(object sender, EventArgs e) {
            if (SelectedPathChanged != null) {
                SelectedPathChanged(sender, e);
            }
        }
    }
}
