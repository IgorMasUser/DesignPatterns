using AF.Abstraction;

namespace AF.Impl.Pepsi
{
    class PepsiBottle : AbstractBottle
    {
        bool IsBottleFiller = false;
        bool IsCapClosed = false;

        public override void InteractWithCap(AbstractCap cap)
        {
            if (IsBottleFiller)
            {
                Console.WriteLine(cap + " was used to close " + this);
                IsCapClosed = true;
            }
            else
            {
                Console.WriteLine("You have to add watter to " + this);
            }
        }

        public override void InteractWithWater(AbstractWater water)
        {
            if (!IsBottleFiller)
            {
                Console.WriteLine(this + " interacts with: " + water);
                IsBottleFiller = true;
            }
            else
            {
                Console.WriteLine(water + " was already filled to: " + this);
            }
        }
    }
}
