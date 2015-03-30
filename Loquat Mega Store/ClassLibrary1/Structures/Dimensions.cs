namespace LoquatMegaStore.Structures
{
    using System;
    using System.Linq;

    public struct Dimensions
    {
        private int x;
        private int y;
        private int z;

        public Dimensions(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X
        {
            get { return this.x; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Objects cannot have dimensions that are less than or equal to 0.");
                }
                this.x = value;
            }
        }
        public int Y
        {
            get { return this.y; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Objects cannot have dimensions that are less than or equal to 0.");
                }
                this.y = value;
            }
        }
        public int Z
        {
            get { return this.z; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Objects cannot have dimensions that are less than or equal to 0.");
                }
                this.z = value;
            }
        }
        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Z: {2}");
        }
    }
}
