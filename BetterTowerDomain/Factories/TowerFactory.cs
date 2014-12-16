namespace BetterTowerDomain.Factories
{
    using System;

    using BetterTowerDomain.Factories.WeaponFactories;
    using BetterTowerDomain.Tower;

    public class TowerFactory
    {
        private readonly WeaponFactory weaponFactory;

        public TowerFactory(Difficulty difficulty)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    this.weaponFactory = new EasyDifficultyWeaponFactory();
                    break;
                case Difficulty.Medium:
                    this.weaponFactory = new MediumDifficultyWeaponFactory();
                    break;
                case Difficulty.Hard:
                    this.weaponFactory = new HardDifficultyWeaponFactory();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("difficulty");
            }
        }

        public ITower GenerateTower()
        {
            return new Tower(this.weaponFactory);
        }
    }
}