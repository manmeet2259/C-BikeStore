using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    [Serializable]
    public abstract class Bike : Object, IMovable
    {
        private long serialNumber;
        private string make;
        private string model;
        private EnumColor color;
        private double speed;
        private DateTime date;
        private EnumTypes type;

        public Bike()
        {
            this.serialNumber = 0;
            this.make = "Undefined";
            this.model = "Undefined";
            this.color = EnumColor.Undefined;
            this.speed = 0.0;
            this.date = DateTime.Now;
            this.type = EnumTypes.Undefined;
        }

        public Bike(long serialNumber, string make, string model, EnumColor color, double speed, DateTime date, EnumTypes type)
        {
            this.SerialNumber = serialNumber;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Speed = speed;
            this.Type = type;
        }
        public long SerialNumber
        {
            get { return this.serialNumber; }
            set 
            { 
                if(value <= 1000)
                {
                    NotInRangeExc nrex = new NotInRangeExc("Serial number must be greater than 1000");
                    throw (nrex);
                }
                else
                {
                    this.serialNumber = value;
                }
                
            }
        }
        public string Make
        {
            get { return this.make; }
            set 
            { 
                if(Validator.IsNullOrEmptyValue(value))
                {
                    this.make = value;
                }
                else
                {
                    BikeException makeEx = new BikeException("Make : Please Enter a Value");
                    throw (makeEx);
                }
                 
            }
        }
        public string Model
        {
            get { return this.model; }
            set 
            {
                if (Validator.IsNullOrEmptyValue(value))
                {
                    this.model = value;
                }
                else
                {
                    BikeException modelEx = new BikeException("Model : Please Enter a Value");
                    throw (modelEx);
                }

            }
        }
        public EnumColor Color
        {
            get { return this.color; }
            set 
            { 
                if(Validator.IsValidColorOption(value))
                {
                    this.color = value;
                }
                else
                {
                    BikeException op = new BikeException();
                    throw (op);
                }
                 
            }
        }
        public EnumTypes Type
        {
            get { return this.type; }
            set {this.type = value;}
        }
        public double Speed
        {
            get { return this.speed; }
            set 
            {
                if (Validator.IsValidSpeedRange(value))
                {
                    this.speed = value;
                }
                else
                {
                    NotInRangeExc nrex = new NotInRangeExc("Speed must be in 0 to 40");
                    throw (nrex);
                }
            }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public abstract void SpeedUp(double newSpeed);
        public virtual double GetMaxSpeed()
        {
            return 20.00;
        }

        public override string ToString()
        {
            return this.serialNumber + "   |   " + this.make + "   |   " + this.model + "   |   " + this.color + "   |   " + this.speed + "   |   " + this.date + "   |   " + this.type;
        }
        public virtual string GetStringFormat()
        {
            return this.serialNumber + "   |   " + this.make + "   |   " + this.model + "   |   " + this.color + "   |   " + this.speed + "   |   " + this.date + "   |   " + this.type;
        }

        

        public abstract string GetObjectState();
    }
}
