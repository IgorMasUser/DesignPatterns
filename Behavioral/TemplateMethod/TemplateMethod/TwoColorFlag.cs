namespace TemplateMethod
{
    public abstract class TwoColorFlag
    {
        public void Drow()
        {
            DrowTopPart();
            DrowBottomPart();
        }

        protected abstract void DrowTopPart();
        protected abstract void DrowBottomPart();
    }
}
