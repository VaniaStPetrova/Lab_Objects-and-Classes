using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] inputParameters = Console.ReadLine().Split();

                if (!salesByTown.ContainsKey(inputParameters[0]))
                {
                    salesByTown.Add(inputParameters[0],
                        decimal.Parse(inputParameters[2]) * decimal.Parse(inputParameters[3]));
                }
                else
                {
                    salesByTown[inputParameters[0]] += decimal.Parse(inputParameters[2]) * decimal.Parse(inputParameters[3]);
                }
            }

            foreach (var item in salesByTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
    

