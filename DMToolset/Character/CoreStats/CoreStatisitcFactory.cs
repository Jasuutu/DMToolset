using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class CoreStatisitcFactory : ICoreStatisticFactory
    {
        public ICoreStatistic GenerateCoreStatistic(CoreStatisticType statisticType, int statisticValue)
        {
            switch (statisticType)
            {
                case CoreStatisticType.None:
                    return new VoidStatistic();
                case CoreStatisticType.Strength:
                    return new Stength(statisticValue);
                case CoreStatisticType.Dexterity:
                    return new Dexterity(statisticValue);
                case CoreStatisticType.Constitution:
                    return new Constitution(statisticValue);
                case CoreStatisticType.Intelligence:
                    return new Intelligence(statisticValue);
                case CoreStatisticType.Wisdom:
                    return new Wisdom(statisticValue);
                case CoreStatisticType.Charisma:
                    return new Charisma(statisticValue);
                default:
                    return new VoidStatistic();
            }
        }
    }

    public enum CoreStatisticType
    {
        None = 0,
        Strength = 1,
        Dexterity = 2,
        Constitution = 3,
        Intelligence = 4,
        Wisdom = 5,
        Charisma = 6
    }
}