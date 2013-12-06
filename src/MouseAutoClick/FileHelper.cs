using System.Collections.Generic;
using System.Linq;
using System.Text;

#region -   文   件   说   明  -
//
//      创 建 人：何 苦
//      创建时间：2013/05/04 15:21:08
//      功    能：配置文件读写辅助类
//      个人网站：http://iheku.com
//
#endregion

namespace MouseAutoClick
{
    static class FileHelper
    {
        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="fullName">文件名</param>
        /// <returns>文件内容</returns>
        public static List<string> ReadAllText(string fullName)
        {
            return System.IO.File.ReadLines(fullName, Encoding.Default).ToList<string>();
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="fullName">文件名</param>
        /// <param name="content">待写内容</param>
        public static void WriteAllText(string fullName, List<string> content)
        {
            System.IO.File.WriteAllLines(fullName, content.ToArray<string>(), Encoding.Default);
        }
    }
}
