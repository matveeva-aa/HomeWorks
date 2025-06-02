namespace Task_11_2
{
    class Bird : IFlyable
    {
        public int MaxAltitude { get; }

        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }

        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }
}
