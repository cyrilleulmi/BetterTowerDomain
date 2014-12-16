namespace BetterTowerDomain.Factories.WeaponFactories
{
    using BetterTowerDomain.Wapon;

    public abstract class WeaponFactory
    {
        public abstract IWeapon GenerateWeapon();

        public abstract IWeapon GenerateRangeUpgradedWeaponFrom(IWeapon weapon);

        public abstract IWeapon GenerateDamageUpgradedWeaponFrom(IWeapon weapon);
    }
}