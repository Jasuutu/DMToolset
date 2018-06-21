namespace DMToolset.Character.CoreStats.Interfaces
{
    public interface ICoreStatistic
    {
        int GetUnmodifedModifier();

        ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount);
    }
}