namespace SomeBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle rect1 = new Rectangle(1, 2, 3);
            Rectangle rect2 = new Rectangle(10, 12, 13);

            Rectangle rect3 = rect1 + rect2;
            System.Console.WriteLine(rect3.Lenght);

        }
    }
}