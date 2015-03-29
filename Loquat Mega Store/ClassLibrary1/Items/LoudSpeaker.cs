namespace LoquatMegaStore.Items
{
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;
    using System;

    public class LoudSpeaker : AudioAppliance, ISoundable
    {
        private int impedance;
        private int sensitivity;

        public int Impedance
        {
            get { return this.impedance; }
            private set
            {
                if (value <=0)
                {
                    throw new ArgumentException("The impedance cannot be 0 or negative!");
                }
                this.impedance = value;
            }
        }

        public int Sensitivity
        {
            get { return this.sensitivity; }
            private set
            {
                if (value <=0)
                {
                    throw new ArgumentException("The sensitivity cannot be 0 or negative!");
                }
                this.sensitivity = value;
            }
        }

        public LoudSpeaker(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
              int amountInStock, Dimensions dimensions, Speaker speaker, int outputPower , Color color, int impedance, int sensitivity)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions,outputPower,color)
        {
            this.Impedance = impedance;
            this.Sensitivity = sensitivity;
        }

        public Speaker Speaker { get; set; }

        public void PlaySound()
        {
            throw new NotImplementedException();
        }
    }
}
