using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class Charisma: CoreStatistic, ICoreStatistic
    {
        public Charisma(int score) : base(score)
        {
        }

        public ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount)
        {
            return new Charisma(CalculateNewScore(modifierAmount));
        }
    }
}