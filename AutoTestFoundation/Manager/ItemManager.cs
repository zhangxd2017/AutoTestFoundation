using AutoTestFoundation.Model;
using System.Collections.Generic;

namespace AutoTestFoundation.Manager
{
    class ItemManager
    {

        public const string DATABASE_TABLE_ITEM_NAME = "item";

        private static ItemManager instance;

        private static object locker = new object();

        private List<Item> items;

        private ItemManager()
        {
            items = new List<Item>();
        }

        public static ItemManager GetItemManager()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ItemManager();
                    }
                }
            }
            return instance;
        }

        public void InitWithConfig(string path)
        {
            lock (locker)
            {
                DataBaseManager.GetInstance().Init(path);
                List<Item> dbItem = DataBaseManager.GetInstance().GetDatas<Item>(DATABASE_TABLE_ITEM_NAME);
                DataBaseManager.GetInstance().Deinit();
                dbItem.Sort((x,y) => { return x.Index.CompareTo(y.Index); });
                for (int i = 0; i < dbItem.Count; i++)
                {
                    items.Add(dbItem[i]);
                }
            }
        }

        public List<Item> GetItems()
        {
            lock (locker)
            {
                return items;
            }
        }
    }
}
