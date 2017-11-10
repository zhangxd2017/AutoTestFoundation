using AutoTestFoundation.Control.Camera;
using AutoTestFoundation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFoundation.Manager
{
    class CameraManager : IUSBListener
    {

        private static CameraManager instance;

        private static object locker = new object();

        private CameraManager()
        {

        }

        public static CameraManager GetCameraManager()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new CameraManager();
                    }
                }
            }
            return instance;
        }

        public void OnUSBInsert()
        {
            List<CameraDevice> tmpCameras = CameraFactory.GetAllCamera();
        }
    }
}
