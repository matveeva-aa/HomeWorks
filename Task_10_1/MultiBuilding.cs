using System;

namespace Task_10_1
{
    sealed class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }

        public override double CalculateTax()
        {
            double floorCoefficient = 1 + (_floors - 1) * 0.05;
            double elevatorFee = _hasElevator ? 5000 : 0;
            return (_area * 1000 * floorCoefficient) + elevatorFee;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Этажей: {_floors}");
            Console.WriteLine($"Лифт: {(_hasElevator ? "Есть" : "Нет")}");
            Console.WriteLine($"Средняя площадь на этаж: {AreaPerFloor} кв.м.");
        }

        public double AreaPerFloor
        {
            get { return _area / _floors; }
        }
    }
}
