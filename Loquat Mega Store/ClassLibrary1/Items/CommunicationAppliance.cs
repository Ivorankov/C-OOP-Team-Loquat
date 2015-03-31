namespace LoquatMegaStore.Items
	{
	using LoquatMegaStore.Structures;

	public abstract class CommunicationAppliance : Item
		{

		public CommunicationAppliance(string manufacturer, string model, decimal price,
			decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
			Color color, double? displaySize = null)
			: base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
			{
			this.DisplaySize = displaySize;
			this.Colour = color;
			}

		public double? DisplaySize { get; set; }

		public Color Colour { get; set; }
		}
	}
