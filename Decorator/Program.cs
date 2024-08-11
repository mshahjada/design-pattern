namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlainText plainText = new PlainText("Decorate Me!");

            IText boldText = new TextBlod(plainText);
            Console.WriteLine(boldText.GetText());

            IText italicText = new TextItalic(plainText);
            Console.WriteLine(italicText.GetText());

            IText boldItalicText = new TextItalic(boldText);
            Console.WriteLine(boldItalicText.GetText());

            Console.ReadKey();
        }
    }
}