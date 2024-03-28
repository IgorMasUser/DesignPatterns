using Builder.Product;

namespace Builder
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract void BuildDoor();
        public abstract House GetResult();
    }
}
