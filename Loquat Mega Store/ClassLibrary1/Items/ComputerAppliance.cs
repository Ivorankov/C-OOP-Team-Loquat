﻿namespace LoquatMegaStore.Items
{
    using System;

    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Enumerators;

    public abstract class ComputerAppliance : Item
    {
        private Processor processor;
        private int ramMemory; // in MBs
        private int diskMemory;

        public ComputerAppliance(string manufacturer, string model, decimal price, decimal weight,
            int powerConsumption, int amountInStock, Dimensions dimensions, Processor processor, Color color, int ramMemory, int diskMemory)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {
            this.Processor = processor;
            this.RamMemory = ramMemory;
            this.DiskMemory = diskMemory;
        }

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
                    throw new NegativeValueException("Ram memory cannot have a negative or 0 value!");
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
                    throw new NegativeValueException("Disk memory cannot have a negative or 0 value.");
                }
                this.diskMemory = value;
            }
        }
    }
}
