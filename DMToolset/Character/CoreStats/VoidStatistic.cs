using DMToolset.Character.CoreStats.Interfaces;

namespace DMToolset.Character.CoreStats
{
    public class VoidStatistic: ICoreStatistic
    {
        public VoidStatistic(int statisticValue)
        {

        }

        public int GetModifier()
        {
            return 0;
        }

        public ICoreStatistic ModifyCoreStatistic(int modifierAmount)
        {
            return new VoidStatistic(0);
        }
    }
}