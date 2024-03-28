namespace Decorator_Namespace
{
    public class Propeller:Decorator
    {
        public void AddedBehavior()
        {
            Console.WriteLine("Propeller allows Carlson to fly");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}
