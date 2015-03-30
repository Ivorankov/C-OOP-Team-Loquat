namespace LoquatMegaStore.Items
{
    using System;
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Interfaces;

    public class Laptop : ComputerAppliance,ISoundable,IVideoPlayable
    {
        public Laptop(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
              int amountInStock, Dimensions dimensions, Processor processor, Display display, Speaker speaker,
              int ramMemory, int diskMemory, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, processor, color, ramMemory, diskMemory)
        {
            this.Display = display;
            this.Speaker = speaker;
        }
        public Display Display { get;  set; }


        public void PlayVideo()
        {
           
        }

        public Speaker Speaker{get;set;}


        public void PlaySound()
        {
            
        }
        //public override string ToString()
        //{
        //    return String.Format("Manufacturer: {0}\nModel: {1}\nWeight: {2}\nPrice: {3}\nPower consumption: {4}\nAmount in Stock: {5}\nDimentions: {6}\nProcessor: {7},");
        //}
    }
}
