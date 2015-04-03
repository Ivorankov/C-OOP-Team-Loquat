namespace LoquatMegaStore.Items
	{
	using System;

	using LoquatMegaStore.Structures;

	public abstract class CommunicationAppliance : Item
		{
		private double? displaySize;

		public CommunicationAppliance(string manufacturer, string model, decimal price,
			decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
			Color color, double? displaySize = null)
			: base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
			{
			this.DisplaySize = displaySize;
			this.Colour = color;
			}

		public double? DisplaySize
			{ 
			get
				{
				return displaySize;
				}
			private set
				{
				if (value <= 0)
					{
					throw new ArgumentOutOfRangeException("The display size of a mobile phone cannot be zero or negative");
					}
				displaySize = value;
				}
			}

		public Color Colour { get; private set; }
		}
	}
