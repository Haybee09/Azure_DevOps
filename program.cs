using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a prompt to the user
        Console.Write("Please, Enter your name: ");
        
        // Read user input
        string userName = Console.ReadLine();
        
        // Greet the user
        Console.WriteLine($"Hello, {userName}! Welcome to .NET 8.");
    }
}
