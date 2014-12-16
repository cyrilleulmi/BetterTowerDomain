namespace BetterTowerDomain.Factories.WeaponFactories
{
    using BetterTowerDomain.Wapon;
    using BetterTowerDomain.Wapon.WeaponDecorations;

    public class MediumDifficultyWeaponFactory : WeaponFactory
    {
        public override IWeapon GenerateWeapon()
        {
            return new Weapon(10, 10);
        }

        public override IWeapon GenerateRangeUpgradedWeaponFrom(IWeapon weapon)
        {
            return new RangeUpgradedWeapon(weapon, 5);
        }

        public override IWeapon GenerateDamageUpgradedWeaponFrom(IWeapon weapon)
        {
            return new DamageUpgradedWeapon(weapon, 5);
        }
    }
}