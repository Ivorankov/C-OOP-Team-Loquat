using System;
using LoquatMegaStore.Enumerators;
using LoquatMegaStore.Structures;
using LoquatMegaStore.Interfaces;

namespace LoquatMegaStore.Items
{
    public class Laptop : ComputerAppliance,IVideoPlayable,ISoundable
    {
        private Color color;
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public void PlaySound()
        {
            throw new NotImplementedException();
        }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }

        public Display Display
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double PorweOutput
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double Resistance
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public Laptop(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
               int amountInStock, Dimensions dimensions, Processor processor, Display display,
               double powerOutput,double resistance ,int ramMemory, int diskMemoery, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, processor, ramMemory, diskMemoery)
        {
            this.Color = color;
            this.Display = display;
            this.PorweOutput = powerOutput;
            this.Resistance = resistance;

        }
    }
}
