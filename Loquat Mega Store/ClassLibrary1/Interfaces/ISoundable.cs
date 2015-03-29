namespace LoquatMegaStore.Interfaces
{
    using LoquatMegaStore.Structures;
    interface ISoundable
    {
        Speaker Speaker  { get; set; }
        void PlaySound();
    }
}
