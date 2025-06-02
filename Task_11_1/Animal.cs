namespace Task_11_1
{
    abstract class Animal
    {
        public abstract string Name { get; }

        public abstract string Say();

        public string ShowInfo()
        {
            return $"{Name}: {Say()}";
        }
    }
}
