namespace AF.Abstraction
{
    public abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractWater CreateWater();
        public abstract AbstractCap CreateCap();
    }
}
