var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;

while (!shallExit)
{
	Console.WriteLine();
	Console.WriteLine("What do you want to do?");
	Console.WriteLine("[S]ee all TODOs");
	Console.WriteLine("[A]dd a TODO");
	Console.WriteLine("[R]emove a TODO");
	Console.WriteLine("[E]xit");

	var userChoice = Console.ReadLine()?.ToUpper();

	switch (userChoice)
	{
		case "E":
			shallExit = true;
			break;
		case "S":
			SeeAllTodos();
			break;
		case "A":
			AddTodo();
			break;
		case "R":
			RemoveTodo();
			break;
		default:
			Console.WriteLine("Invalid choice");
			break;
	}
}

void SeeAllTodos()
{
	if (todos.Count == 0)
	{
		ShowNoTodosMessage();
		return;
	}

	for (int i = 0; i < todos.Count; i++)
	{
		Console.WriteLine($"{i + 1}. {todos[i]}");
	}

}

void AddTodo()
{
	string description;
	do
	{
		Console.WriteLine(value: "Enter the todo description");
		description = Console.ReadLine();
	} while (!IsDescriptionValid(description));

	todos.Add(description);
}

void RemoveTodo()
{
	if (todos.Count == 0)
	{
		ShowNoTodosMessage();
		return;
	}
	int index;
	do
	{
		Console.WriteLine("Select the index of the TODO you want to remove");
		SeeAllTodos();
	} while (!TryReadIndex(out index));
	RemoveTodoAtIndex(index - 1);
}

void RemoveTodoAtIndex(int index)
{
	var todoToBeRemoved = todos[index];
	todos.RemoveAt(index);
	Console.WriteLine($"TODO removed: {todoToBeRemoved}");
}

bool TryReadIndex(out int index)
{
	var userInput = Console.ReadLine();
	var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(userInput);
	if (isNullOrWhiteSpace)
	{
		index = 0;
		Console.WriteLine("Selected index cannot be empty");
		return false;
	}
	if (int.TryParse(userInput, out index) && index >= 1 && index <= todos.Count)
	{

		return true;
	}

	Console.WriteLine("The given index is not valid");
	return false;
}
void ShowNoTodosMessage()
{
	Console.WriteLine("No TODOs have been added yet");
}

bool IsDescriptionValid(string description)
{
	if (string.IsNullOrWhiteSpace(description))
	{
		Console.WriteLine("The description cannot be empty");
		return false;
	}
	if (todos.Contains(description))
	{
		Console.WriteLine("The description must be unique");
		return false;
	}
	return true;
}