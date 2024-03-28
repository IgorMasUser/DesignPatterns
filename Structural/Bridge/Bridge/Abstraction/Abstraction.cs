using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public abstract class Abstraction
    {
        Implementor implementor = null;

        public Abstraction(Implementor impl)
        {
            implementor = impl;
        }

        public virtual void Operation()
        {
            implementor.OperationImpl();
        }
    }
}
