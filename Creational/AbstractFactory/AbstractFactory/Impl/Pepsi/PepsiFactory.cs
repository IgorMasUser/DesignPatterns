using AF.Impl.Pepsi;
using AF.Abstraction;

namespace AF.Impl.Pepsi
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCap CreateCap()
        {
            return new PepsiCap();
        }

        public override AbstractWater CreateWater()
        {
           return new PepsiWater();
        }
    }
}
