using MessagePack;
using MessagePack.Resolvers;
using System.Windows.Forms;

namespace JsonParsingLib
{
    public class ExtractionOfGazeAndFixation : IJsonParser
    {
        private IDataAccessLayer dataAccessLayer;

        public ExtractionOfGazeAndFixation(IDataAccessLayer dataAccessLayer)
        {
            this.dataAccessLayer = dataAccessLayer;
        }

        public void ParseData(byte[] data)
        {
            var pupil_data = MessagePackSerializer.Deserialize<dynamic>(data ,ContractlessStandardResolver.Options);
            MessageBox.Show(pupil_data);
        }
    }
}
