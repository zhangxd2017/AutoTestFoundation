using System;
using System.Collections.Generic;
using System.Management;

namespace AutoTestFoundation.Manager
{
    interface IUSBListener
    {
        void OnUSBInsert();
    }

    class USBManager
    {

        private static USBManager instance;

        private static object locker = new object();

        private List<IUSBListener> listeners;

        private ManagementEventWatcher insertWatcher = null;

        private DateTime lastSendTime;

        private USBManager()
        {
            listeners = new List<IUSBListener>();
            lastSendTime = DateTime.Now;
            try
            {
                ManagementScope Scope = new ManagementScope("root\\CIMV2");
                WqlEventQuery InsertQuery = new WqlEventQuery("__InstanceCreationEvent",
                            new TimeSpan(0, 0, 1),
                            "TargetInstance isa 'Win32_USBControllerDevice'");
                insertWatcher = new ManagementEventWatcher();
                insertWatcher = new ManagementEventWatcher(Scope, InsertQuery);
                insertWatcher.EventArrived += UsbInsertHandler;
                insertWatcher.Start();
            }
            catch (Exception)
            {
                RemoveUSBEventWatcher();
            }
        }

        private void RemoveUSBEventWatcher()
        {
            if (insertWatcher != null)
            {
                insertWatcher.Stop();
                insertWatcher = null;
            }
        }

        private void UsbInsertHandler(object sender, EventArrivedEventArgs e)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("USBInsert" + now);
            if (now >= lastSendTime.AddTicks(TimeSpan.TicksPerSecond * 3))
            {
                lastSendTime = now;
                Console.WriteLine("Send insert Message");
                lock (locker)
                {
                    foreach (var item in listeners)
                    {
                        item.OnUSBInsert();
                    }
                }
            }
        }

        public static USBManager GetUSBManager()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new USBManager();
                    }
                }
            }
            return instance;
        }

        public void AddListener(IUSBListener listener)
        {
            lock (locker)
            {
                listeners.Add(listener);
            }
        }

    }
}
