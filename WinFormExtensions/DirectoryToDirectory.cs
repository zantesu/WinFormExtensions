using System.IO;
using System.Windows.Forms;

namespace WinFormExtensions {
    /// <summary>
    /// 目录选择组件,选择目标目录和源目录两个路径
    /// </summary>
    public partial class DirectoryToDirectory : UserControl {
        public bool EnableDirectoryRepeat { get; set; }

        public DirectoryToDirectory() {
            InitializeComponent();
        }

        public string SourceDirectory {
            get { return sourcePicker.SelectedPath; }
            set { sourcePicker.SelectedPath = value; }
        }
        public string TargetDirectory {
            get { return targetPicker.SelectedPath; }
            set { targetPicker.SelectedPath = value; }
        }

        public string SourceDescription {
            get { return sourceLabel.Text; }
            set { sourceLabel.Text = value; }
        }

        public string TargetDescription {
            get { return targetLabel.Text; }
            set { targetLabel.Text = value; }
        }

        public bool CheckDirectory() {
            if (!sourcePicker.CheckDirectory())
                return false;
            if (!targetPicker.CheckDirectory())
                return false;

            if (EnableDirectoryRepeat) {
                if (SourceDirectory == TargetDirectory) {
                    var text = string.Format("{0}和{1}不能为同一目录,请重新选择{1}", SourceDescription, TargetDescription);
                    MessageBox.Show(text, "路径重复", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (SourceDirectory.Contains(TargetDirectory)) {
                    var text = string.Format("为了避免运行中的问题,{0}不能是{1}的子目录,请重新选择{1}", SourceDescription, TargetDescription);
                    MessageBox.Show(text, "路径包含", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (SourceDirectory.Contains(TargetDirectory)) {
                    var text = string.Format("为了避免运行中的问题,{1}不能是{0}的子目录,请重新选择{1}", SourceDescription, TargetDescription);
                    MessageBox.Show(text, "路径包含", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            return true;
        }

        public void ClearTargetDirectory() {
            foreach (var file in Directory.GetFiles(TargetDirectory)) {
                File.Delete(file);
            }

            foreach (var directory in Directory.GetDirectories(TargetDirectory)) {
                Directory.Delete(directory, true);
            }
        }
    }
}
