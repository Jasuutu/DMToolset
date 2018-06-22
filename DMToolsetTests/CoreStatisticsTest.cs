using DMToolset.Character.CoreStats;
using DMToolset.Character.CoreStats.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DMToolsetTests
{
    
    [TestFixture]
    public class CoreStatisticsTest
    {
        private ICoreStatisticFactory coreStatisticFactory;

        [SetUp]
        public void TestSetup()
        {
            coreStatisticFactory = new CoreStatisitcFactory();
        }

        [Test]
        public void GenerateCoreStatisticTest()
        {
            ICoreStatistic strengeth = coreStatisticFactory.GenerateCoreStatistic<Strength>(8);

            strengeth.GetModifier().Should().Be(-1, "because this is a base value");
        }

        [Test]
        public void ModifyCoreStatisticTest()
        {
            ICoreStatistic dexterity = coreStatisticFactory.GenerateCoreStatistic<Dexterity>(8);
            ICoreStatistic newDexterity = dexterity.ModifyCoreStatistic(2);

            newDexterity.GetModifier().Should().Be(0, "because the modifiec stat was increased by 2");
        }

        [Test]
        public void CheckVoidStatistic()
        {
            coreStatisticFactory.GenerateCoreStatistic<VoidStatistic>(10).Should()
                .NotBeNull("because we don't want to have a null value type");
        }

        [Test]
        public void CheckVoidStatisticReturn()
        {
            coreStatisticFactory.GenerateCoreStatistic<VoidStatistic>(10).GetModifier().Should()
                .Be(0, "because the only valid return for the null type should be 0");
        }
    }
}
