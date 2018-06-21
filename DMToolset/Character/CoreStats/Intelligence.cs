using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class Intelligence: CoreStatistic, ICoreStatistic
    {
        public Intelligence(int score) : base(score)
        {
        }

        public ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount)
        {
            return new Intelligence(CalculateNewScore(modifierAmount));
        }
    }
}