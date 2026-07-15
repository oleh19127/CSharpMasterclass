var stopWatch = Stopwatch.StartNew();

for (int i = 0; i <= 10000; i++)
{
	Console.WriteLine($"Loop number: {i}");
}

stopWatch.Stop();

Console.WriteLine($"Time in ms: {stopWatch.ElapsedMilliseconds}");
