string[] a = { "Alex", "Vasil" };

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

    return "Nqma";
}

Console.WriteLine(GetName(a));