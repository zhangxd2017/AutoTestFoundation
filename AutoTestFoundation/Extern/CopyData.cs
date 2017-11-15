using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFoundation.Extern
{
    public enum LogType
    {
        Verbose,
        Debug,
        Info,
        Error
    }

    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public int cbData;
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;
    }

    public class CopyData
    {
        public const int WM_COPYDATA = 0x004A;

        public const int MSG_TYPE_LOG = 100;

        public const int MSG_TOUCH_SCREEN = 101;

        public const int MSG_SET_CONTROL = 102;

        public const int MSG_GET_PHOTO = 103;
    }
}
