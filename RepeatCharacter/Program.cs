string RepeatCharacter(char character, int targetLength)
{
	if (targetLength <= 1)
	{
		return character.ToString();
	}

	string result = character.ToString();

	do
	{
		result += character;
	}
	while (result.Length < targetLength);

	return result;
}

Console.WriteLine(RepeatCharacter('a', 2));