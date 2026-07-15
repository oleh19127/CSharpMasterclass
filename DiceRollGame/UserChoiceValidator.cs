public class UserChoiceValidator
{
	public bool TryParseAndValidate(string? input, out int validNumber)
	{
		bool isParsed = int.TryParse(input, out validNumber);


		// if (isParsed && (validNumber < 1 || validNumber > 6)) return false;

		return isParsed;
	}
}
