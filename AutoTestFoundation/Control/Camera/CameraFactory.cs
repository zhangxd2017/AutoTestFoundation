using AutoTestFoundation.Model;
using MVSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestFoundation.Control.Camera
{

    class CameraFactory
    {
        internal static List<CameraDevice> GetAllCamera()
        {
            tSdkCameraDevInfo[] tCameraDevInfoList;
            MvApi.CameraEnumerateDevice(out tCameraDevInfoList);
            if (tCameraDevInfoList != null && tCameraDevInfoList.Length > 0)
            {
                CameraDevice device = new CameraDevice();
            }
            return null;
        }
    }
}
