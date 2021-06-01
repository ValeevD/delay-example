using System;
using System.Threading.Tasks;

namespace LearningCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.CompletedTask;
            int sec = 0;

            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    Console.WriteLine($"Key: {keyInfo.Key}");
                }

                if(!t.IsCompleted)
                    continue;

                Console.WriteLine($"Second: {sec++}");
                t = DelayGame();
            }
        }

        static async Task DelayGame()
        {
            await Task.Delay(1000);
        }
    }


}
