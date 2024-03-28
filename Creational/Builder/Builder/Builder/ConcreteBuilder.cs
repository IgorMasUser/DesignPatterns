using Builder.Product;

namespace Builder
{
    public class ConcreteBuilder : AbstractBuilder
    {
        House house = new House();

        public override void BuildBasement()
        {
            house.Add(new Basement());
        }

        public override void BuildDoor()
        {
            Console.WriteLine("Door is built");
            house.Add(new Door());
        }

        public override void BuildRoof()
        {
            Console.WriteLine("Roof is built");
            house.Add(new Roof());
        }

        public override void BuildStorey()
        {
            Console.WriteLine("Storey is built");
            house.Add(new Storey());
        }

        public override House GetResult()
        {
            Console.WriteLine("House is built");
            return house;
        }
    }
}
