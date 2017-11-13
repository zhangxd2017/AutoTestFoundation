using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Reflection;

namespace AutoTestFoundation
{
    class DataBaseManager
    {

        private static readonly object instanceLock = new object();

        private static DataBaseManager instance = null;

        private SQLiteHelper helper = null;

        private DataBaseManager()
        { }

        public static DataBaseManager GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    instance = new DataBaseManager();
                }
            }
            return instance;
        }

        public bool Init(string databasePath)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("data source=" + databasePath);
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                connection.Open();
                helper = new SQLiteHelper(command);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        public List<T> GetDatas<T>(string name)
        {
            List<T> lists = new List<T>();

            DataTable datas = helper.Select("SELECT * FROM " + name);

            for (int i = 0; i < datas.Rows.Count; i++)
            {
                T t = (T)Activator.CreateInstance(typeof(T));
                for (int j = 0; j < datas.Columns.Count; j++)
                {
                    DataColumn col = datas.Columns[j];
                    foreach (MemberInfo memberInfo in typeof(T).GetMembers(BindingFlags.NonPublic | BindingFlags.Instance
                    | BindingFlags.Public | BindingFlags.DeclaredOnly))
                    {
                        if (memberInfo.Name.Equals(col.ColumnName))
                        {
                            MethodInfo methodInfo = typeof(T).GetMethod("set_" + memberInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                            if(datas.Rows[i][j] != DBNull.Value)
                                methodInfo.Invoke(t, new object[] { datas.Rows[i][j] });
                        }
                    }
                }
                lists.Add(t);
            }

            return lists;
        }

        public void SetData<T>(List<T> list, string name)
        {
            helper.Execute("DELETE FROM " + name);
            for (int i = 0; i < list.Count; i++)
            {
                T t = list[i];
                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                foreach (MemberInfo memberInfo in typeof(T).GetMembers(BindingFlags.NonPublic | BindingFlags.Instance
                    | BindingFlags.Public | BindingFlags.DeclaredOnly))
                {
                    if (memberInfo.Name.StartsWith("get_"))
                    {
                        MethodInfo methodInfo = typeof(T).GetMethod(memberInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                        dictionary.Add(memberInfo.Name.Substring(4), methodInfo.Invoke(t, null));
                    }
                }
                helper.Insert(name, dictionary);
            }
        }

        public void CreateDataBase()
        {
            helper.Execute("CREATE TABLE [item]([Index] INT,[ItemName] CHAR,[ExecutablePath] CHAR,[Parameters] CHAR,[TimeOut] INT DEFAULT 3000,[RepeatCount] INT DEFAULT 1,[NeedTest] BOOL DEFAULT true); ");
            helper.Execute("CREATE TABLE [user]([Name] CHAR NOT NULL,[Password] CHAR NOT NULL); ");
            //helper.Execute("INSERT INTO ");
        }

        public void Deinit()
        {
            helper.GetCmd().Connection.Close();
        }

        public SQLiteHelper GetSQLiteHelper()
        {
            return helper;
        }

    }
}
