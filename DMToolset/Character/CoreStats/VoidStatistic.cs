using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class VoidStatistic: ICoreStatistic
    {
        public VoidStatistic()
        {
        }

        public int GetUnmodifedModifier()
        {
            return 0;
        }

        public ICoreStatistic ModifyCoreStatistic(ICoreStatistic stat, int modifierAmount)
        {
            return new VoidStatistic();
        }
    }
}