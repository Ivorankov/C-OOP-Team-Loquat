using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoquatMegaStore.Interfaces;

namespace LoquatMegaStore.Items
{
    public abstract class AudioAppliance : Item
    {
        private double resistance;
        private double powerOutput;
        public double Resistance
        {
            get { return this.resistance; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Speaker resistance value cannot be less then or equal to 0");
                }
                this.resistance = value;
            }
        }
        public double PowerOutput
        {
            get { return this.powerOutput; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Speaker power output value cannot be less then or equal to 0");
                }
                this.powerOutput = value;
            }
        }
    }
}
