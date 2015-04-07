namespace LoquatMegaStore.Items
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Enumerators;

    public abstract class VideoAppliance : Item
    {
        public VideoAppliance(string manufacturer, string model, decimal price, int amountInStock)
            : base(manufacturer, model, price, amountInStock)
        {
        }

        public VideoAppliance(string manufacturer, string model, decimal price, decimal weight, int powerConsumption,
            int amountInStock, Dimensions dimensions, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {
            this.VideoFeatures = new List<VideoFeatures>();
        }

        public List<VideoFeatures> VideoFeatures { get; set; }

        public void AddVideoFeature(VideoFeatures videoFeature)
        {
            this.VideoFeatures.Add(videoFeature);
        }
    }
}
