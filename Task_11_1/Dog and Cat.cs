
namespace Task_11_1
{
    class Dog : Animal
    {
        public override string Name => "Собака";

        public override string Say()
        {
            return "Гав!";
        }
    }

    class Cat : Animal
    {
        public override string Name => "Кошка";

        public override string Say()
        {
            return "Мяу!";
        }
    }
}
