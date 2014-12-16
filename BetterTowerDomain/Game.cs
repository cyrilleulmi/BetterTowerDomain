using System;
using System.Collections.Generic;

namespace BetterTowerDomain
{
    public class Game
    {
        private readonly List<ITower> towers = new List<ITower>();

        public Game()
        {
            this.towers = new List<ITower>();
        }

        public IEnumerable<ITower> Towers
        {
            get { return towers; }
        }

        public void UpgradeRangeFromTower(ITower towerToUpgrade)
        {
        }

        public void UpgradePowerFromTower(Tower towerToUpgrade)
        {
        }

        public void CreateNewTower(ITower tower)
        {
            this.towers.Add(new Tower());
        }


        public void UpgradeDamageFromTower(ITower towerToUpgrade)
        {
        }
    }
}
