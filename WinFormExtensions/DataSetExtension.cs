using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace WinFormExtensions {
    /// <summary>
    /// 对数据集的一些扩展方法
    /// </summary>
    public static class DataSetExtension {
        /// <summary>
        /// 若存在给定的数据文件,则从该文件加载数据集
        /// </summary>
        /// <param name="set">给定的数据</param>
        /// <param name="filename">给定的数据文件文件名</param>
        public static void Load(this DataSet set, string filename) {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            if (File.Exists(path)) {
                set.ReadXml(path);
            }
        }

        /// <summary>
        /// 将数据集中保存到文件
        /// </summary>
        /// <param name="set">给定的数据集</param>
        /// <param name="filename">用于保存数据集的文件的文件名</param>
        public static void Save(this DataSet set, string filename) {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            set.WriteXml(path);
        }

        /// <summary>
        /// 判断两个数据在给定的列范围内是否内容一致
        /// 其中为null和字符串值为空等价
        /// </summary>
        /// <param name="r">自身数据</param>
        /// <param name="row">给定的数据</param>
        /// <param name="columns">给定的数据列</param>
        /// <returns>若所有的数据列内,两个数据的字符串值一致,则返回true</returns>
        public static bool EqualContent(this DataRow r, DataRow row, IEnumerable<string> columns) {
            if (row == null) {
                return false;
            }

            return r == row || columns.All(column => r.StringValue(column) == row.StringValue(column));
        }

        /// <summary>
        /// 判断两个数据在给定的列范围内是否内容一致
        /// 其中为null和字符串值为空等价
        /// </summary>
        /// <param name="r">自身数据</param>
        /// <param name="row">给定的数据</param>
        /// <param name="columns">给定的数据列</param>
        /// <returns>若所有的数据列内,两个数据的字符串值一致,则返回true</returns>
        public static bool EqualContent(this DataRow r, DataRow row, StringCollection columns) {
            return r.EqualContent(row, columns.OfType<string>());
        }

        /// <summary>
        /// 获得给定数据的给定列的字符串值
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列</param>
        /// <returns>数据在给定列的字符串值,若该列内容为null,则返回空字符串</returns>
        public static string StringValue(this DataRow r, string column) {
            return r.IsNull(column) ? string.Empty : r[column].ToString();
        }

        /// <summary>
        /// 获得给定数据的给定列的字符串值
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列</param>
        /// <returns>数据在给定列的字符串值,若该列内容为null,则返回空字符串</returns>
        public static string StringValue(this DataRow r, DataColumn column) {
            return r.IsNull(column) ? string.Empty : r[column].ToString();
        }

        /// <summary>
        /// 获得给定数据的给定列的字符串值
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列</param>
        /// <returns>数据在给定列的字符串值,若该列内容为null,则返回空字符串</returns>
        ///
        public static string StringValue(this DataRow r, int column) {
            return r.IsNull(column) ? string.Empty : r[column].ToString();
        }

        /// <summary>
        /// 判断给定的数据在给定的范围内是否全部为空
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="columns">给定的列范围</param>
        /// <returns>若全部为空,则返回true</returns>
        public static bool IsNullOrEmpty(this DataRow r, IEnumerable<string> columns) {
            return columns.All(r.IsNullOrEmpty);
        }

        /// <summary>
        /// 判断给定的数据在给定的范围内是否全部为空
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="columns">给定的列范围</param>
        /// <returns>若全部为空,则返回true</returns>
        public static bool IsNullOrEmpty(this DataRow r, StringCollection columns) {
            return r.IsNullOrEmpty(columns.OfType<string>());
        }

        /// <summary>
        /// 判断给定的数据在给定的范围内是否存在不为空的列
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="columns">给定的列范围</param>
        /// <returns>若存在不为空内容的列,则返回true</returns>
        public static bool IsNotNullOrEmpty(this DataRow r, IEnumerable<string> columns) {
            return columns.Any(r.IsNotNullOrEmpty);
        }

        /// <summary>
        /// 判断给定的数据在给定的范围内是否存在不为空的列
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="columns">给定的列范围</param>
        /// <returns>若存在不为空内容的列,则返回true</returns>
        public static bool IsNotNullOrEmpty(this DataRow r, StringCollection columns) {
            return r.IsNotNullOrEmpty(columns.OfType<string>());
        }


        /// <summary>
        /// 判断一行数据在指定的列是否不存在内容
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列名称</param>
        /// <returns>若数据在指定的数据列没有内容,则返回true</returns>
        public static bool IsNullOrEmpty(this DataRow r, string column) {
            return r.IsNull(column) || string.IsNullOrEmpty(r[column].ToString());
        }

        /// <summary>
        /// 判断一行数据在指定的列是否不存在内容
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列对象</param>
        /// <returns>若数据在指定的数据列没有内容,则返回true</returns>
        public static bool IsNullOrEmpty(this DataRow r, DataColumn column) {
            return r.IsNull(column) || string.IsNullOrEmpty(r[column].ToString());
        }

        /// <summary>
        /// 判断一行数据在指定的列是否不存在内容
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列的索引</param>
        /// <returns>若数据在指定的数据列没有内容,则返回true</returns>
        public static bool IsNullOrEmpty(this DataRow r, int column) {
            return r.IsNull(column) || string.IsNullOrEmpty(r[column].ToString());
        }

        /// <summary>
        /// 判断一行数据在指定的列是否存在内容
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列名称</param>
        /// <returns>若数据在指定的数据列存在内容,则返回true</returns>
        public static bool IsNotNullOrEmpty(this DataRow r, string column) {
            return !r.IsNull(column) && !string.IsNullOrEmpty(r[column].ToString());
        }

        /// <summary>
        /// 判断一行数据在指定的列是否存在内容
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列对象</param>
        /// <returns>若数据在指定的数据列存在内容,则返回true</returns>
        public static bool IsNotNullOrEmpty(this DataRow r, DataColumn column) {
            return !r.IsNull(column) && !string.IsNullOrEmpty(r[column].ToString());
        }

        /// <summary>
        /// 判断一行数据在指定的列是否存在内容
        /// </summary>
        /// <param name="r">给定的数据</param>
        /// <param name="column">给定的数据列的索引</param>
        /// <returns>若数据在指定的数据列存在内容,则返回true</returns>
        public static bool IsNotNullOrEmpty(this DataRow r, int column) {
            return !r.IsNull(column) && !string.IsNullOrEmpty(r[column].ToString());
        }
    }
}
