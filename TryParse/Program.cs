bool isParsingSuccessful;

do
{
	Console.WriteLine("Enter a number:");
	var userInput = Console.ReadLine();

	isParsingSuccessful = int.TryParse(userInput, out int number);

	if (isParsingSuccessful)
	{
		Console.WriteLine($"Parsing worked, number is {number}");
	}
	else
	{
		Console.WriteLine("Parsing is not successful");
	}
} while (!isParsingSuccessful);


Console.ReadKey();