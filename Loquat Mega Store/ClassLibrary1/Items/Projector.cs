namespace LoquatMegaStore.Items
{
    using System;
    using System.Linq;
    using LoquatMegaStore.Enumerators;

    public class Projector : VideoAppliance
    {
        private ProjectorType projectorType;
        private double weight;
        private DisplayResolution projectorResolution;
        private uint ansiLumens;
        private uint lampLife;

        public Projector(ProjectorType projectorType, double weight, DisplayResolution projectorResolution, uint ansiLumens = 1000, uint lampLife = 2000)
        {
            this.ProjectorType = projectorType;
            this.Weight = weight;
            this.ProjectorResolution = projectorResolution;
            this.ANSILumens = ansiLumens;
            this.LampLife = lampLife;
        }
        public uint LampLife
        {
            get { return lampLife; }
            private set 
            {
                if (value < 1500 || value > 5000)
                {
                    throw new ArgumentOutOfRangeException("Lamp life currently ranges between 1000 and 5000 hours"); 
                }
                this.lampLife = value; 
            }
        }
        public uint ANSILumens
        {
            get { return ansiLumens; }
            private set 
            {
                if (value < 400 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("The projectors' ANSI lumens are currently in the range 400 to 10 000");
                }
                this.ansiLumens = value; 
            }
        }
        public DisplayResolution ProjectorResolution
        {
            get { return projectorResolution; }
            private set { projectorResolution = value; }
        }
        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 10) 
                {
                    throw new ArgumentOutOfRangeException("The standard projectors' weight is currently in the range 1 to 10 kg");
                }
                this.weight = value;
            }
        }
        public ProjectorType ProjectorType
        {
            get { return projectorType; }
            private set { this.projectorType = value; }
        }
    }
}
