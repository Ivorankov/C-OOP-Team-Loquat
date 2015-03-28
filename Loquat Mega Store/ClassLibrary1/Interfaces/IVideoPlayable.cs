namespace LoquatMegaStore.Interfaces
{
    using LoquatMegaStore.Structures;

    interface IVideoPlayable
    {
        Display Display { get; set; }
        void PlayVideo();
    }
}
