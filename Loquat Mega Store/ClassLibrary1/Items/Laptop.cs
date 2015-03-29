namespace LoquatMegaStore.Items
{
    using System;
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Interfaces;

    public class Laptop : ComputerAppliance, IVideoPlayable, ISoundable
    {
        public Laptop(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
              int amountInStock, Dimensions dimensions, Processor processor, Display display,
              double powerOutput, double resistance, int ramMemory, int diskMemory, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, processor, color, ramMemory, diskMemory)
        {
            this.Display = display;
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

        public Speaker Speaker
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
    }
}
