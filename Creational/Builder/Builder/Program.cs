using Builder;
using Builder.Foremen;
using Builder.Product;

AbstractBuilder builder = new ConcreteBuilder();

Foremen foremen = new Foremen(builder);
foremen.Construct();

House house = builder.GetResult();