namespace LoquatMegaStore.Items
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;

    public class TV : VideoAppliance
    {
        private List<VideoFeatures> tvFeatures;

        public TV(string manufacturer, string model, decimal price, decimal weight, int powerConsumption,
            int amountInStock, Dimensions dimensions, Color color, DisplayResolution displayResolution, DisplayType displayType)
            : base (manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color, displayResolution, displayType)
        {
            this.TVFeatures = new List<VideoFeatures>();
        }
        public List<VideoFeatures> TVFeatures
        {
            get { return tvFeatures; }
            set { tvFeatures = value; }
        }
        public override void AddVideoFeature(VideoFeatures videofeature)
        {
            this.TVFeatures.Add(videofeature);
        }
    }
}
