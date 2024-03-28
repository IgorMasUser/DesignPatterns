namespace TemplateMethod
{
    class UkraineFlag : TwoColorFlag
    {
        protected override void DrowTopPart()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 7));
        }

        protected override void DrowBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', 7));
        }
    }
}
