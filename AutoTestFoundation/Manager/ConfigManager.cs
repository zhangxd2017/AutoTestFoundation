using AutoTestFoundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFoundation.Manager
{
    class ConfigManager
    {
        private static ConfigManager instance;

        private static object locker = new object();

        private TestConfig testConfig;

        private ConfigManager()
        {

        }

        public static ConfigManager GetConfigManager()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ConfigManager();
                    }
                }
            }
            return instance;
        }

        public void InitWithConfig(string path)
        {

        }
    }
}
