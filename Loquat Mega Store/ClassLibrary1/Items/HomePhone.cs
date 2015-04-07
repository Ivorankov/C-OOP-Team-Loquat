namespace LoquatMegaStore.Items
{
    using System;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Enumerators;

    public class HomePhone : CommunicationAppliance
    {
        private double batteryChargeTime;
        private double batteryStandbyTime;

        public HomePhone(string manufacturer, string model, decimal price,
            decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
            double? displaySize, Color color, Display display, Speaker speaker,
            double batteryDocked, double batteryStandbyTime = 0)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color, display, speaker)
        {
            this.BatteryDocked = batteryChargeTime;
            this.BatteryUndocked = batteryStandbyTime;
        }
        public double BatteryDocked
        {
            get
            {
                return batteryChargeTime;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("Battery recharge time cannot be less then or equal to 0!");
                }
                batteryChargeTime = value;
            }
        }

        public double BatteryUndocked
        {
            get
            {
                return batteryStandbyTime;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("Battery standby time cannot be less then or equal to 0!");
                }
                batteryStandbyTime = value;
            }
        }
    }
}
