using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GameNamespace
{
    class Program
    {
        static async Task DelayAndClearAsync(int delayMilliseconds)
        {
            await Task.Delay(delayMilliseconds);
            Console.Clear();
        }

        static async Task PrepareConsoleAsync()
        {
            Console.WriteLine("Prepare for the game...");
            await DelayAndClearAsync(3000);
        }

        static async Task IsReadyAsync(bool status)
        {
            if (status)
            {
                Console.WriteLine("System Ready!");
                await DelayAndClearAsync(3000);
            }
            else
            {
                Console.WriteLine("*Sparks*  System Shutdown!");
                await DelayAndClearAsync(3000);
                Environment.Exit(0);
            }
        }

        static async Task StartGameAsync()
        {
            Console.WriteLine("Starting the game...");
            await DelayAndClearAsync(3000);
        }

        static async Task Main(string[] args)
        {
            await PrepareConsoleAsync();
            await IsReadyAsync(true);
            await StartGameAsync();
        }
    }
}
