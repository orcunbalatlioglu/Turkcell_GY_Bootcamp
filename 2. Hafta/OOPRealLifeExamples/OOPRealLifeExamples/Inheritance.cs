namespace OOPRealLifeExamples
{
    public class Animal
    {
        public string Species { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }

        public void Eat()
        {
            Console.WriteLine("Animal ate its food.");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal slept.");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat meowed.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barked.");
        }
    }

}
