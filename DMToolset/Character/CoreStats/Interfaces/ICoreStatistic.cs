namespace DMToolset.Character.CoreStats.Interfaces
{
    public interface ICoreStatistic
    {
        int GetModifier();

        ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount);
    }
}