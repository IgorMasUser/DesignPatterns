using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public class RefinedAbstraction: Abstraction
    {
        public RefinedAbstraction(Implementor implementor)
             : base(implementor)
        {
        }

        public override void Operation()
        {
            base.Operation();
        }
    }
}
