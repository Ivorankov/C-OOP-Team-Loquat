namespace LoquatMegaStore.Items
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Interfaces;

    public class TV : VideoAppliance, IVideoPlayable, ISoundable
    {
        public TV(string manufacturer, string model, decimal price, decimal weight, int powerConsumption,
            int amountInStock, Dimensions dimensions, Color color)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {

        }
        public Display Display { get; private set; }
        public void PlayVideo()
        {
            throw new NotImplementedException();
        }
        public Speaker Speaker { get; private set; }
        public void PlaySound()
        {
            throw new NotImplementedException();
        }
    }
}
