namespace LoquatMegaStore.Items
{
    using LoquatMegaStore.Enumerators;
    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.Structures;
    using System;

    public class SoundPlayer : AudioAppliance, ISoundable, IVideoPlayable
    {

        private int radioStationMemory;
        private AudioFormat audioFormat;

        public SoundPlayer(string manufacturer, string model, decimal weight, decimal price, int powerConsumption,
              int amountInStock, Dimensions dimensions, Speaker speaker, Display display, int outputPower, Color color, int stations, AudioFormat playModes)
            : base(manufacturer, model, price, weight, powerConsumption, amountInStock, dimensions, outputPower, color)
        {
            this.RadioStationMemory = stations;
            this.Speaker = speaker;
            this.AudioFormat = playModes;
        }

        public int RadioStationMemory
        {
            get { return this.radioStationMemory; }
            set
            {
                if (value <= 0)
                {
                    throw new NegativeValueException("The stations memorizable from the system have to be more than 0!");
                }
                this.radioStationMemory = value;
            }
        }
        public AudioFormat AudioFormat
        {
            get { return this.audioFormat; }
            private set { this.audioFormat = value; }
        }
        public Speaker Speaker { get; set; }
        public void PlaySound()
        {
            throw new NotImplementedException();
        }

        public Display Display { get; private set; }

        public void PlayVideo()
        {
            throw new NotImplementedException();
        }
    }
}
