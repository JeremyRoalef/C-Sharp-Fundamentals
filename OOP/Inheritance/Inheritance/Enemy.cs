namespace Inheritance
{
    public abstract class Enemy
    {
        public int MaxHealth { get; protected set; }
        public int Health {  get; protected set; }

        public Enemy(int maxHealth)
        {
            Console.WriteLine("New enemy has been created");

            this.MaxHealth = maxHealth;
            Health = MaxHealth;
        }

        public virtual void TakeDamage(int amount)
        {
            Health = Math.Clamp(Health - amount, 0, MaxHealth);
        }

        public virtual void RestoreHealth(int amount)
        {
            Health = Math.Clamp(Health + amount, 0, MaxHealth);
        }
        public abstract string GetEnemyType();
    }
}
