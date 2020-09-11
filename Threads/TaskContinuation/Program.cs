using System;
using System.Threading.Tasks;
namespace TaskContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new Func<int, int>((n) =>
              {
                  int sum = 0;
                  for (int i = 0; i < n; i++)
                  {
                      Task.Delay(5000);
                      if (i % 2 == 0)
                      {
                          sum = sum + i;
                      }
                      }
                  return sum;
              });

            Task<int> task = new Task<int>(() =>
              {
                  return func(30);
              });
            Task<int> taskSqaure = task.ContinueWith((mytask) =>
            {
                return (int)Math.Sqrt(mytask.Result);
            },TaskContinuationOptions.OnlyOnRanToCompletion);
            task.Start();
            Task.WaitAll(task, taskSqaure);
            Console.WriteLine($"First Task Result : Sum {task.Result}");
            Console.WriteLine($"Second Task Result :SquareRoot{taskSqaure.Result}");
            Console.ReadLine();
        }
    }
}
