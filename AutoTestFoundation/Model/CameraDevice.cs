
namespace AutoTestFoundation.Model
{
    public enum CameraType
    {
        MindVision
    }

    class CameraDevice
    {
        public CameraType Type { get; set; }

        public string Name { get; set; }

        public string DeviceId { get; set; }
    }
}
