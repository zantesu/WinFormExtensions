using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormExtensions
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        public event RunWorkerCompletedEventHandler RunWorkerCompleted
        {
            add { backgroundWorker.RunWorkerCompleted += value; }
            remove { backgroundWorker.RunWorkerCompleted -= value; }
        }

        public event DoWorkEventHandler DoWork
        {
            add { backgroundWorker.DoWork += value; }
            remove { backgroundWorker.DoWork -= value; }
        }

        public event ProgressChangedEventHandler ProgressChanged
        {
            add { backgroundWorker.ProgressChanged += value; }
            remove { backgroundWorker.ProgressChanged -= value; }
        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            if (IsBusy)
                backgroundWorker.CancelAsync();
        }

        public bool IsBusy
        {
            get { return backgroundWorker.IsBusy; }
        }

        public void RunWorkerAsync()
        {
            ShowDialog();
            backgroundWorker.RunWorkerAsync();
        }

        public void RunWorkerAsync(IWin32Window window)
        {
            ShowDialog(window);
            backgroundWorker.RunWorkerAsync();
        }

        public void RunWorkerAsync(object argument)
        {
            ShowDialog();
            backgroundWorker.RunWorkerAsync(argument);
        }

        public void RunWorkerAsync(IWin32Window window, object argument)
        {
            ShowDialog(window);
            backgroundWorker.RunWorkerAsync(argument);
        }

        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
