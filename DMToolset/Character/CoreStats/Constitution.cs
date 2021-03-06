﻿using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class Constitution: CoreStatistic, ICoreStatistic
    {
        public Constitution(int score) : base(score)
        {
        }

        public ICoreStatistic ModifyCoreStatistic(int modifierAmount)
        {
            return new Constitution(CalculateNewScore(modifierAmount));

        }
    }
}