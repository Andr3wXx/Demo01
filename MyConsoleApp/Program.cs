namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter Mywriter = new MessageWriter();
            Mywriter.Write("Hello, Writer!");

            FiggleWriter Fwriter = new FiggleWriter();
            Fwriter.Write("Hello , Figgle!!   " +
                "Milton is black");
        }
    }
}
