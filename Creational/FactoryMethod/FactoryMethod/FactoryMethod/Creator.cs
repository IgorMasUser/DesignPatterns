namespace FactoryMethod
{
    public abstract class Creator
    {
        Product product;

        public abstract Product CreateProduct();
    }
}
