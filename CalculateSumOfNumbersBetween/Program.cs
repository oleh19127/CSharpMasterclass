static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
{
	if (lastNumber < firstNumber)
	{
		return 0;
	}

	var sum = 0;
	var counter = firstNumber;

	while (counter <= lastNumber)
	{
		sum += counter;
		counter++;
	}

	return sum;
}

Console.WriteLine(CalculateSumOfNumbersBetween(5, 10));

