namespace LoquatMegaStore.Items
{
	using System;

    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;

    public class MobilePhone : CommunicationAppliance, ICommunicational
    {
		private int? camera;
		private bool wifi;
		private int memory;

        public MobilePhone(string manufacturer, string model, decimal price,
            decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
            double? displaySize, Color color,
			bool wifi, int memory, int? camera = null)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color, displaySize)
        {
            this.Camera = camera;
            this.WiFi = wifi;
            this.Memory = memory;
        }

		public int? Camera 
			{ 
			get
				{
				return camera;
				}
			private set
				{
				if (value <= 0)
					{
					throw new ArgumentOutOfRangeException("The phone's camera in Megapixels cannot be zero or negative");
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
					throw new ArgumentOutOfRangeException("The phone's memory cannot be zero or negative");
					}
				memory = value;
				}
			}
    }
}
