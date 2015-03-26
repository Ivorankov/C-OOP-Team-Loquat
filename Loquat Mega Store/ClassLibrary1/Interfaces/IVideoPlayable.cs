using System;
using LoquatMegaStore.Structures;

namespace LoquatMegaStore.Interfaces
{
    interface IVideoPlayable
    {
        private Display display;
        private VideoFormat formatSupport;

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public VideoFormat FormatSupport
        {
            get { return this.formatSupport; }
            set { this.formatSupport = value; }
        }
        void PlayVideo();
    }
}
