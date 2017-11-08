using System;
using System.IO;

namespace AutoTestFoundation.Util
{
    class PathUtil
    {
        /// <summary>
        /// 当前目录
        /// </summary>
        public static string CurrentPath = Environment.CurrentDirectory + "\\";

        /// <summary>
        /// 配置文件目录
        /// </summary>
        private  static string ConfigPath = CurrentPath + "Config\\";

        /// <summary>
        /// Log文件目录
        /// </summary>
        private static string LogPath = CurrentPath + "Log\\";

        /// <summary>
        /// 图片Log文件记录
        /// </summary>
        private static string ImageLogPath = CurrentPath + "ImageLog\\";

        /// <summary>
        /// 检查并创建指定目录
        /// </summary>
        /// <param name="path">指定目录</param>
        /// <returns>指定目录</returns>
        public static string MakePath(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        public static string GetConfigPath()
        {
            return MakePath(ConfigPath);
        }

        /// <summary>
        /// App配置文件路径
        /// </summary>
        /// <returns></returns>
        public static string GetAppConfig()
        {
            return GetConfigPath() + "Application.json";
        }

        public static string GetLogPath()
        {
            return MakePath(LogPath);
        }

        public static string GetImageLogPath()
        {
            return MakePath(ImageLogPath);
        }
    }
}
