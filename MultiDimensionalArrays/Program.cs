// char[,] letters = new char[2, 3];

// letters[0, 0] = 'A';
// letters[0, 1] = 'B';
// letters[0, 2] = 'C';
// letters[1, 0] = 'D';
// letters[1, 1] = 'E';
// letters[1, 2] = 'F';


// var height = letters.GetLength(0);
// var width = letters.GetLength(1);

// Console.WriteLine($"Height is {height}");
// Console.WriteLine($"Width is {width}");
// for (int i = 0; i < height; i++)
// {
// 	Console.WriteLine($"i is {i}");
// 	for (int j = 0; j < width; j++)
// 	{
// 		Console.WriteLine($"j is {j}");
// 		System.Console.WriteLine($"Element is {letters[i, j]}");
// 	}
// }

var words = new List<string>
{
"one", "TWO", "THREE", "four"
};

var upperCaseWords = new List<string>();

foreach (var word in words)
{
	if (string.IsNullOrEmpty(word)) continue;

	bool isAllUpper = true;

	foreach (char character in word)
	{
		if (!char.IsUpper(character))
		{
			isAllUpper = false;
			break;
		}
	}

	if (isAllUpper)
	{
		upperCaseWords.Add(word);
	}
}

upperCaseWords.Distinct().ToList();

upperCaseWords.ForEach(word => Console.WriteLine(word));