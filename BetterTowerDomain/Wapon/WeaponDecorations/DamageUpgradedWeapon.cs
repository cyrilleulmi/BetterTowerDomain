namespace BetterTowerDomain.Wapon.WeaponDecorations
{
    public class DamageUpgradedWeapon : UpgradedWeapon
    {
        private readonly double damageBoost;

        public DamageUpgradedWeapon(IWeapon weaponToSet, double damageBoost)
            : base(weaponToSet)
        {
            this.damageBoost = damageBoost;
        }

        public override double Damage
        {
            get
            {
                return base.Damage + this.damageBoost;
            }
        }
    }
}