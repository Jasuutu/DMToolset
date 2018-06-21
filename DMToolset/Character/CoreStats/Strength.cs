using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class Strength: CoreStatistic, ICoreStatistic
    {
        public Strength(int score)
            : base(score)
        {
        }

        public ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount)
        {
            return new Strength(CalculateNewScore(modifierAmount));
        }
    }
}