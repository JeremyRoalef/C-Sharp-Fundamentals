namespace Interfaces
{
    public class Slime : IJump, ICanAttack
    {
        public int Damage { get; set; }

        public void Attack(int damage)
        {
            Console.WriteLine($"The slime attacks for {damage} damage");
        }

        public void Jump()
        {
            Console.WriteLine("The slime jumps");
        }
    }
}
