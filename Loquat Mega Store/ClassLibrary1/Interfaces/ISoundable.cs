namespace LoquatMegaStore.Interfaces
{
    using LoquatMegaStore.Structures;
    interface ISoundable
    {
        Speaker Speaker  { get; }
        void PlaySound();
    }
}
