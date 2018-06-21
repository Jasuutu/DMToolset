namespace DMToolset.Character.CoreStats
{
    public class CoreStatistic
    {
        internal readonly int _score;

        public CoreStatistic(int score)
        {
            this._score = score;
        }

        public int GetUnmodifedModifier()
        {
            return CalculateModifier();
        }

        internal int CalculateNewScore(int modifierAmount)
        {
            return _score + modifierAmount;
        }

        private int CalculateModifier()
        {
            return _score / 2;
        }
    }
}