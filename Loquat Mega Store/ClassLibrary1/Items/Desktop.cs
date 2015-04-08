namespace LoquatMegaStore.Items
{
    using System;
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;

    public class Desktop : ComputerAppliance
    {
        public Desktop(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
           int amountInStock, Dimensions dimensions, Processor processor, int ramMemory, int diskMemoery, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, processor, color, ramMemory, diskMemoery)
        { }       
    }
}
