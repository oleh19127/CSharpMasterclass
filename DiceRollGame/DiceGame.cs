public class DiceGame
{

	private readonly UserChoiceValidator _validator;
	private readonly Dice _dice;
	private readonly int _maxTries;

	public DiceGame(UserChoiceValidator validator, Dice dice, int maxTries)
	{
		_validator = validator;
		_dice = dice;
		_maxTries = maxTries;
	}

	public void Play()
	{
		Console.WriteLine($"Dice rolled. Guess what number it shows in {_maxTries} tries.");

		int randomNumber = _dice.Roll();

		for (int i = 1; i <= _maxTries; i++)
		{
			int userChoice;
			bool isValid;

			do
			{
				Console.Write("Enter number: ");
				string? input = Console.ReadLine();

				isValid = _validator.TryParseAndValidate(input, out userChoice);

				if (!isValid)
				{
					Console.WriteLine("Incorrect input");
				}
			} while (!isValid);

			if (randomNumber == userChoice)
			{
				Console.WriteLine("You win");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("Wrong number");
		}

		Console.WriteLine("You lose");
		Console.ReadKey();
	}
}
