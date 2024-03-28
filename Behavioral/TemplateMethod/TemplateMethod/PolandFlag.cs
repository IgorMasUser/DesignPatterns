namespace TemplateMethod
{
    class PolandFlag : TwoColorFlag
    {
        protected override void DrowTopPart()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', 7));
        }

        protected override void DrowBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ', 7));
        }
    }
}
