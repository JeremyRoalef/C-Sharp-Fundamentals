namespace OverridingToString
{
    public class Computer
    {
        string displayRatio;
        string keyboardLayout;
        string model;

        //Initialize the computer's attributes
        public Computer(
            string displayRatio, 
            string keyboardLayout, 
            string model)
        {
            this.displayRatio = displayRatio;
            this.keyboardLayout = keyboardLayout;
            this.model = model;
        }

        public override string ToString()
        {
            return $"Display Ratio: {displayRatio}\n" +
                $"Keyboard Layout: {keyboardLayout}\n" +
                $"Model: {model}";
        }
    }
}
