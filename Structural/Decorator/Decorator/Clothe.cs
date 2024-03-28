namespace Decorator_Namespace
{
    public class Clothe : Decorator
    {
        string clothe = "Clothe";

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine($"{clothe} is put on Carlson");
        }
    }
}
