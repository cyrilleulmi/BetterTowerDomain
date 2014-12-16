namespace BetterTowerDomain.Wapon.WeaponDecorations
{
    public class RangeUpgradedWeapon : UpgradedWeapon
    {
        private readonly double rangeBoost;

        public RangeUpgradedWeapon(IWeapon weaponToSet, double rangeBoost)
            : base(weaponToSet)
        {
            this.rangeBoost = rangeBoost;
        }

        public override double Range
        {
            get
            {
                return base.Range + this.rangeBoost;
            }
        }
    }
}