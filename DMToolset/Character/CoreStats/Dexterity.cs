using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class Dexterity: CoreStatistic, ICoreStatistic
    {
        public Dexterity(int score) : base(score)
        {
        }

        public ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount)
        {
            return new Dexterity(CalculateNewScore(modifierAmount));
        }
    }
}