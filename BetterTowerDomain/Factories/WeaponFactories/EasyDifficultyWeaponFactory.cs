namespace BetterTowerDomain.Factories.WeaponFactories
{
    using BetterTowerDomain.Wapon;
    using BetterTowerDomain.Wapon.WeaponDecorations;

    public class EasyDifficultyWeaponFactory : WeaponFactory
    {
        public override IWeapon GenerateWeapon()
        {
            return new Weapon(12, 12);
        }

        public override IWeapon GenerateRangeUpgradedWeaponFrom(IWeapon weapon)
        {
            return new RangeUpgradedWeapon(weapon, 7);
        }

        public override IWeapon GenerateDamageUpgradedWeaponFrom(IWeapon weapon)
        {
            return new DamageUpgradedWeapon(weapon, 7);
        }
    }
}