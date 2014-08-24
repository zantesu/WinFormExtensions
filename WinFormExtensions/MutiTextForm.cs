using System;
using System.Windows.Forms;

namespace WinFormExtensions
{
    public partial class MutiTextForm : Form
    {
        public MutiTextForm()
        {
            InitializeComponent();
        }

        public string[] Lines
        {
            get { return textBox.Lines; }
            set { textBox.Lines = value; }
        }

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

        private void MutiTextFormShown(object sender, EventArgs e)
        {
            textBox.SelectionLength = 0;
        }
    }
}
