namespace Interfaces
{
    public class Knight : ICanAttack
    {
        public int Damage { get; set; }

        public void Attack(int damage)
        {
            Console.WriteLine($"The knight attacks for {damage} damage");
            Shout();
        }

        void Shout()
        {
            Console.WriteLine("The knight shouts");
        }

        public Knight(int damage)
        {
            this.Damage = damage;
        }
    }
}
