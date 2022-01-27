using JsonParsingLib;
using NetMQ;
using NetMQ.Sockets;
using System.Collections.Generic;

namespace PupilCaptureOperation
{
    public class IPupilCapture
    {
        public Dictionary<string, string> pupil_capture_properties;
        public IJsonParser jsonParser;
        public SubscriberSocket client;

        public IPupilCapture(Dictionary<string, string> pupil_capture_properties)
        {
            this.pupil_capture_properties = pupil_capture_properties;
        }

        public void Connect()
        {
            client = ConnectAsSubscriber(pupil_capture_properties["pupilRemoteAddress"], 
                ReceiveSubPort(pupil_capture_properties["pupilRemoteAddress"], 
                pupil_capture_properties["pupilRemotePort"]), pupil_capture_properties["requestMessage"]);
        }

        private string ReceiveSubPort(string ip, string port)
        {
            using (var client = new RequestSocket())
            {
                client.Connect($"{ip}{port}");
                client.SendFrame("SUB_PORT");
                return client.ReceiveFrameString();
            }
        }

        private SubscriberSocket ConnectAsSubscriber(string ip, string subPort, string requestMessage)
        {
            var client = new SubscriberSocket();
            client.Connect($"{ip}{subPort}");
            client.Subscribe(requestMessage);
            return client;
        }

        public void GetData(IJsonParser jsonParser)
        {
            this.jsonParser = jsonParser;
            new System.Threading.Thread((System.Threading.ThreadStart)delegate { CollectData(client); }).Start();
        }


        private void CollectData(SubscriberSocket client)
        {
            throw new FiniteStateMachineException();
        }

        
        private void TransformToPixelCoordinates()
        {

        }

    }
}
