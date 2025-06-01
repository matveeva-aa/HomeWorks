using System;

namespace Task_10_1
{
    class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;

        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }

        public virtual double CalculateTax()
        {
            return _area * 1000;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Адрес: {_address}");
            Console.WriteLine($"Площадь: {_area} кв.м.");
            Console.WriteLine($"Год постройки: {_yearBuilt}");
            Console.WriteLine($"Возраст здания: {BuildingAge} лет");
        }

        public int BuildingAge
        {
            get { return DateTime.Now.Year - _yearBuilt; }
        }
    }
}
