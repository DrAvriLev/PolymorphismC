using System;

namespace PolymorphismC
{
    public class Car
    {
        //private int hp;
        //private string color;

        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The car's HP is {HP} and it's color is {Color}. ");
        }

        public void Repair()
        {
            Console.WriteLine("Car is repaired.");
        }
    }
}
