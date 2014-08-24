using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormExtensions {
    public static class WinFormExtension {
        /// <summary>
        /// 单纯的消息提示框
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        public static void ShowMessage(string text, string caption) {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示一个Yes和No的消息框
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static bool ShowMessageConfirm(string text, string caption) {
            return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                   DialogResult.Yes;
        }

        /// <summary>
        /// 检查TextBox是否有文本内容
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool CheckEmptyText(this TextBox textBox, string title) {
            if (textBox == null)
                throw new ArgumentNullException("textBox");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("title");

            textBox.Text = textBox.Text.Trim();

            if (string.IsNullOrEmpty(textBox.Text)) {
                ShowMessage(title + "不能为空,请重新输入", "输入错误");
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 检查NumericUpDown的值是否为0
        /// </summary>
        /// <param name="nud"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool CheckZeroValue(this NumericUpDown nud, string title) {
            if (nud == null)
                throw new ArgumentNullException("nud");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("title");

            return nud.Value > 0 || ShowMessageConfirm(title + "的值是0,确实要输入这个数值吗?", "输入值为0");
        }

        /// <summary>
        /// 检查一个ListComtrol所选择的项是否为空
        /// </summary>
        /// <param name="list"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool CheckSelectedNull(this ListControl list, string title) {
            if (list == null)
                throw new ArgumentNullException("list");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException("title");

            if (list.SelectedIndex > -1)
                return true;

            ShowMessage("必须选择一个" + title, "需要指定" + title);
            list.Focus();
            return false;
        }

        /// <summary>
        /// 令WebBrowser不弹出新窗口
        /// </summary>
        /// <param name="webBrowser"></param>
        public static void DisableNewWindow(this WebBrowser webBrowser) {
            if (webBrowser == null)
                throw new ArgumentNullException("webBrowser");

            if (webBrowser.Document == null)
                throw new ArgumentNullException("webBrowser");

            //将所有的链接的目标，指向本窗体
            foreach (HtmlElement archor in webBrowser.Document.Links) {
                archor.SetAttribute("target", "_self");
            }

            //将所有的FORM的提交目标，指向本窗体
            foreach (HtmlElement form in webBrowser.Document.Forms) {
                form.SetAttribute("target", "_self");
            }
        }

        /// <summary>
        /// 获得ComboBox选中的一行数据
        /// </summary>
        /// <param name="comboBox"></param>
        /// <returns></returns>
        public static DataRow SelectedDataRow(this ComboBox comboBox) {
            if (comboBox == null)
                throw new ArgumentNullException("comboBox");

            var dataRowView = comboBox.SelectedItem as DataRowView;
            return dataRowView == null ? null : dataRowView.Row;
        }

        /// <summary>
        /// 获得ListBox所选中的一行数据
        /// </summary>
        /// <param name="listBox"></param>
        /// <returns></returns>
        public static DataRow SelectedDataRow(this ListBox listBox) {
            if (listBox == null)
                throw new ArgumentNullException("listBox");

            var dataRowView = listBox.SelectedItem as DataRowView;
            return dataRowView == null ? null : dataRowView.Row;
        }

        /// <summary>
        /// 获得DataGridView选中的一行的数据
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static DataRow SelectedDataRow(this DataGridView dataGridView) {
            if (dataGridView == null)
                throw new ArgumentNullException("dataGridView");

            return dataGridView.CurrentRow == null ? null : ((DataRowView)dataGridView.CurrentRow.DataBoundItem).Row;
        }

        /// <summary>
        /// 获得DataGridView选中所有行的数据
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static IEnumerable<DataRow> SelectedDataRows(this DataGridView dataGridView) {
            if (dataGridView == null)
                throw new ArgumentNullException("dataGridView");

            return dataGridView.SelectedRows.OfType<DataGridViewRow>()
                .Select(r => r.DataBoundItem as DataRowView)
                .Where(r => r != null)
                .Select(r => r.Row);
        }
    }
}
