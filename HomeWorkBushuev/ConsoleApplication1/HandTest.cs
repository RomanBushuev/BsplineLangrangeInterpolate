using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkBushuev;

namespace ConsoleApplication1
{
    class HandTest
    {
        private static int preciosion = 3;
        public static void Show(IEnumerable<double> input)
        {
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < input.Count(); ++i)
            {
                Console.Write(string.Format("{0} ", input.ElementAt(i)));
            }
            Console.WriteLine(new string('-', 50));
        }
        static void Main(string[] args)
        {
            string fileName = "data.txt";
            List<string> strings = File.ReadAllLines(fileName).ToList();

            List<double> x_s = strings
                .First()
                .Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            List<double> y_s = strings
                .Last()
                .Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            Console.WriteLine(x_s.First());
            Console.WriteLine(x_s.Last());

            Langrange langrange = new Langrange(x_s, y_s);
            double minValue = x_s.First();
            double maxValue = x_s.Last();
            int numberOfPoints = 300;
            double step = (Math.Abs(minValue) + Math.Abs(maxValue)) / numberOfPoints;

            List<double> pol_x = new List<double>();
            for (int i = 0; i <= numberOfPoints; ++i)
            {
                pol_x.Add(Math.Round(minValue + step * i, preciosion));
            }

            Show(pol_x);
        }

    }
}
