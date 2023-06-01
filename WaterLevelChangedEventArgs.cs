namespace WaterLevelMonitor
{
    public class WaterLevelChangedEventArgs : EventArgs
    {
        public int NewWaterLevel { get; }

        public WaterLevelChangedEventArgs(int newWaterLevel)
        {
            NewWaterLevel = newWaterLevel;
        }
    }
}