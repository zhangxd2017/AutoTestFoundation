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

        public static bool IsLogType(string value)
        {
            return LogType.Verbose.ToString().Equals(value) ||
                LogType.Debug.ToString().Equals(value) ||
                LogType.Info.ToString().Equals(value) ||
                LogType.Error.ToString().Equals(value);
        }

        public static LogType GetLogType(string value)
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

        public static LogType GetLogType(int value)
        {
            switch (value)
            {
                case 3:
                    return LogType.Error;
                case 2:
                    return LogType.Info;
                case 1:
                    return LogType.Debug;
                case 0:
                default:
                    return LogType.Verbose;
            }
        }
    }
}
