using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.AsynchoronusSamples
{
    public static class ParallelSample
    {
        public static async Task ProcessDataAsync(int[] data)
        {
            await Task.Run(() =>
            {
                Parallel.For(0, data.Length, i =>
                {
                    data[i] = PerformComplexCalculation(data[i]);
                });
            });

            Parallel.ForEach(data, i => {

                data[i] = PerformComplexCalculation(data[i]);
            });

            Parallel.Invoke(() =>
            {
                Console.WriteLine("action1");
            },
            ()=> {

                Console.WriteLine("action1");
            });
            
        }

        private static int PerformComplexCalculation(int value)
        {
            // Simulate a CPU-bound operation
            return value * value;
        }

        public static async Task Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5 };
            await ProcessDataAsync(data);

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
