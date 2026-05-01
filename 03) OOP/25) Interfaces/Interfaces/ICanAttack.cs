namespace Interfaces
{
    public interface ICanAttack
    {
        public int Damage { get; set; }

        public void Attack(int damage);
    }
}
