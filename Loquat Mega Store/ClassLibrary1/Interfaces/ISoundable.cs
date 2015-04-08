namespace LoquatMegaStore.Interfaces
{
    using LoquatMegaStore.Structures;

    public interface ISoundable
    {
        Speaker Speaker  { get; }

        void PlaySound();
    }
}
