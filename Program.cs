/* 

A metric ton is 35,273.92 ounces. Write a program that will read the 
weight of a package of breakfast cereal in ounces and output the weight
in metric tons as well as the number of boxes needed to yield one metric
ton of cereal 

*/


using System;

namespace CerealWeightConverter
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            float metricTon = 35273.92f;

            Console.Write("Enter the weight of a box of cereal in ounces: ");
            string input = Console.ReadLine();
            if (float.TryParse(input, out _)) 
            {
                float boxWeightInTons = OuncesToMetricTons(float.Parse(input), metricTon);
                float boxesNeededForTon = MetricTonsToOunces(float.Parse(input), metricTon);
                Console.WriteLine("");
                Console.WriteLine($"This cereal's weight in metric tons is {boxWeightInTons}.");
                Console.WriteLine($"You need roughly {boxesNeededForTon} boxes of this cereal to equal a metric ton.");
            }
            else 
            {
                Console.WriteLine("");
                Console.WriteLine("Input was not a valid number.");
            }
        }

        static float OuncesToMetricTons(float weight, float metricTon)
        {
            return weight / metricTon;
        }

        static float MetricTonsToOunces(float weight, float metricTon)
        {
            return metricTon / weight;
        }
    } 
}