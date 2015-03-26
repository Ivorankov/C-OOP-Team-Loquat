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
        public Laptop(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
        int amountInStock, Dimentions dimentions, Processor processor, int ramMemory, int diskMemoery, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimentions, processor, ramMemory, diskMemoery)
        {
            this.Color = color;
        }
    }
}
