using BreakingSRP.DataAccess;

var names = new Names();
var path = new NamesFileBuilder().BuildFilePath();
var stringTextualRepository = new StringTextualRepository();
if (File.Exists(path))
{
	Console.WriteLine("Names file already exists. Loading names.");
	var stringsFromFile = stringTextualRepository.Read(path);
	names.AddNames(stringsFromFile);
}
else
{
	Console.WriteLine("Names file does not yet exist.");
	names.AddName("John");
	names.AddName("not a valid name");
	names.AddName("Claire");
	names.AddName("definitely not a valid name");

	Console.WriteLine("Saving names to a file.");
	stringTextualRepository.Write(path, names.All);
}
Console.WriteLine(new NamesFormatter().Format(names.All));
Console.ReadKey();
