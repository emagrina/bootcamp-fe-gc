namespace ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            Console.WriteLine("A:" + a);
            Console.WriteLine("B:" + b);
            Console.WriteLine("C:" + c);
            Console.WriteLine("D:" + d);

            int temp = b;

            b = c;
            c = a;
            a = d;
            d = temp;

            Console.WriteLine("A:" + a);
            Console.WriteLine("B:" + b);
            Console.WriteLine("C:" + c);
            Console.WriteLine("D:" + d);


        }
    }
}

