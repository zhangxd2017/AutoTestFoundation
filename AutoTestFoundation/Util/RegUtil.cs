using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoTestFoundation.Util
{
    class RegUtil
    {
        public static bool IsNumber(object obj)
        {
            if (obj is string)
            {
                string objStr = (string)obj;
                Regex reg = new Regex("^\\d+$");
                return reg.IsMatch(objStr);
            }
            return false;
        }

        public static string TrimInvisiable(string str)
        {
            return Regex.Replace(str, @"[^\x21-\x7E]", "");
        }

        public static bool IsJson(string str)
        {
            str = TrimInvisiable(str);
            if (str.StartsWith("{"))
            {
                return IsJsonObject(str);
            }
            else if (str.StartsWith("["))
            {
                return IsJsonArray(str);
            }
            return false;
        }

        public static bool IsJsonObject(string str)
        {
            bool isMatch = false;
            if (str[0] != '{' || str[str.Length - 1] != '}')
            {
                return isMatch;
            }
            string content = str.Substring(1, str.Length - 2);
            string[] objects = SplitJson(content);
            for (int i = 0; i < objects.Length; i++)
            {
                string obj = objects[i];
                string[] kvs = SplitJsonKeyValue(obj);
                if (kvs.Length == 2)
                {
                    if (kvs[1].StartsWith("{") || kvs[1].StartsWith("["))
                    {
                        isMatch = IsJson(kvs[1]);
                        if (!isMatch)
                        {
                            return false;
                        }
                    }
                    else 
                    {
                        if (kvs[1].Contains("{") || kvs[1].Contains("}") || kvs[1].Contains("[") || kvs[1].Contains("]"))
                        {
                            isMatch = false;
                            return false;
                        }
                        else
                        {
                            isMatch = true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return isMatch;
        }

        public static bool IsJsonArray(string str)
        {
            bool isMatch = false;
            if (str[0] != '[' || str[str.Length - 1] != ']')
            {
                return isMatch;
            }
            string content = str.Substring(1, str.Length - 2);
            string[] objects = SplitJson(content);
            for (int i = 0; i < objects.Length; i++)
            {
                string obj = objects[i];
                if (obj.StartsWith("{"))
                {
                    isMatch = IsJson(obj);
                    if (!isMatch)
                    {
                        return false;
                    }
                }
                else
                {
                    if (obj.Contains("{") || obj.Contains("}") || obj.Contains("[") || obj.Contains("]"))
                    {
                        isMatch = false;
                        return false;
                    }
                    else
                    {
                        isMatch = true;
                    }
                }
            }
            return isMatch;
        }

        private static string[] SplitJson(string str)
        {
            int objLevel = 0, arrLevel = 0, cutPosition = 0;
            List<string> retStr = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{')
                {
                    objLevel++;
                }
                else if (str[i] == '}')
                {
                    objLevel--;
                }
                else if (str[i] == '[')
                {
                    arrLevel++;
                }
                else if (str[i] == ']')
                {
                    arrLevel--;
                }
                else if (str[i] == ',')
                {
                    if (objLevel == 0 && arrLevel == 0)
                    {
                        retStr.Add(str.Substring(cutPosition, i - cutPosition));
                        cutPosition = i + 1;
                    }
                }

                if (i == str.Length - 1)
                {
                    retStr.Add(str.Substring(cutPosition, i - cutPosition + 1));
                    cutPosition = i + 1;
                }
            }
            return retStr.ToArray();
        }

        private static string[] SplitJsonKeyValue(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ':')
                {
                    return new string[] { str.Substring(0, i), str.Substring(i + 1, str.Length - i - 1) };
                }
            }
            return new string[] { };
        }
    }
}
