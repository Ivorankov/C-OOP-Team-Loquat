namespace LoquatMegaStore.Interfaces
{
    interface ISoundable
    {
        double PorweOutput { get; set; }
        double Resistance { get; set; }
        void PlaySound();
    }
}
