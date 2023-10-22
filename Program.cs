using System;

namespace ReptileZooManagement
{
    public class Reptile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public bool IsVenomous { get; set; }

        public Reptile()
        {
            Name = "Unknown";
            Age = 0;
            Species = "Unknown";
            Habitat = "Unknown";
            IsVenomous = false;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Generic reptile sound");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    public class Snake : Reptile
    {
        public bool IsConstrictor { get; set; }

        public Snake() : base()
        {
            Species = "Snake";
            IsConstrictor = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hiss!");
        }

        public void Slither()
        {
            Console.WriteLine("Slithering...");
        }
    }

    public class Lizard : Reptile
    {
        public bool CanRegrowTail { get; set; }

        public Lizard() : base()
        {
            Species = "Lizard";
            CanRegrowTail = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chirp!");
        }

        public void Climb()
        {
            Console.WriteLine("Climbing...");
        }
    }

    public class Crocodile : Reptile
    {
        public int ToothCount { get; set; }

        public Crocodile() : base()
        {
            Species = "Crocodile";
            ToothCount = 60;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Growl!");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Snake mySnake = new Snake();
            Lizard myLizard = new Lizard();
            Crocodile myCrocodile = new Crocodile();

            Reptile[] zoo = { mySnake, myLizard, myCrocodile };

            foreach (Reptile reptile in zoo)
            {
                reptile.MakeSound();
            }
        }
    }
}