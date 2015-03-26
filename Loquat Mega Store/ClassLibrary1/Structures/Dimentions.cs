using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoquatMegaStore.Structures
{
    public struct Dimentions
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return this.x; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Objects cannot have dimentions that are less then or equat to 0");
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
                    throw new ArgumentOutOfRangeException("Objects cannot have dimentions that are less then or equat to 0");
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
                    throw new ArgumentOutOfRangeException("Objects cannot have dimentions that are less then or equat to 0");
                }
                this.z = value;
            }
        }
        public Dimentions(int x, int y, int z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
