
namespace AutoTestFoundation.Model
{
    class Item
    {
        public int Index { get; set; }

        public string ItemName { get; set; }

        public string ItemText { get; set; }

        public string ExecutablePath { get; set; }

        public string Parameters { get; set; }

        public int TimeOut { get; set; }

        public int RepeatCount { get; set; }

        public bool NeedTest { get; set; }
    }
}
