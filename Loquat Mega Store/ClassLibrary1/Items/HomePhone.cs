namespace LoquatMegaStore.Items
	{
	using System;

	using LoquatMegaStore.Interfaces;
	using LoquatMegaStore.Structures;

	public class HomePhone : CommunicationAppliance, ICommunicational
		{
		private int cableLength;
		private double batteryDocked;
		private double batteryUndocked;
		private string mobileOperator;

		public HomePhone(string manufacturer, string model, decimal price,
			decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
			double? displaySize, Color color,
			int cableLength, double batteryDocked, double batteryUndocked = 0, string mobileOperator = null)
			: base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color, displaySize)
			{
			this.CableLength = cableLength;
			this.BatteryDocked = batteryDocked;
			this.BatteryUndocked = batteryUndocked;
			this.Operator = mobileOperator;
			}

		public int CableLength 
			{ 
			get
				{
				return cableLength;
				}
			private set
				{
				if (value <= 0)
					{
					throw new NegativeValueException("The phone's camera in Megapixels cannot be zero or negative");
					}
				cableLength = value;
				}
			}

		public double BatteryDocked 
			{ 
			get
				{
				return batteryDocked;
				}
			private set
				{
				if (value <= 0)
					{
					throw new NegativeValueException("The phone's camera in Megapixels cannot be zero or negative");
					}
				batteryDocked = value;
				}
			}

		public double BatteryUndocked 
			{ 
			get
				{
				return batteryUndocked;
				}
			private set
				{
				if (value <= 0)
					{
					throw new NegativeValueException("The phone's camera in Megapixels cannot be zero or negative");
					}
				batteryUndocked = value;
				}
			}

		public string Operator 
			{ 
			get
				{
				return mobileOperator;
				}
			private set
				{
				if (value.Length < 1)
					{
					throw new ArgumentOutOfRangeException("The operator's name must be atleast one character long");
					}
				mobileOperator = value;
				}
			}
		}
	}
