using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    [Serializable]
    public class RoadBike : Bike
    {
        private EnumSuspension suspension;
        private double heightFromGround;

        public RoadBike() : base()
        {
            
        }
        public RoadBike(long serialNumber, string make, string model, EnumColor color, EnumTypes type, 
            double speed, DateTime date, double heightFromGround, EnumSuspension suspension ) 
            : base(serialNumber, make, model, color, speed, date, type)
        {
            this.Suspension = suspension;
            this.HeightFromGround = heightFromGround;
        }

        public double HeightFromGround
        {
            get { return this.heightFromGround; }
            set 
            {
                if (value > 100)
                {
                    this.heightFromGround = value;
                }
                else
                {
                    NotInRangeExc nrex = new NotInRangeExc("Height From Ground must be greater than 100");
                    throw (nrex);
                }
            }
        }
        public EnumSuspension Suspension
        {
            get { return this.suspension; }
            set 
            {
                if (Validator.IsValidSuspension(value))
                {
                    this.suspension = value;
                }
                else
                {
                    BikeException bk = new BikeException("Please choose Suspension Value");
                    throw (bk);
                }  
            }
        }

        public override double GetMaxSpeed()
        {
            this.Speed = 40.00;
            return Speed;
        }

        public override void SpeedUp(double newSpeed)
        {
            double updatedSpeed = this.Speed + newSpeed;

            if (updatedSpeed < this.GetMaxSpeed())
            {
                this.Speed = updatedSpeed;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "   |   " + this.suspension + "   |   " + this.heightFromGround;
        }

        public override string GetStringFormat()
        {
            return base.GetStringFormat() + "   |   " + this.suspension + "   |   " + this.heightFromGround;
        }
        public override string GetObjectState()
        {
            return base.GetStringFormat() + "   |   " + this.suspension + "   |   " + this.heightFromGround;
        }
    }
}
