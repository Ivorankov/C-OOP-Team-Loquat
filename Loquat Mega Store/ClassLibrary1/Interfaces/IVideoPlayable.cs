using System;
using LoquatMegaStore.Structures;

namespace LoquatMegaStore.Interfaces
{
    interface IVideoPlayable
    {
        Display Display { get; set; }
        void PlayVideo();
    }
}
