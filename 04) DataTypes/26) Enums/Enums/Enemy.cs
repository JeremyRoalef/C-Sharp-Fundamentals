using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Enemy
    {
        //Define the enemy intent enum
        public enum Intent
        {
            Attack, //array index 0
            Heal, //array index 1
            ApplyDebuffToPlayer, //array index 2
            ApplyBuffToSelf //array index 3
        }

        public Intent[] EnemyIntent { get; private set; }

        public Enemy(Intent[] defaultIntent)
        {
            EnemyIntent = defaultIntent;
        }

        public void DoAction()
        {
            //Loop through all of the enemy's current intentions and perform the intention
            foreach (Intent currentIntent in EnemyIntent)
            {
                //Switch-case on an enum's value
                switch (currentIntent)
                {
                    case Intent.Attack:
                        Console.WriteLine("The enemy attacks the player");
                        break;
                    case Intent.Heal:
                        Console.WriteLine("The enemy heals");
                        break;
                    case Intent.ApplyDebuffToPlayer:
                        Console.WriteLine("The enemy applies a debuff to the player");
                        break;
                    case Intent.ApplyBuffToSelf:
                        Console.WriteLine("The enemy applies a buff to itself");
                        break;
                }
            }

            StartNewIntent();
        }

        void StartNewIntent()
        {
            //Randomize the number of intentions for the enemy's next action
            int numOfIntents = Random.Shared.Next(1, 3);

            //Create an array of all enemy intentions for the next action
            Intent[] newIntent = new Intent[numOfIntents];

            //Randomly select an intention, and store it in the enemy's intention array
            for (int i = 0; i < numOfIntents; i++)
            {
                int randomNum = Random.Shared.Next(0, 4);
                Intent currentIntent = Enum.GetValues<Intent>()[randomNum];

                //Add a new intent to the array of enemy intentions
                newIntent[i] = currentIntent;
            }
            
            //Set the enemy's intention array to the new array of intentions
            EnemyIntent = newIntent;
        }
    }
}
