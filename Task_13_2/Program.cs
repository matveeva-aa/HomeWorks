using System;

namespace Task_13_2
{
    public delegate void DeviceStateChangedHandler(string deviceType, string newState, DateTime timestamp);

    class Program
    {
        static void Main(string[] args)
        {
            var home = new SmartHomeSystem();

            home.DeviceStateChanged += (device, state, time) =>
            {
                Console.WriteLine($"[{time:HH:mm:ss}] {device}: {state}");
            };

            home.TurnOnLight();
            home.SetTemperature(23);
            home.LockDoor();
            home.TurnOffLight();
            home.UnlockDoor();
            home.SetTemperature(19);

            Console.ReadKey();
        }
    }
}
