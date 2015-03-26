using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoquatMegaStore.Structures;

namespace LoquatMegaStore.Items
{
    public abstract class VideoAppliance : Item
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
    }
}
