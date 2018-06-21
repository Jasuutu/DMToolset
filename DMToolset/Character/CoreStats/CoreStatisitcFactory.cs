using System;
using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class CoreStatisitcFactory : ICoreStatisticFactory
    {
        public ICoreStatistic GenerateCoreStatistic<T>(int statisticValue) where T : ICoreStatistic
        {
            return (T)Activator.CreateInstance(typeof(T), statisticValue);
        }
    }
}