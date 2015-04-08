namespace LoquatMegaStore.Items
{
    using System.Collections.Generic;

    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;

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
