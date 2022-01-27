
namespace Gaze_Controlled_Screen_Magnifying_Application
{
    public class InitConfiguration
    {
        // Magnifier Configuration
        public float magLevel = 2.0f;
        public int scrollPercent = 10;
        public int magUpdateDurationMilliseconds = 10;
        public bool fShow = true;
        public bool fullScreenMagnifier = true;
        

        // Pupil Capture Configuration
        public string pupilRemoteAddress = "tcp://127.0.0.1:";
        public string pupilRemotePort = "50020";
        public string pupilCaptureVersion = "v1.1";
        public int gazeDataHz = 30;
        public int fixationDurationMilliseconds = 250;
        public float confidenceAmount = 0.80f;
        public string requestMessage = "surface";


        // Version
        public string version = "v2.0";
        

    }
}
