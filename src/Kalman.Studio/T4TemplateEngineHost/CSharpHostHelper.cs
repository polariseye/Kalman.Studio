using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman.Studio.T4TemplateEngineHost
{
    /// <summary>
    /// C#人host帮助类
    /// </summary>
    public static class CSharpHostHelper
    {
        /// <summary>
        /// 获取骆驼峰命名的字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sepratorChar">分隔字符串</param>
        /// <param name="startFieldIndex">开始的字段</param>
        /// <returns></returns>
        public static String GetCamelCaseName(this String str, char sepratorChar = '_', Int32 startFieldIndex = 0)
        {
            var fieldList = str.Split(sepratorChar);

            StringBuilder result = new StringBuilder();
            for (var index = startFieldIndex; index < fieldList.Length; index++)
            {
                var tmpStr = fieldList[index];
                result.Append(tmpStr.Substring(0, 1).ToUpper() + tmpStr.Substring(1));
            }

            return String.Join("", fieldList);
        }

        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="str">待处理的字符串</param>
        /// <returns></returns>
        public static String FirstUpper(this String str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        /// <summary>
        /// 首字母小写
        /// </summary>
        /// <param name="str">待处理的字符串</param>
        /// <returns></returns>
        public static String FirstLower(this String str)
        {
            return str.Substring(0, 1).ToLower() + str.Substring(1);
        }

        /// <summary>
        /// 转换为时间字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns></returns>
        public static String ToDateTimeString(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 转换为日期字符串
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns></returns>
        public static String ToDateString(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }
    }
}
