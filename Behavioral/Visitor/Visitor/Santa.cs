namespace Visitor_Pattern
{
    class Santa : Visitor
    {
        public override void VisitBoysHouse(BoysHouse boysHouse)
        {
            boysHouse.TellFairyTale();
        }

        public override void VisitGirlsHouse(GirlsHouse boysHouse)
        {
            boysHouse.GiveDress();
        }
    }
}
