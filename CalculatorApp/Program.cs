namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 3));
            Console.WriteLine("CI/CD pipeline работает!");
        }
    }
}
