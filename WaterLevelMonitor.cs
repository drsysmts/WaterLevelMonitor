namespace WaterLevelMonitor
{
    public class WaterLevelMonitor
    {
        public event EventHandler<WaterLevelChangedEventArgs> WaterLevelChanged;

        private int currentWaterLevel;

        public int CurrentWaterLevel
        {
            get { return currentWaterLevel; }
            set
            {
                if (value != currentWaterLevel)
                {
                    currentWaterLevel = value;
                    OnWaterLevelChanged(new WaterLevelChangedEventArgs(value));
                }
            }
        }

        protected virtual void OnWaterLevelChanged(WaterLevelChangedEventArgs e)
        {
            WaterLevelChanged?.Invoke(this, e);
        }
    }
}