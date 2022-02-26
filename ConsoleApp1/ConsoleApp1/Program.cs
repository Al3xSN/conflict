string[] a = { "Alex", "Vasil", "Mihaela", "Rumqn", "Svetla" };

string GetName(string[] array)
{
    Console.WriteLine("Program started...");

    foreach (var name in array)
    {
        if (name == "Vasil")
        {
            return name;
        }
    }

    return "Name not found!";
}

Console.WriteLine(GetName(a));
Console.WriteLine("Program terminated!");