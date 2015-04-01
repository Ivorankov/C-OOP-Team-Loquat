namespace LoquatMegaStore.Items
{
    using System;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Enumerators;

    public abstract class AudioAppliance : Item
    {

        private int outputPower;

        public int OutputPower
        {
            get { return this.outputPower; }
            set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("The output power must be bigger than 0!");
                }
                this.outputPower = value;
            }
        }

        public AudioAppliance(string manufacturer, string model, decimal price, decimal weight,
            int powerConsumption, int amountInStock, Dimensions dimensions, int outputPower, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {
            this.OutputPower = outputPower;
        }
    }
}
