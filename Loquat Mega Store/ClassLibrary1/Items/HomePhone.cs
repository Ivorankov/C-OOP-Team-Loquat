namespace LoquatMegaStore.Items
	{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using LoquatMegaStore.Interfaces;
	using LoquatMegaStore.Structures;

	public class RadioStation : CommunicationAppliance, ICommunicational
		{
		public RadioStation(string manufacturer, string model, decimal price,
			decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
			double? displaySize, Color color,
			int cableLength, double batteryDocked, double batteryUndocked, string mobileOperator = null)
			: base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color, displaySize)
			{
			this.Cable = cableLength;
			this.BatteryDocked = batteryDocked;
			this.BatteryUndocked = batteryUndocked;
			this.Operator = mobileOperator;
			}

		public int Cable { get; set; }

		public double BatteryDocked { get; set; }

		public double BatteryUndocked { get; set; }

		public string Operator { get; set; }
		}
	}
