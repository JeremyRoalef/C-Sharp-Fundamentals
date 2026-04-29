using Interfaces;

public class Program
{
    static void Main(string[] args)
    {
        Knight knight = new Knight(25);
        knight.Attack(knight.Damage);

        Console.WriteLine("------------------------------------");

        Slime slime = new Slime();
        slime.Attack(slime.Damage);
        slime.Jump();

        Console.WriteLine("------------------------------------");
        ICanAttack iCanAttack = knight;
        iCanAttack.Attack(iCanAttack.Damage);

        Console.WriteLine("------------------------------------");
        iCanAttack = slime;
        iCanAttack.Attack(iCanAttack.Damage);

        Console.WriteLine("------------------------------------");
        if (slime is ICanAttack iAttackable)
        {
            iAttackable.Attack(iAttackable.Damage);
        }

        Console.WriteLine("------------------------------------");
        Wizard wizard = new Wizard(10, 75);
        wizard.Attack(wizard.Damage);
        wizard.DoElementalDamage(wizard.ElementalDamage);

        Console.WriteLine("------------------------------------");
        iCanAttack = wizard;
        iCanAttack.Attack(iCanAttack.Damage);
        if (iCanAttack is ICanAttackForElemental iCanAttackForElemental)
        {
            iCanAttackForElemental.DoElementalDamage(iCanAttackForElemental.ElementalDamage);
        }
    }
}