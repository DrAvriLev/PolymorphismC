namespace PolymorphismC
{
    public class BMW : Car
    {
        public string Model { get; set; }

        public BMW(int hp, string color, string model) :
            base(hp, color)
        {
            Model = model;
        }
    }
}
