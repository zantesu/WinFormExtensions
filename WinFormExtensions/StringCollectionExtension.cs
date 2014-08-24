using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace WinFormExtensions {
    /// <summary>
    /// 对StringCollection类型的扩展方法
    /// </summary>
    public static class StringCollectionExtension {
        /// <summary>
        /// 将StringCollection类型转换为Enumerable类型
        /// </summary>
        /// <param name="collection">给定的StringCollection</param>
        /// <returns>转换后的Enumerable字符串列</returns>
        public static IEnumerable<string> AsEnumerable(this StringCollection collection) {
            return collection.OfType<string>();
        }

        /// <summary>
        /// 清空给定的StringCollection并设置新的值
        /// </summary>
        /// <param name="collection">给定的StringCollection</param>
        /// <param name="value">需要设置的新字符串值</param>
        public static void NewValue(this StringCollection collection, params string[] value) {
            collection.Clear();
            collection.AddRange(value);
        }

        /// <summary>
        /// 清空给定的StringCollection并设置新的值
        /// </summary>
        /// <param name="collection">给定的StringCollection</param>
        /// <param name="enumerable">需要设置的新字符串值</param>
        public static void NewValue(this StringCollection collection, IEnumerable<string> enumerable) {
            collection.Clear();
            collection.AddRange(enumerable.ToArray());
        }

        /// <summary>
        /// 将给定的StringCollection按照给定的action进行迭代处理
        /// </summary>
        /// <param name="collection">给定的StringCollection</param>
        /// <param name="action">进行迭代处理的方法</param>
        public static void ForEach(this StringCollection collection, Action<string> action) {
            foreach (var str in collection) {
                action(str);
            }
        }
    }
}
