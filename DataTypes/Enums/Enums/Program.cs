using Enums;
using static Enums.Enemy;

public class Program
{
    //Define the CharacterState enum
    public enum CharacterState
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G
    }

    static void Main(string[] args)
    {
        //Craete a new variable of the character state enum
        CharacterState characterState = CharacterState.A;
        Console.WriteLine($"My current character state is {characterState.ToString()}");

        //Change the value of the stored enum character
        characterState = CharacterState.E;
        Console.WriteLine($"My new character state is {characterState.ToString()}");

        Console.WriteLine("-----------------------------------------------------------");

        switch (characterState)
        {
            case CharacterState.A:
                Console.WriteLine("A was selected as the current character state");
                break;
            case CharacterState.B:
                Console.WriteLine("B was selected as the current character state");
                break;
            case CharacterState.C:
                Console.WriteLine("C was selected as the current character state");
                break;
            case CharacterState.D:
                Console.WriteLine("D was selected as the current character state");
                break;
            case CharacterState.E:
                Console.WriteLine("E was selected as the current character state");
                break;
        }

        Console.WriteLine("-----------------------------------------------------------");
        //Randomize the starting intentions of the enemy (see enemy class)
        int numOfIntents = Random.Shared.Next(1, 3);
        Intent[] newIntent = new Intent[numOfIntents];
        for (int i = 0; i < numOfIntents; i++)
        {
            int randomNum = Random.Shared.Next(0, 4);
            Intent currentIntent = Enum.GetValues<Intent>()[randomNum];

            //Add a new intent to the array of enemy intentions
            newIntent[i] = currentIntent;
        }

        //Create the new enemy, & have it do some actions
        Enemy enemy = new Enemy(newIntent);
        enemy.DoAction();
        Console.WriteLine("-----------------------------------------------------------");
        enemy.DoAction();
        Console.WriteLine("-----------------------------------------------------------");
        enemy.DoAction();
        Console.WriteLine("-----------------------------------------------------------");
        enemy.DoAction();
    }
}