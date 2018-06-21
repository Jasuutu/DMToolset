using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class Stength: CoreStatistic, ICoreStatistic
    {
        public Stength(int score)
            : base(score)
        {
        }

        public ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount)
        {
            return new Stength(CalculateNewScore(modifierAmount));
        }
    }
}