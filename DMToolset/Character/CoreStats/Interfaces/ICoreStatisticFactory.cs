namespace DMToolset.Character.CoreStats.Interfaces
{
    public interface ICoreStatisticFactory
    {
        ICoreStatistic GenerateCoreStatistic(CoreStatisticType statisticType, int statisticValue);
    }
}