using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormExtensions {
    public partial class LoadingControl : UserControl {
        public LoadingControl() {
            InitializeComponent();
        }

        public string Label { get { return label.Text; } set { label.Text = value; } }

        public static void StartLoading(params Control[] controls) {
            foreach (var control in controls) {
                control.Enabled = false;
            }
        }

        public static void EndLoading(params Control[] controls) {
            foreach (var control in controls) {
                control.Enabled = true;
            }
        }
    }
}
