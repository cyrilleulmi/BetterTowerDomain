namespace BetterTowerDomain.Wapon
{
    public class Weapon : IWeapon
    {
        public Weapon(double damage, double range)
        {
            this.Damage = damage;
            this.Range = range;
        }

        public double Damage { get; private set; }

        public double Range { get; private set; }

        public int Level
        {
            get
            {
                return 1;
            }
        }
    }
}