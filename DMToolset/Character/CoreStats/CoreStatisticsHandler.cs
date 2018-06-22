using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class CoreStatisticsHandler
    {
        private readonly IList<ICoreStatistic> statsCollection;
        private readonly ICoreStatisticFactory factory;

        public CoreStatisticsHandler()
        {
            this.statsCollection = new List<ICoreStatistic>();

            factory = CoreStatisitcFactory.GetFactory();
        }

        public void GenerateFreshStats()
        {
            statsCollection.Clear();

            statsCollection.Add(factory.GenerateCoreStatistic<Strength>(8));
            statsCollection.Add(factory.GenerateCoreStatistic<Dexterity>(8));
            statsCollection.Add(factory.GenerateCoreStatistic<Constitution>(8));
            statsCollection.Add(factory.GenerateCoreStatistic<Intelligence>(8));
            statsCollection.Add(factory.GenerateCoreStatistic<Wisdom>(8));
            statsCollection.Add(factory.GenerateCoreStatistic<Charisma>(8));
        }

        public ICoreStatistic GetStat<T>() where T : ICoreStatistic
        {
            return statsCollection.FirstOrDefault(x => x is T);
        }

        public void ModifyStat<T>(int value) where T : ICoreStatistic
        {
            statsCollection.Remove(statsCollection.FirstOrDefault(x => x is T));
            statsCollection.Add(factory.GenerateCoreStatistic<T>(value));
        }
    }
}