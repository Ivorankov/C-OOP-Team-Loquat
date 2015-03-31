namespace LoquatMegaStore.Items
	{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using LoquatMegaStore.Interfaces;
	using LoquatMegaStore.Structures;

	public class MobilePhone : CommunicationAppliance, ICommunicational
		{
		public MobilePhone(string manufacturer, string model, decimal price,
			decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
			double? displaySize, Color color,
			int camera, bool wifi, int memory)
			: base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color, displaySize)
			{
			this.Camera = camera;
			this.WiFi = wifi;
			this.Memory = memory;
			}

		public int Camera { get; set; }

		public bool WiFi { get; set; }

		public int Memory { get; set; }
		}
	}
