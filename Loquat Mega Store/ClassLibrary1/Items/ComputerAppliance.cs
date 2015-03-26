using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoquatMegaStore.Interfaces;
using LoquatMegaStore.Structures;

namespace LoquatMegaStore.Items
{
    public abstract class ComputerAppliance : Item
    {
        private Processor processor;
        private int ramMemory;//in mb's
        private int diskMemory;

        public Processor Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public int RamMemory
        {
            get { return this.ramMemory; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Ram memory cannot have a negative or 0 value!");
                }
                this.ramMemory = value;
            }
        }
        public int DiskMemory
        {
            get { return this.diskMemory; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Disk memory cannot have a negative or 0 value");
                }
                this.diskMemory = value;
            }
        }
        //public ComputerAppliance() // MAKES THE PROGRAM BUILD ( TO BE DELETED )
        //{

        //}
        public ComputerAppliance(string manufacturer,string model,decimal price, decimal weight,
            int powerConsumption, int amountInStock, Dimentions dimentions, Processor processor, int ramMemory, int diskMemoery)
            :base(manufacturer,model,price,weight,powerConsumption,amountInStock,dimentions)
        {
            this.Processor = processor;
            this.RamMemory = ramMemory;
            this.DiskMemory = diskMemoery;
        }
    }
}
