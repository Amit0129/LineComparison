using System.Net.Http.Headers;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Welcome to Line Comparison Computation======");


            Console.Write("Enter the x0 of the Cordinate (x0,y0): ");
            double x0 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y0 of the Cordinate (x0,y0): ");
            double y0 = double.Parse(Console.ReadLine());
            Console.Write("Enter the x1 of the Cordinate (x1,y1): ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y1 of the Cordinate (x1,y1): ");
            double y1 = double.Parse(Console.ReadLine());


            Console.Write("Enter the x2 of the Cordinate (x2,y2): ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y2 of the Cordinate (x2,y2): ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the x3 of the Cordinate (x3,y3): ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter the y3 of the Cordinate (x3,y3): ");
            double y3 = double.Parse(Console.ReadLine());


            //double temp =Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
            //Console.WriteLine(temp);
            LineLengthCalculator comparision = new LineLengthCalculator();
            double firstLen = comparision.LengthCalc(x0, y0, x1, y1);
            double secondLen = comparision.LengthCalc(x2, y2, x3, y3);
            Console.WriteLine(firstLen);
            Console.WriteLine(secondLen);
            if (firstLen == secondLen)
            {
                Console.WriteLine("The Two Lines Length Is Eqal");
            }
            else
            {
                Console.WriteLine("The Two lines Are Not Eqal");
            }

        }
    }
}