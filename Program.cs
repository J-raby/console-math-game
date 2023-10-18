using MathGame.operations;
using MathGame.games;
public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
Console.WriteLine("  __   __  _______  _______  __   __  _______  _______  __   __  _______  ");
Console.WriteLine(" |  |_|  ||   _   ||       ||  | |  ||       ||   _   ||  |_|  ||       | ");
Console.WriteLine(" |       ||  |_|  ||_     _||  |_|  ||    ___||  |_|  ||       ||    ___| ");
Console.WriteLine(" |       ||       |  |   |  |       ||   | __ |       ||       ||   |___  ");
Console.WriteLine(" |       ||       |  |   |  |       ||   ||  ||       ||       ||    ___| ");
Console.WriteLine(" | ||_|| ||   _   |  |   |  |   _   ||   |_| ||   _   || ||_|| ||   |___  ");
Console.WriteLine(" |_|   |_||__| |__|  |___|  |__| |__||_______||__| |__||_|   |_||_______| ");


        Console.WriteLine("=====================================");
        Console.WriteLine("Wellcome To the Math Game\n");
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            var result = GetOperationResult(choice);
            Console.WriteLine("Now that you made your choice, this is the operation you have to make");
            Console.WriteLine(result.ShowOperation());
            Console.WriteLine("You Have 10 seconds to think");
            StartCountdown(10);
            Console.WriteLine("Your Answer is: ");
            var userResult = Console.ReadLine();
            Game currentGame = new Game(result,userResult);
            Console.WriteLine($"El resultado es.......");
            Console.WriteLine(currentGame.GetGameResult());
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice (1-4).");
        }
    }

    static IOperation GetOperationResult(int choice)
    {
        return choice switch
        {
            1 => new Addition(),
            2 => new Substraction(),
            3 => new Multiplication(),
            4 => new Division(),
            _ => throw new Exception(),
        };

    }
    static void StartCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Countdown complete!");
    }
}
}