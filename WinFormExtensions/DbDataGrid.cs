using System.Reflection;
using System.Windows.Forms;

namespace WinFormExtensions
{
    public class DbDataGrid : DataGridView
    {
        public DbDataGrid()
        {
            var pi = GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this, true, null);

            RowHeadersVisible = false;
            AllowUserToResizeRows = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            ReadOnly = true;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoGenerateColumns = false;
        }
    }
}
