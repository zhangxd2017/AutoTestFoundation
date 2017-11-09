using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTestFoundation.Util
{
    public enum LogType
    {
        Verbose,
        Debug,
        Info,
        Error
    }

    class LogUtil
    {
        /// <summary>
        /// 构建Log字符串
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string Log(string message)
        {
            return DateTime.Now.ToString("hh:mm:ss    ") + message + "\r\n";
        }

        /// <summary>
        /// 在RichTextBox中显示不同颜色的Log
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public static void Log(RichTextBox textBox, LogType type, string message)
        {
            switch (type)
            {
                case LogType.Verbose:
                    textBox.SelectionColor = SystemColors.WindowText;
                    break;
                case LogType.Debug:
                    textBox.SelectionColor = Color.DarkBlue;
                    break;
                case LogType.Info:
                    textBox.SelectionColor = Color.DarkGreen;
                    break;
                case LogType.Error:
                    textBox.SelectionColor = Color.Red;
                    break;
                default:
                    break;
            }
            textBox.AppendText(Log(message));
        }

        public static void LogV(RichTextBox textBox, string message)
        {
            Log(textBox, LogType.Verbose, message);
        }

        public static void LogD(RichTextBox textBox, string message)
        {
            Log(textBox, LogType.Debug, message);
        }

        public static void LogI(RichTextBox textBox, string message)
        {
            Log(textBox, LogType.Info, message);
        }

        public static void LogE(RichTextBox textBox, string message)
        {
            Log(textBox, LogType.Error, message);
        }

        /// <summary>
        /// 将Log写入文本
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="message"></param>
        public static void Log(string filePath, string message)
        {
            File.AppendAllText(filePath, message);
        }

        public static void LogAdmin(RichTextBox textBox, string filePath, LogType type, string message)
        {
            Log(textBox, type, message);
            Log(filePath, message);
        }

        public static void LogTest(RichTextBox textBox, string filePath, LogType type, string message)
        {
            if (type > LogType.Debug)
            {
                Log(textBox, type, message);
                Log(filePath, message);
            }
        }
    }
}
