namespace BetterTowerDomain
{
    public interface ITower
    {
        string Description { get; }
        double Range { get; set; }
        double Damage { get; set; }
    }
}