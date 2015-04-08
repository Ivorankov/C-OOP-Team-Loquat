namespace LoquatMegaStore.Items
{
    using System;

    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Structures;
    using LoquatMegaStore.Interfaces;

    public abstract class CommunicationAppliance : Item, IVideoPlayable, ISoundable
    {
        public CommunicationAppliance(string manufacturer, string model, decimal price,
            decimal weight, int powerConsumption, int amountInStock, Dimensions dimensions,
            Color color, Display display, Speaker speaker)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, color)
        {
            this.Display = display;
            this.Speaker = speaker;
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
