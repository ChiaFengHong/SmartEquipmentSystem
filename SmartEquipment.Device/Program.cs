using SmartEquipment.Application.Shared;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("🔥 Device Simulator Started");

        var random = new Random();

        while (true)
        {
            foreach (var device in DeviceState.Devices)
            {
                device.IsRunning = true; // 🔥 強制
                if (device.IsRunning)
                {
                    device.Temperature = random.Next(30, 100);
                    device.LastUpdated = DateTime.Now;
                }
            }

            Console.WriteLine($"Temp: {DeviceState.Devices[0].Temperature}");

            Thread.Sleep(1000);
        }
    }
}