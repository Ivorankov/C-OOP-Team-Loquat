namespace LoquatMegaStore.Items
{
    using System;

    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;

    public class TV : VideoAppliance, IVideoPlayable, ISoundable
    {
        public TV(string manufacturer, string model, decimal price, decimal weight, int powerConsumption,
            int amountInStock, Dimensions dimensions, Color color, Speaker speaker, Display display)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {
            this.Speaker = speaker;
            this.Display = display;
        }

        public Display Display { get; private set; }
        
        public Speaker Speaker { get; private set; }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }

        public void PlaySound()
        {
            throw new NotImplementedException();
        }
    }
}
