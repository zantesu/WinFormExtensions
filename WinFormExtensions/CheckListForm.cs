using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormExtensions {
    public partial class CheckListForm : Form {
        public CheckListForm() {
            InitializeComponent();
        }

        public string Description {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public IEnumerable<string> Items {
            get { return checkedListBox.Items.OfType<object>().Select(o => o.ToString()); }
            set {
                checkedListBox.Items.Clear();
                checkedListBox.Items.AddRange(value.OfType<object>().ToArray());
            }
        }

        public IEnumerable<string> CheckedItems {
            get { return checkedListBox.CheckedItems.OfType<object>().Select(o => o.ToString()); }
            set {
                for (int i = 0; i < checkedListBox.Items.Count; i++) {
                    checkedListBox.SetItemChecked(i, value.Contains(checkedListBox.Items[i]));
                }
            }
        }
    }
}
