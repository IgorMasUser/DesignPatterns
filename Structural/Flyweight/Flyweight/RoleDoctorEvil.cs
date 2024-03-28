namespace Flyweight_Film
{
    class RoleDoctorEvil : Flyweight
    {
        Flyweight flyweight;

        public RoleDoctorEvil(Flyweight flyweight)
        {
           this.flyweight = flyweight;
        }

        public override void Greeting(string greeting)
        {
            flyweight.Greeting(greeting);
        }
    }
}
