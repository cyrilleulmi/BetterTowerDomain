namespace BetterTowerDomain.Tower
{
    public interface ITower
    {
        string Description { get; }

        int Level { get; }

        double Range { get; }

        double Damage { get; }

        void UpgradeRange();

        void UpgradeDamage();
    }
}