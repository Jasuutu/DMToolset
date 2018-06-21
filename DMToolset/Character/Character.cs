using System.Runtime.InteropServices;

namespace DMToolset.Character
{
    public class Character
    {
        public PlayerStatistics Stats { get; }

        public Character(PlayerStatistics playerStatistics)
        {
            this.Stats = playerStatistics;
        }

        public int GetInitiative()
        {
            
        }
    }
}
