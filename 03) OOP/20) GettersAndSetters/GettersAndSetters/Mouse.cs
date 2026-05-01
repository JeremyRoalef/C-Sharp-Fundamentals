namespace GettersAndSetters
{
    public class Mouse
    {
        int numOfButtons;
        int numOfDPISettings;
        bool isWired;
        bool isErgonomic;

        //Initialize Mouse attributes
        public Mouse(
            int numOfButtons, 
            int numOfDPISettings, 
            bool isWired, 
            bool isErgonomic)
        {
            this.numOfButtons = numOfButtons;
            this.numOfDPISettings = numOfDPISettings;
            this.isWired = isWired;
            this.isErgonomic = isErgonomic;
        }

        //Create the getter methods
        public int GetNumOfButtons() => numOfButtons;
        public int GetnumOfDPISettings() => numOfDPISettings;
        public bool GetIsWired() => isWired;
        public bool GetIsErgonomic() => isErgonomic;

        //Create the setter methods
        public void SetNumOfButtons( int numOfButtons) 
            => this.numOfButtons = numOfButtons;

        public void SetNumOfDPISettings(int numOfDPISettings) 
            => this.numOfDPISettings = numOfDPISettings;

        public void SetIsWired(bool isWired) 
            => this.isWired = isWired;

        public void SetIsErgonomic(bool isErgonomic)
            => this.isErgonomic = isErgonomic;
    }
}
