var internationalPizzaDay23 = new DateTime(2023, 2, 9);

Console.WriteLine($"Year is {internationalPizzaDay23.Year}");
Console.WriteLine($"Month is {internationalPizzaDay23.Month}");
Console.WriteLine($"Day is {internationalPizzaDay23.Day}");
Console.WriteLine($"Day Of Week is {internationalPizzaDay23.DayOfWeek}");

var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

Console.WriteLine($"Year is {internationalPizzaDay24.Year}");
Console.WriteLine($"Month is {internationalPizzaDay24.Month}");
Console.WriteLine($"Day is {internationalPizzaDay24.Day}");
Console.WriteLine($"Day Of Week is {internationalPizzaDay24.DayOfWeek}");

Console.ReadKey();

