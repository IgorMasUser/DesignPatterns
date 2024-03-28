using Bridge.Abstraction;
using Bridge.Implementation;

Implementor implementor = null;
Abstraction abstraction = null;

implementor = new ConcreteImplementor1();
abstraction = new RefinedAbstraction(implementor);
abstraction.Operation();


implementor = new ConcreteImplementor2();
abstraction = new RefinedAbstraction(implementor);
abstraction.Operation();
