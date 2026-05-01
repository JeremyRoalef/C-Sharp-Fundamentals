namespace Inheritance
{
    public class Knight : Enemy
    {
        public int armorRating = 10;

        public Knight(int maxHealth) : base(maxHealth)
        {
            Console.WriteLine("New enemy of type knight has been created");
        }

        public override string GetEnemyType()
        {
            return "Knight";
        }

        public override void TakeDamage(int amount)
        {
            int damageToTake = amount - armorRating;
            if (damageToTake <= 0) return;

            Console.WriteLine("Knight is taking less damage due to its armor rating");
            base.TakeDamage(damageToTake);
        }
    }
}
