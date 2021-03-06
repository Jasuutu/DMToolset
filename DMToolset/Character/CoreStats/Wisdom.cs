﻿using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class Wisdom: CoreStatistic, ICoreStatistic
    {
        public Wisdom(int score) : base(score)
        {
        }

        public ICoreStatistic ModifyCoreStatistic(int modifierAmount)
        {
            return new Wisdom(CalculateNewScore(modifierAmount));
        }
    }
}