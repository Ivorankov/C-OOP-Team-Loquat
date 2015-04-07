namespace LoquatMegaStore.Interfaces
{
    using LoquatMegaStore.Structures;

    interface IVideoPlayable
    {
        Display Display { get; }
        void PlayVideo();
    }
}
