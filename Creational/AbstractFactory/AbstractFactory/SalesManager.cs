using AF.Abstraction;

namespace AF.Manager
{
    public class SalesManager
    {
        AbstractWater water;
        AbstractBottle bottle;
        AbstractCap cap;

        public SalesManager(AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cap = factory.CreateCap();
        }

        public void RunProduction()
        {
            bottle.InteractWithWater(water);
            bottle.InteractWithCap(cap);
        }
    }
}
