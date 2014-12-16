namespace BetterTowerDomain.Wapon.WeaponDecorations
{
    public class UpgradedWeapon : IWeapon
    {
        private readonly IWeapon weapon;

        public UpgradedWeapon(IWeapon weaponToSet)
        {
            this.weapon = weaponToSet;
        }

        public virtual double Damage
        {
            get
            {
                return this.weapon.Damage;
            }
        }

        public virtual double Range
        {
            get
            {
                return this.weapon.Range;
            }
        }

        public int Level
        {
            get
            {
                return this.weapon.Level + 1;
            }
        }
    }
}