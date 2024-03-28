using Adapter_Adaptee;
using Adapter_Base;

namespace Adapter_Impl
{
    public class Adapter : BaseTarget
    {
        Adaptee adaptee = new Adaptee();

        public override void Do()
        {
            Console.WriteLine("Do interface");
            adaptee.Make();
        }
    }
}
