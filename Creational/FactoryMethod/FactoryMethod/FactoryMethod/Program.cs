using FactoryMethod;

Product product;
Creator creator = new ConcreteCreator();

product = creator.CreateProduct();
