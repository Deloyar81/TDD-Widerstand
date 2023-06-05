namespace TDD_Widerstand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Widerstand testWiderstand = new Widerstand();

            string result = testWiderstand.WiderstandBerechnen(args[0], args[1], args[2], args[3]);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}