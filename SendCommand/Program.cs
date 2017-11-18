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

        static void Main(string[] args)
        {
            //校验参数
            if (args.Length > 1 && CopyData.IsLogType(args[0]) && !string.Empty.Equals(args[1]))
            {
                IntPtr mainWindowPtr = FindWindow(null, MAIN_WINDOW);
                if (mainWindowPtr != IntPtr.Zero)
                {
                    COPYDATASTRUCT cds;
                    cds.dwData = (IntPtr)CopyData.GetLogType(args[0]);
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
