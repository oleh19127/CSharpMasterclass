using DiceRollGameAuthor.Game;

var random = new Random();
var dice = new Dice(random, 6);
var guessingGame = new GuessingGame(dice, 3);

GameResult gameResult = guessingGame.Play();

GuessingGame.PrintResult(gameResult);

Console.ReadKey();
