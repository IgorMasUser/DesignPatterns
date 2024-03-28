namespace Memento
{
    public class Backpack
    {
        public string Content
        {
            private set;
            get;
        }

        public Backpack(string Content)
        {
            this.Content = Content;
        }
    }
}
