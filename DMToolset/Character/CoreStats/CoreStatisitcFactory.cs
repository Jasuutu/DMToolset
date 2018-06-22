using System;
using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class CoreStatisitcFactory : ICoreStatisticFactory
    {
        private static ICoreStatisticFactory CoreStatisticFactorySingleton
        {
            get
            {
                return CoreStatisticFactorySingleton ?? new CoreStatisitcFactory();
            }
        }

        public static ICoreStatisticFactory GetFactory()
        {
            return CoreStatisticFactorySingleton;
        }

        public ICoreStatistic GenerateCoreStatistic<T>(int statisticValue) where T : ICoreStatistic
        {
            return (T)Activator.CreateInstance(typeof(T), statisticValue);
        }
    }
}