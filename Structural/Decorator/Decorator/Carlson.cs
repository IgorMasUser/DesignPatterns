namespace Decorator_Namespace
{
    public class Carlson : Component
    {
        string state = "calm";

        public override void Operation()
        {
            Console.WriteLine($"Carloson does {state} life");
        }
    }
}
