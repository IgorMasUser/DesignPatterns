using AF.Abstraction;

namespace AF.Impl.CocaCola
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCap CreateCap()
        {
            return new CocaColaCap();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
