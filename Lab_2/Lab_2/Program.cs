using System;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Pair money = new Money(rand.Next(0,999), rand.Next(0, 99));
            Pair money1 = new Money(rand.Next(0, 999), rand.Next(0, 99));
            Console.WriteLine("EXAMLPE OF OPERATIONS FOR MONEY");

            Console.WriteLine(money + " + " + money1 + " = " + money.Plus(money1));
            Console.WriteLine();
            Console.WriteLine(money + " - " + money1 + " = " + money.Minus(money1));
            Console.WriteLine();
            Console.WriteLine(money + " * " + money1 + " = " + money.Mul(money1));
            Console.WriteLine();
            Console.WriteLine(money + " / " + money1 + " = " + money.Div(money1));
            Console.WriteLine();

            money = new Complex(rand.Next(0, 999), rand.Next(0, 99));
            money1 = new Complex(rand.Next(0, 999), rand.Next(0, 99));
            Console.WriteLine("EXAMLPE OF OPERATIONS FOR COMPLEXES");

            Console.WriteLine(money + " + " + money1 + " = " + money.Plus(money1));
            Console.WriteLine();
            Console.WriteLine(money + " - " + money1 + " = " + money.Minus(money1));
            Console.WriteLine();
            Console.WriteLine(money + " * " + money1 + " = " + money.Mul(money1));
            Console.WriteLine();
            Console.WriteLine(money + " / " + money1 + " = " + money.Div(money1));
            Console.WriteLine();


            Console.WriteLine("Series: \n");
            var series = new Series<Pair>();
            for(int i = 0; i<10; i++)
            {
                series.Add(new Money(rand.Next(0, 999), rand.Next(0, 99)));
                series.Add(new Complex(rand.Next(0, 999), rand.Next(0, 99)));
            }
            series.Print();

        }
    }
}
