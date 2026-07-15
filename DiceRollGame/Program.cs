var validator = new UserChoiceValidator();
var dice = new Dice(6);
var game = new DiceGame(validator, dice, maxTries: 3);

game.Play();
