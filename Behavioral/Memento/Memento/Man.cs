namespace Memento
{
    class Man
    {
        public string Clothes {  get; set; }

        public void Dress(Backpack backpack)
        {
            Clothes = backpack.Content;
        }

        public Backpack UnDress()
        {
            return new Backpack(Clothes);
        }
    }
}
