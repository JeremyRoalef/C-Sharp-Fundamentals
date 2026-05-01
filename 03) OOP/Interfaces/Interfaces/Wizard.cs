namespace Interfaces
{
    public class Wizard : ICanAttackForElemental
    {
        public int ElementalDamage { get; set; }
        public int Damage { get; set; }

        public void Attack(int damage)
        {
            Console.WriteLine($"The wizard attacks for {damage} damage");
        }

        public void DoElementalDamage(int damage)
        {
            Console.WriteLine($"The wizard deal elemental damage for {damage} elemental damage");
        }

        public Wizard(int damage, int elementalDamage)
        {
            this.Damage = damage;
            this.ElementalDamage = elementalDamage;
        }
    }
}
