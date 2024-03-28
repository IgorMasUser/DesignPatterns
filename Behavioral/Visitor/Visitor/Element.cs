namespace Visitor_Pattern
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
