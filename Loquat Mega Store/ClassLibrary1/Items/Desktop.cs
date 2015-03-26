using System;
using LoquatMegaStore.Enumerators;
using LoquatMegaStore.Structures;

namespace LoquatMegaStore.Items
{
    public class Desktop : ComputerAppliance
    {
        private Color color;
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Desktop(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
            int amountInStock, Dimensions dimensions, Processor processor, int ramMemory, int diskMemoery, Color color)
            :base(manufacturer,model,price,weight,powerConsumption,amountInStock,dimensions,processor, ramMemory,diskMemoery) 
        {
            this.Color = color;
        }
    }
}
