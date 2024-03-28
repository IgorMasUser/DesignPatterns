using Builder.Product;

namespace Builder.Foremen
{
    public class Foremen
    {
        AbstractBuilder builder;

        public Foremen(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
            builder.BuildDoor();
        }
    }
}
