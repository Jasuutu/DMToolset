namespace DMToolset.Character.CoreStats.Interfaces
{
    public interface ICoreStatisticFactory
    {
        ICoreStatistic GenerateCoreStatistic<T>(int statisticValue) where T : ICoreStatistic;
    }
}