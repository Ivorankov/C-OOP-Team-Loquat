namespace LoquatMegaStore.Structures
{
    using System;
    using System.Linq;

    public struct Processor
    {
        private int amountOfCores;
        private double clockSpeed;
        private int cache;

        public int AmountOfCores
        {
            get { return this.amountOfCores; }
            set 
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
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Processor frequency cannot be less then or equal to 0");
                }
                this.clockSpeed = value;
            }
        }
        public int Cache
        {
            get { return this.cache; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Processor cache cannot be less then or equal to 0");
                }
            }
        }
        public Processor(int cores, double frequency, int cache)
            :this()
        {
            this.AmountOfCores = cores;
            this.ClockSpeed = frequency;
            this.Cache = cache;
        }
    }
}
