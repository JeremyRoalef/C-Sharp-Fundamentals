namespace Inheritance
{
    public class Slime : Enemy
    {
        public Slime(int maxHealth) : base(maxHealth)
        {
            Console.WriteLine("New enemy of type slime has been created");
        }

        public override string GetEnemyType()
        {
            return "Slime";
        }

        public void Jump()
        {
            Console.WriteLine("The slime has jumped");
            Health -= 10;
            Console.WriteLine("Jumping has cost the slime 10 health");
            TakeDamage(10);
        }
    }
}
