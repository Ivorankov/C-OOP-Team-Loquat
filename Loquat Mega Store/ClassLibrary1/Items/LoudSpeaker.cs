namespace LoquatMegaStore.Items
{
    using System;

    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;

    public class LoudSpeaker : AudioAppliance, ISoundable
    {
        private int impedance;
        private int sensitivity;

        public LoudSpeaker(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
      int amountInStock, Dimensions dimensions, Speaker speaker, int outputPower, Color color, int impedance, int sensitivity)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, outputPower, color)
        {
            this.Impedance = impedance;
            this.Sensitivity = sensitivity;
            this.Speaker = speaker;
        }

        public int Impedance
        {
            get { return this.impedance; }
            private set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("The impedance cannot be 0 or negative!");
                }
                this.impedance = value;
            }
        }

        public int Sensitivity
        {
            get { return this.sensitivity; }
            private set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("The sensitivity cannot be 0 or negative!");
                }
                this.sensitivity = value;
            }
        }

        public Speaker Speaker { get; set; }

        public void PlaySound()
        {
            throw new NotImplementedException();
        }
    }
}
