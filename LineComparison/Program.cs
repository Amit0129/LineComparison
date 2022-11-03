namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Welcome to Line Comparison Computation======");


            Console.Write("Enter the x1 of the Cordinate (x1,y1): ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y1 of the Cordinate (x1,y1): ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the x2 of the Cordinate (x1,y1): ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y3 of the Cordinate (x1,y1): ");
            double y2 = double.Parse(Console.ReadLine());

            double temp =Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
            Console.WriteLine(temp);

        }
    }
}