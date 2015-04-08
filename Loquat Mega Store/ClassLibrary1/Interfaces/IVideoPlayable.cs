namespace LoquatMegaStore.Interfaces
{
    using LoquatMegaStore.Structures;

    public interface IVideoPlayable
    {
        Display Display { get; }

        void PlayVideo();
    }
}
