namespace LoquatMegaStore.Structures
{
    using System;
    using System.Linq;

    public struct Processor
    {
        private int amountOfCores;
        private double clockSpeed;
        private int cache;

        public Processor(int cores, double frequency, int cache)
            : this()
        {
            this.AmountOfCores = cores;
            this.ClockSpeed = frequency;
            this.Cache = cache;
        }

        public int AmountOfCores
        {
            get { return this.amountOfCores; }
           private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Processor cannot have less then 1 core");
                }
                this.amountOfCores = value;
            }
        }

        public double ClockSpeed
        {
            get { return this.clockSpeed; }
           private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Processor frequency cannot be less then or equal to 0");
                }
                this.clockSpeed = value;
            }
        }

        public int Cache
        {
            get { return this.cache; }
           private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Processor cache cannot be less then or equal to 0");
                }
                this.cache = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Cores: {0} / Clock speed: {1} / Cache: {2}", AmountOfCores, ClockSpeed, Cache);
        }
    }
}
