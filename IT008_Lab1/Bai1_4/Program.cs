public class Thermometer
{
    public delegate void TemperatureChangedHandler(int temperature);

    public event TemperatureChangedHandler TemperatureChanged;

    private int temperature;

    public Thermometer(int temperature)
    {
        this.temperature = temperature;
    }

    public int Temperature
    {
        get { return temperature; }
    }

    public void SetTemperature(int temperature)
    {
        this.temperature = temperature;
        OnTemperatureChanged();
    }

    protected void OnTemperatureChanged()
    {
        if (TemperatureChanged != null)
        {
            TemperatureChanged(Temperature);
        }
    }
}

public class Screen
{
    public void DisplayTemperature(int temperature)
    {
        Console.WriteLine("The temperature is {0} degrees Celsius.", temperature);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Thermometer thermometer = new Thermometer(25);
        Screen screen = new Screen();

        thermometer.TemperatureChanged += screen.DisplayTemperature;

        Random random = new Random();
        int random_num = random.Next(101);
        thermometer.SetTemperature(random_num);

        random_num = random.Next(101);
        thermometer.SetTemperature(random_num);

        random_num = random.Next(101);
        thermometer.SetTemperature(random_num);

        Console.ReadLine();
    }
}