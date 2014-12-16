namespace BetterTowerDomain
{
    using System.Collections.Generic;

    using BetterTowerDomain.Factories;
    using BetterTowerDomain.Tower;

    public class Game
    {
        private readonly List<ITower> towers = new List<ITower>();

        private readonly TowerFactory towerFactory;

        public Game(Difficulty difficulty)
        {
            this.towers = new List<ITower>();
            this.towerFactory = new TowerFactory(difficulty);
        }

        public IEnumerable<ITower> Towers
        {
            get { return this.towers; }
        }

        public void UpgradeRangeFromTower(ITower towerToUpgrade)
        {
            towerToUpgrade.UpgradeRange();
        }

        public void UpgradeDamageFromTower(ITower towerToUpgrade)
        {
            towerToUpgrade.UpgradeDamage();
        }

        public void CreateNewTower()
        {
            this.towers.Add(this.towerFactory.GenerateTower());
        }
    }
}
