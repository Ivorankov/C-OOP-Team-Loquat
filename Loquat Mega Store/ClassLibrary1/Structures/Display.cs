namespace LoquatMegaStore.Structures
{
    using System;
    using LoquatMegaStore.Enumerators;

    public struct Display
    {
        private double size;
        private DisplayType displayType;
        private DisplayResolution displayRes;
        public double Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Display size value cannot be less then or equal to 0");
                }
                this.size = value;
            }
        }
        public DisplayType DisplayType
        {
            get { return this.displayType; }
            set { this.displayType = value; }
        }
        public DisplayResolution DisplayRes
        {
            get { return this.displayRes; }
            set { this.displayRes = value; }
        }
        public Display(double size, DisplayType displayType,DisplayResolution displayRes)
            :this()
        {
            this.DisplayType = displayType;
            this.DisplayRes = displayRes;
            this.Size = size;
        }

    }
}
