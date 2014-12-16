namespace BetterTowerDomain
{
    public class Tower : ITower
    {
        public string Description
        {
            get { return "This tower deals 10 damage and has a range of 10"; }
        }

        public double Range { get; set; }
        public double Damage { get; set; }
    }
}