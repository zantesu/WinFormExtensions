using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormExtensions {
    public partial class DirectoryPickerForm : Form {
        public DirectoryPickerForm() {
            InitializeComponent();
        }

        public string SourceDescription {
            get { return directoryToDirectory.SourceDescription; }
            set { directoryToDirectory.SourceDescription = value; }
        }

        public string TargetDescription {
            get { return directoryToDirectory.TargetDescription; }
            set { directoryToDirectory.TargetDescription = value; }
        }

        public string SourceDirectory {
            get { return directoryToDirectory.SourceDirectory; }
            set { directoryToDirectory.SourceDirectory = value; }
        }

        public string TargetDirectory {
            get { return directoryToDirectory.TargetDirectory; }
            set { directoryToDirectory.TargetDirectory = value; }
        }

        private void okBtn_Click(object sender, EventArgs e) {
            if (directoryToDirectory.CheckDirectory()) {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
