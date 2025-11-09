namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            var task1 = new Calculator(2, 2, '+');
            Console.WriteLine(task1.Calculate());

            var task2 = new Calculator(2, 3, '/');
            Console.WriteLine(task2.Calculate());


            var task3 = new Calculator(2, 0, '/');
            Console.WriteLine(task3.Calculate());
        }
    }
}