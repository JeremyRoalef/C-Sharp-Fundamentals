namespace Interfaces
{
    public interface ICanAttackForElemental : ICanAttack
    {
        public int ElementalDamage { get; set; }
        public void DoElementalDamage(int damage);
    }
}
