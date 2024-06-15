namespace AnimalSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.MakeSound();
            myDog.MakeSound();   
            myCat.MakeSound(); 
        }
    }
}
