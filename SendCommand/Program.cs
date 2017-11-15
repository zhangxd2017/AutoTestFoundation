using AutoTestFoundation.Extern;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SendLog
{
    class Program
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static int SendMessage(IntPtr hwnd, int wMsg, int wParam, ref COPYDATASTRUCT lParam);

        public const string MAIN_WINDOW = "赛远科技";

        static bool IsLogType(string value)
        {
            return LogType.Verbose.ToString().Equals(value) ||
                LogType.Debug.ToString().Equals(value) ||
                LogType.Info.ToString().Equals(value) ||
                LogType.Error.ToString().Equals(value);
        }

        static LogType GetLogType(string value)
        {
            if (LogType.Verbose.ToString().Equals(value))
            {
                return LogType.Verbose;
            }
            else if (LogType.Debug.ToString().Equals(value))
            {
                return LogType.Debug;
            }
            else if (LogType.Info.ToString().Equals(value))
            {
                return LogType.Info;
            }
            else
            {
                return LogType.Error;
            }
        }

        static void Main(string[] args)
        {
            //校验参数
            if (IsLogType(args[0]) && !string.Empty.Equals(args[1]))
            {
                IntPtr mainWindowPtr = FindWindow(null, MAIN_WINDOW);
                if (mainWindowPtr != IntPtr.Zero)
                {
                    COPYDATASTRUCT cds;
                    cds.dwData = (IntPtr)GetLogType(args[0]);
                    cds.lpData = args[1];
                    cds.cbData = Encoding.Default.GetBytes(args[1]).Length + 1;
                    SendMessage(mainWindowPtr, CopyData.WM_COPYDATA, CopyData.MSG_TYPE_LOG, ref cds);
                }
                else
                {
                    Console.WriteLine("window not found");
                }
            }
            else
            {
                Console.WriteLine("param error");
            }
        }
    }
}
