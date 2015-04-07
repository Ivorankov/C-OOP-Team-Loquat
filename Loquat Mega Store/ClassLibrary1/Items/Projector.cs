namespace LoquatMegaStore.Items
{
    using System;
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;
    
    public class Projector : VideoAppliance
    {
        private ProjectorType projectorType;
        private uint ansiLumens;
        private uint lampLife;

        public Projector(string manufacturer, string model, decimal price, int amountInStock)
            : base(manufacturer, model, price, amountInStock)
        {
        }

        public Projector(string manufacturer, string model, decimal price, decimal weight, int powerConsumption, int amountInStock,
            Dimensions dimensions, Color color, DisplayResolution displayResolution,
            uint ansiLumens = 1000, uint lampLife = 2000)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {
            this.ProjectorType = projectorType;
            this.ANSILumens = ansiLumens;
            this.LampLife = lampLife;
        }

        public uint LampLife
        {
            get { return lampLife; }
            private set
            {
                if (value < 1500 || value > 5000)
                {
                    throw new ArgumentOutOfRangeException("Lamp life currently ranges between 1000 and 5000 hours");
                }
                this.lampLife = value;
            }
        }

        public uint ANSILumens
        {
            get { return ansiLumens; }
            private set
            {
                if (value < 400 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("The projectors' ANSI lumens are currently in the range 400 to 10 000");
                }
                this.ansiLumens = value;
            }
        }

        public ProjectorType ProjectorType
        {
            get { return projectorType; }
            private set { this.projectorType = value; }
        }
    }
}
