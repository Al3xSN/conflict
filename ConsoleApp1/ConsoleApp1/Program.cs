Console.WriteLine("Vasil");

string[] a = { "Alex", "Vasil", "Mihaela", "Rumqn", "Svetla" };

string GetName(string[] array)
{
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