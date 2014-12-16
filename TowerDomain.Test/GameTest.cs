namespace TowerDomain.Test
{
    using System.Linq;

    using BetterTowerDomain;
    using BetterTowerDomain.Exceptions;
    using BetterTowerDomain.Tower;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Zusammenfassungsbeschreibung für GameTest
    /// </summary>
    [TestClass]
    public class GameTest
    {
        private Game testee;

        [TestInitialize]
        public void TestInitialize()
        {
            this.testee = new Game(Difficulty.Medium);
        }

        [TestMethod]
        public void BuildNewTower()
        {
            // Act
            this.testee.CreateNewTower();

            // Assert
            this.testee.Towers.Count().Should().Be(1);
        }

        [TestMethod]
        public void DescriptionIsCorrect()
        {
            // Act
            this.testee.CreateNewTower();

            // Assert
            CheckDescriptionFromTower(this.testee.Towers.ElementAt(0));
        }

        [TestMethod]
        public void UpgradeTowerRange()
        {
            this.testee.CreateNewTower();
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));

            // Assert
            this.testee.Towers.ElementAt(0).Range.Should().BeGreaterThan(this.testee.Towers.ElementAt(1).Range);
        }

        [TestMethod]
        public void DescriptionIsCorrectWithRangeUpgrade()
        {
            // Arrange
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));

            // Assert
            CheckDescriptionFromTower(this.testee.Towers.ElementAt(0));
        }

        [TestMethod]
        public void UpgradeTowerDamage()
        {
            // Arrange
            this.testee.CreateNewTower();
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));

            // Assert
            this.testee.Towers.ElementAt(0).Damage.Should().BeGreaterThan(this.testee.Towers.ElementAt(1).Range);
        }

        [TestMethod]
        public void DescriptionIsCorrectWithDamageUpgrade()
        {
            // Arrange
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));

            // Assert
            CheckDescriptionFromTower(this.testee.Towers.ElementAt(0));
        }

        [TestMethod]
        public void UpgradeTowerFirstDamageThanRange()
        {
            // Arrange
            this.testee.CreateNewTower();
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));

            // Assert
            this.testee.Towers.ElementAt(0).Damage.Should().BeGreaterThan(this.testee.Towers.ElementAt(1).Range);
            this.testee.Towers.ElementAt(0).Range.Should().BeGreaterThan(this.testee.Towers.ElementAt(1).Range);
        }

        [TestMethod]
        public void UpgradeTowerFirstRangeThanDamage()
        {
            this.testee.CreateNewTower();
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));

            // Assert
            this.testee.Towers.ElementAt(0).Damage.Should().BeGreaterThan(this.testee.Towers.ElementAt(1).Damage);
            this.testee.Towers.ElementAt(0).Range.Should().BeGreaterThan(this.testee.Towers.ElementAt(1).Range);
        }

        [TestMethod]
        public void UpgradingATowerFourTimesWorks()
        {
            // Arrange
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));

            // Assertion: passes if no exception is thrown
        }

        [ExpectedException(typeof(ToManyUpgradesException))]
        [TestMethod]
        public void UpgradeTowerFourTimesWithDamage_ThrowsException()
        {
            // Arrange
            this.testee.CreateNewTower();

            // Act
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeRangeFromTower(this.testee.Towers.ElementAt(0));
            this.testee.UpgradeDamageFromTower(this.testee.Towers.ElementAt(0));

            // Assertion is in the Tag
        }

        private static void CheckDescriptionFromTower(ITower tower)
        {
            tower.Description.Should()
                .Be(string.Format("This tower deals {0} damage and has a range of {1}", tower.Damage, tower.Range));
        }
    }
}
