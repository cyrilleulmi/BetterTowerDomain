namespace BetterTowerDomain.Test.Factories.WeaponFactories
{
    using BetterTowerDomain.Factories.WeaponFactories;
    using BetterTowerDomain.Wapon;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HardDifficultyWeaponFactoryTests
    {
        private HardDifficultyWeaponFactory testee;

        [TestInitialize]
        public void TestInitialize()
        {
            this.testee = new HardDifficultyWeaponFactory();
        }

        [TestMethod]
        public void GenerateWeaponTest()
        {
            // Act
            IWeapon weapon = this.testee.GenerateWeapon();


            // Assert
            weapon.Level.Should().Be(1);
            weapon.Damage.Should().Be(8);
            weapon.Range.Should().Be(8);
        }

        [TestMethod]
        public void GenerateRangeUpgradedWeaponFromTest()
        {
            // Act
            IWeapon weapon = this.testee.GenerateWeapon();
            IWeapon upgradedWeapon = this.testee.GenerateRangeUpgradedWeaponFrom(weapon);

            // Assert
            upgradedWeapon.Level.Should().Be(2);
            upgradedWeapon.Damage.Should().Be(8);
            upgradedWeapon.Range.Should().Be(12);
        }

        [TestMethod]
        public void GenerateDamageUpgradedWeaponFromTest()
        {
            // Act
            IWeapon weapon = this.testee.GenerateWeapon();
            IWeapon upgradedWeapon = this.testee.GenerateDamageUpgradedWeaponFrom(weapon);

            // Assert
            upgradedWeapon.Level.Should().Be(2);
            upgradedWeapon.Damage.Should().Be(12);
            upgradedWeapon.Range.Should().Be(8);
        }
    }
}
