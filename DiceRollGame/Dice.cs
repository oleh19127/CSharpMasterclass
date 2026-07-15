public class Dice
{
	private readonly int _sidesCount;
	public Dice(int sidesCount)
	{
		_sidesCount = sidesCount;
	}

	public int Roll() => Random.Shared.Next(1, _sidesCount + 1);

}
