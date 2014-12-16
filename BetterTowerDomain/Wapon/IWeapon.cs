namespace BetterTowerDomain.Wapon
{
    public interface IWeapon
    {
        double Damage { get; }

        double Range { get; }

        int Level { get; }
    }
}