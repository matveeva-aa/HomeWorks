using Task_13_2;

public class SmartHomeSystem
{
    public event DeviceStateChangedHandler DeviceStateChanged;

    private bool _lightOn = false;
    private int _temperature = 22;
    private bool _doorLocked = false;

    public void TurnOnLight()
    {
        _lightOn = true;
        DeviceStateChanged?.Invoke("Light", "Включен", DateTime.Now);
    }

    public void TurnOffLight()
    {
        _lightOn = false;
        DeviceStateChanged?.Invoke("Light", "Выключен", DateTime.Now);
    }

    public void SetTemperature(int newTemp)
    {
        _temperature = newTemp;
        DeviceStateChanged?.Invoke("Thermostat", $"Температура изменена на {_temperature}°C", DateTime.Now);
    }

    public void LockDoor()
    {
        _doorLocked = true;
        DeviceStateChanged?.Invoke("Door", "Заблокирована", DateTime.Now);
    }

    public void UnlockDoor()
    {
        _doorLocked = false;
        DeviceStateChanged?.Invoke("Door", "Открыта", DateTime.Now);
    }
}