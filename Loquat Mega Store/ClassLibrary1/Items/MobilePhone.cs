namespace LoquatMegaStore.Items
{
    using System;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Enumerators;

    public class MobilePhone : CommunicationAppliance
    {
        private double? camera;//in Megapix
        private bool wifi;
        private int memory;

        public MobilePhone(string manufacturer, string model, decimal price,
            decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions, Color color,
            Display display, Speaker speaker, bool wifi, int memory, double? camera = null)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color, display, speaker)
        {
            this.Camera = camera;
            this.WiFi = wifi;
            this.Memory = memory;
        }

        public double? Camera
        {
            get
            {
                return camera;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("The phone's camera in Megapixels cannot be zero or negative");
                }
                camera = value;
            }
        }

        public bool WiFi
        {
            get
            {
                return wifi;
            }
            private set
            {
                wifi = value;
            }
        }

        public int Memory
        {
            get
            {
                return memory;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("The phone's memory cannot be zero or negative");
                }
                memory = value;
            }
        }
    }
}
