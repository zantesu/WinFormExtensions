using System;
using System.Windows.Forms;

namespace WinFormExtensions
{
    public partial class TextForm : Form
    {
        public string Content
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public string Description
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public TextForm()
        {
            InitializeComponent();
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            okBtn.Enabled = !string.IsNullOrWhiteSpace(Content);
        }

        private void TextFormShown(object sender, EventArgs e)
        {
            textBox.SelectionLength = 0;
        }
    }
}
