using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    interface IMovable
    {
        string GetObjectState();
        void SpeedUp(double newSpeed);
        double GetMaxSpeed();
    }
}
