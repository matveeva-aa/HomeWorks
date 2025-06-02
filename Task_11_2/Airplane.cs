namespace Task_11_2
{
    class Airplane : IFlyable
    {
        public int MaxAltitude { get; }
        public int CountPassengers { get; }

        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }
}
