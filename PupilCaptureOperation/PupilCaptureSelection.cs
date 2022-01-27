
using System.Collections.Generic;

namespace PupilCaptureOperation
{
    public class PupilCaptureSelection
    {

        public static IPupilCapture GetPupil(Dictionary<string, string> properties)
        {
            if (properties["pupilCaptureVersion"].Equals("v2"))
                return null;
            else
                return new PupilCapture_v1_1(properties);
        }

    }
}
