using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GameNamespace
{
    class Program
    {
        static async Task PrepareConsoleAsync()
        {
            Console.WriteLine("Prepare for the game...");
            await Task.Delay(3000);
            Console.Clear();
        }

        static async Task IsReadyAsync(bool status)
        {
            if (status)
            {
                Console.WriteLine("System Ready!");
                await Task.Delay(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("*Sparks*  System Shutdown!");
                await Task.Delay(3000);
                Console.Clear();
                Environment.Exit(0);
            }
        }

        static async Task StartGameAsync()
        {
            Console.WriteLine("Starting the game...");
            await Task.Delay(3000);
            Console.Clear();
        }

        static async Task Main(string[] args)
        {
            await PrepareConsoleAsync();
            await IsReadyAsync(true);
            await StartGameAsync();
        }
    }
}
