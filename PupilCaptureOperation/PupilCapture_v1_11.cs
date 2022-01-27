using NetMQ;
using NetMQ.Sockets;
using System.Collections.Generic;

namespace PupilCaptureOperation 
{
    class PupilCapture_v1_1 : IPupilCapture
    {
        public PupilCapture_v1_1(Dictionary<string, string> pupil_capture_properties) : base(pupil_capture_properties)
        {
            this.pupil_capture_properties = pupil_capture_properties;
        }

        private void CollectData(SubscriberSocket client)
        {
            while (true)
            {
                client.ReceiveFrameString();
                
                //sharedClass.SendMessage(client.ReceiveFrameBytes());
            }
        }
    }
}
