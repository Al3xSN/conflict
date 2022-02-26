Console.WriteLine("Vasil");

string[] a = { "Alex", "Vasil" };

string GetName(string[] array)
{
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