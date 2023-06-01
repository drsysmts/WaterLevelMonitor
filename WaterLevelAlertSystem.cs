namespace WaterLevelMonitor
{
    public class WaterLevelAlertSystem
    {
        public WaterLevelAlertSystem(WaterLevelMonitor waterLevelMonitor)
        {
            waterLevelMonitor.WaterLevelChanged += HandleWaterLevelChanged;
        }

        private void HandleWaterLevelChanged(object sender, WaterLevelChangedEventArgs e)
        {
            if (e.NewWaterLevel < 10)
            {
               
                Console.WriteLine($"ALERT: Water level is critically low!  volume is {e.NewWaterLevel}");
                // Perform additional actions like sending notifications or triggering pumps.
            }
            else if (e.NewWaterLevel > 100)
            {
                
                
                Console.WriteLine($"ALERT: Water level is too high! volume is {e.NewWaterLevel}");
                // Perform additional actions like sending notifications or shutting off valves.
            } else 
            Console.WriteLine($" normal: Water level is accepte volume is {e.NewWaterLevel}");


        }
    }
}