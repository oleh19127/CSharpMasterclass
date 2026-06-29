int CalculateFactorial(int number)
{
	if (number < 0)
	{
		throw new ArgumentException("The factorial of a negative number does not exist");
	}

	int result = 1;

	for (int i = 1; i <= number; i++)
	{
		result *= i;
	}

	return result;
}

System.Console.WriteLine(CalculateFactorial(0));