using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormExtensions {
    public partial class ListBoxForm : Form {
        public ListBoxForm() {
            InitializeComponent();
        }

        public string Description {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public object DataSource {
            get { return listBox.DataSource; }
            set { listBox.DataSource = value; }
        }

        public string DisplayMember {
            get { return listBox.DisplayMember; }
            set { listBox.DisplayMember = value; }
        }

        public DataRow SelectedData {
            get { return listBox.SelectedDataRow(); }
        }

        public object SelectedItem {
            get { return listBox.SelectedItem; }
            set { listBox.SelectedItem = value; }
        }

        public object SelectedValue {
            get { return listBox.SelectedValue; }
            set { listBox.SelectedValue = value; }
        }

        public string ValueMember {
            get { return listBox.ValueMember; }
            set { listBox.ValueMember = value; }
        }

        private void ListBoxDoubleClick(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }
    }
}
