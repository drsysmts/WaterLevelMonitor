namespace WaterLevelMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaterLevelMonitor waterLevelMonitor = new WaterLevelMonitor();
            WaterLevelAlertSystem alertSystem = new WaterLevelAlertSystem(waterLevelMonitor);

            // Simulate water level changes

            Random random = new Random();
            int temperature = random.Next(1, 200);
            //waterLevelMonitor.CurrentWaterLevel = 50;
            //waterLevelMonitor.CurrentWaterLevel = 5;
            //waterLevelMonitor.CurrentWaterLevel = 120;
            //waterLevelMonitor.CurrentWaterLevel = 90;
            //waterLevelMonitor.CurrentWaterLevel = 1;
            waterLevelMonitor.CurrentWaterLevel = temperature;
        }
    }
}