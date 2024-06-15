namespace AnimalSounds
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Some generic sound");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Meow");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Bark");
        }
    }
}
