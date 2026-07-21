namespace DiceRollGameAuthor.Game
{
    public class Dice
    {
        private readonly Random _random;
        private readonly int SidesCount;

        public Dice(Random random, int sidesCount)
        {
            _random = random;
            SidesCount = sidesCount;
        }

        public int Roll() => _random.Next(1, SidesCount + 1);

        public void Describe() => Console.WriteLine($"This a dice with {SidesCount} sides");
    }

}
