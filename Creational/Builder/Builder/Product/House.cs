using System.Collections;

namespace Builder.Product
{
    public class House
    {
        ArrayList houseParts = new ArrayList();

        public void Add(object part)
        {
            houseParts.Add(part);
        }
    }
}
