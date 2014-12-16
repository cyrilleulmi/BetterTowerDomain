namespace BetterTowerDomain.Tower
{
    using BetterTowerDomain.Exceptions;
    using BetterTowerDomain.Factories.WeaponFactories;
    using BetterTowerDomain.Wapon;

    public class Tower : ITower
    {
        private IWeapon weapon;

        private readonly WeaponFactory weaponFactory;

        public Tower(WeaponFactory weaponFactoryToSet)
        {
            this.weaponFactory = weaponFactoryToSet;
            this.weapon = this.weaponFactory.GenerateWeapon();
        }

        public string Description
        {
            get { return string.Format("This tower deals {0} damage and has a range of {1}", this.Damage, this.Range); }
        }

        public int Level
        {
            get
            {
                return this.weapon.Level;
            }
        }

        public double Range
        {
            get
            {
                return this.weapon.Range;
            }
        }

        public double Damage
        {
            get
            {
                return this.weapon.Damage;
            }
        }

        public void UpgradeRange()
        {
            this.ValidateUpgrade();
            this.weapon = this.weaponFactory.GenerateRangeUpgradedWeaponFrom(this.weapon);
        }

        public void UpgradeDamage()
        {
            this.ValidateUpgrade();
            this.weapon = this.weaponFactory.GenerateDamageUpgradedWeaponFrom(this.weapon);
        }

        private void ValidateUpgrade()
        {
            if (this.Level > 4)
            {
                throw new ToManyUpgradesException();
            }
        }
    }
}