namespace LoquatMegaStore.Items
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Enumerators;

    public abstract class VideoAppliance : Item
    {
        private List<VideoFeatures> videoFeatures;

        public VideoAppliance(string manufacturer, string model, decimal price, decimal weight, int powerConsumption,
            int amountInStock, Dimensions dimensions, Color color, DisplayResolution displayResolution, DisplayType displayType)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {
            this.DisplayResolution = displayResolution;
            this.DisplayType = displayType;
            this.VideoFeatures = new List<VideoFeatures>();
        }
        public List<VideoFeatures> VideoFeatures { get; set; }
        public DisplayResolution DisplayResolution { get; set; }
        public DisplayType DisplayType { get; set; }

        public abstract void AddVideoFeature(VideoFeatures videoFeature);
    }
}
