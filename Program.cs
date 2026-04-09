// unity-toolkit — Unity editor toolkit with custom inspectors, gizmos, and build pipeline
using System;

namespace unity_toolkit;

class Program
{
    static async Task<int> Main(string[] args)
    {
        Console.WriteLine("[unity-toolkit] Starting application...");

        try
        {
            await RunAsync();
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Fatal error: {ex.Message}");
            return 1;
        }
    }

    static Task RunAsync()
    {
        Console.WriteLine("Application initialized successfully");
        return Task.CompletedTask;
    }
}
