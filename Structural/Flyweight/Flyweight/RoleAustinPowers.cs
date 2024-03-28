namespace Flyweight_Film
{
    class RoleAustinPowers: Flyweight
    {
        Flyweight flyweight;

        public RoleAustinPowers(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greeting(string greeting)
        {
            flyweight.Greeting(greeting);
        }
    }
}
