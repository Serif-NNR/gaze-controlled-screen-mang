using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonParsingLib
{
    public interface IDataAccessLayer
    {
        void UseToDataAsGazePoint(int x, int y);
        void UseToDataAsFixationPoint(int x, int y);
    }
}
