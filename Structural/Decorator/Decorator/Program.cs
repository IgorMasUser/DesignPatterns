using Decorator_Namespace;

Component carlson = new Carlson();
Decorator decoratorA = new Clothe();
Decorator decoratorB = new Propeller();

decoratorA.Component = carlson;
decoratorB.Component = decoratorA;

decoratorB.Operation();

