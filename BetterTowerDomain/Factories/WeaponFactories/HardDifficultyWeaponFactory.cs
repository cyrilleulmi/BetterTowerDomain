namespace BetterTowerDomain.Factories.WeaponFactories
{
    using BetterTowerDomain.Wapon;
    using BetterTowerDomain.Wapon.WeaponDecorations;

    public class HardDifficultyWeaponFactory : WeaponFactory
    {
        public override IWeapon GenerateWeapon()
        {
            return new Weapon(8, 8);
        }

        public override IWeapon GenerateRangeUpgradedWeaponFrom(IWeapon weapon)
        {
            return new RangeUpgradedWeapon(weapon, 4);
        }

        public override IWeapon GenerateDamageUpgradedWeaponFrom(IWeapon weapon)
        {
            return new DamageUpgradedWeapon(weapon, 4);
        }
    }
}