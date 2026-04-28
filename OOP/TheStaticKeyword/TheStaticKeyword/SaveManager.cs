namespace TheStaticKeyword
{
    public class SaveManager
    {
        public static SaveManager Instance;

        static SaveManager()
        {
            Console.WriteLine("A new save manager instance was created");

            //Singleton Pattern
            if (Instance == null)
            {
                Instance = new SaveManager();
                //DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                //Destroy(gameObject);
            }
        }

        public void SaveGame()
        {
            Console.WriteLine("Game has been saved");
        }
    }
}
