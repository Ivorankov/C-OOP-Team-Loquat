namespace LoquatMegaStore.Structures
{
    using System;
    public struct Speaker
    {
        private double powerOutput;
        private double resistance;

        public Speaker(double powerOutput, double resistance)
            :this()
        {
            this.PorweOutput = powerOutput;
            this.Resistance = resistance;
        }
        public double PorweOutput
        {
            get { return this.powerOutput; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Power output value cannot be less then or equal to 0.");
                }
                this.powerOutput = value;
            }
        }

        public double Resistance
        {
            get { return this.resistance; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Resistance value cannot be less then or equal to 0.");
                }
                this.resistance = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Power output: {0} / Resistance: {1}", PorweOutput, Resistance);
        }
    }
}
