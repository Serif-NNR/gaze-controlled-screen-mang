using PupilCaptureOperation;
using ScreenMagnifier;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gaze_Controlled_Screen_Magnifying_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> pupil_capture_properties = new Dictionary<string, string>();
        private StartMagnifier magnifier;

        private void Form1_Load(object sender, EventArgs e)
        {
            InitConfiguration configuration = new InitConfiguration();
            pupil_capture_properties.Add("pupilRemoteAddress"  , configuration.pupilRemoteAddress);
            pupil_capture_properties.Add("pupilRemotePort"     , configuration.pupilRemotePort);
            pupil_capture_properties.Add("pupilCaptureVersion" , configuration.pupilCaptureVersion);
            pupil_capture_properties.Add("requestMessage"      , configuration.requestMessage);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IPupilCapture pupil_capture = PupilCaptureSelection.GetPupil(pupil_capture_properties);
            magnifier = new StartMagnifier(pupil_capture);
        }
    }
}
