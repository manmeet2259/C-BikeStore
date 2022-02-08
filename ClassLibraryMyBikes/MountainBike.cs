using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    [Serializable]
    public class MountainBike : Bike
    {
        private double seatHeight;

        public MountainBike() : base()
        {
            
        }

        public MountainBike(long serialNumber, string make, string model, EnumColor color, double speed,DateTime date, EnumTypes type, double seatHeight) 
            : base(serialNumber, make, model, color, speed, date, type)
        {
            this.SeatHeight = seatHeight;
        }

        public double SeatHeight
        {
            get { return this.seatHeight; }
            set 
            { 
                if(Validator.ValidSeatHeight(value))
                {
                    this.seatHeight = value; 
                }
                else
                {
                    BikeException ex = new BikeException("Seat Height must be Greater than 50");
                    throw (ex);
                }
            }
        }
        public override void SpeedUp(double newSpeed)
        {
            double ChangedSpeed = this.Speed + newSpeed;

            if (ChangedSpeed < this.GetMaxSpeed())
            {
                this.Speed = ChangedSpeed;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "   |   " + this.seatHeight;
        }

        public override string GetStringFormat()
        {
            return base.GetStringFormat() + "   |   " + this.seatHeight;
        }
        public override string GetObjectState()
        {
            return base.GetStringFormat() + "   |   " + this.seatHeight;
        }
    }
}
