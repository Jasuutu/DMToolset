namespace DMToolset.Character.CoreStats.Interfaces
{
    public interface ICoreStatistic
    {
        int GetModifier();

        ICoreStatistic ModifyCoreStatistic(int modifierAmount);
    }
}