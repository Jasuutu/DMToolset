﻿namespace DMToolset.Character.CoreStats
{
    public class CoreStatistic
    {
        private readonly int _score;

        protected CoreStatistic(int score)
        {
            this._score = score;
        }

        public int GetModifier()
        {
            return CalculateModifier();
        }

        internal int CalculateNewScore(int modifierAmount)
        {
            return _score + modifierAmount;
        }

        private int CalculateModifier()
        {
            return _score / 2 - 5;
        }
    }
}