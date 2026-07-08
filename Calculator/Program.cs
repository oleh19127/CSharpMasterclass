Console.WriteLine("Hello");

var firstInput = GetInput("Input the first number: ");

var secondInput = GetInput("Input the second number: ");

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

var userChoice = Console.ReadLine();

if (string.Equals(userChoice, "A", StringComparison.OrdinalIgnoreCase))
{
    var result = AddNumbers(firstInput, secondInput);
    Console.WriteLine($"The sum of the numbers is: {result}");
}
else if (string.Equals(userChoice, "S", StringComparison.OrdinalIgnoreCase))
{
    var result = SubtractNumbers(firstInput, secondInput);
    Console.WriteLine($"Result of subtraction: {result}");
}
else if (string.Equals(userChoice, "M", StringComparison.OrdinalIgnoreCase))
{
    var result = MultiplyNumbers(firstInput, secondInput);
    Console.WriteLine($"Result of multiplication: {result}");
}
else
{
    Console.WriteLine("Invalid choice.");
}

int MultiplyNumbers(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}

int SubtractNumbers(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}

int AddNumbers(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

int GetInput(string message)
{
    Console.Write(message);

    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input. Please enter a real number.");
        Console.Write(message);
    }

    return number;
}
