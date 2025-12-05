Console.WriteLine($"Introduceti elementele vectorului .");
Console.WriteLine($"Algoritmul va afisa cea mai mica valoare si cea mai mare valoare din vector si aparitia acestora.");

//Citire

string line = Console.ReadLine();
string[] vector = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

// determinarea cea mai mica valoare si cea mai mare valoare din vector si aparitia lor
int Minim = int.MaxValue, Maxim = int.MinValue, AparitieMin = 1, AparitieMax = 1;
foreach (string s in vector)
{
    int nr = int.Parse(s);
    if (nr < Minim)
    {
        Minim = nr;
        AparitieMin = 1;
    }
    else if (nr == Minim) AparitieMin++;
    if (nr > Maxim)
    {
        Maxim = nr;
        AparitieMax = 1;
    }
    else if (nr == Maxim) AparitieMax++;
}

// Afisarea cea mai mica valoare si cea mai mare valoare din vector si aparitia lor

Console.WriteLine($"Cea mai mica valoare din vector este {Minim} si apare de {AparitieMin} ori.");
Console.WriteLine($"Cea mai mare valoare din vector este {Maxim} si apare de {AparitieMax} ori.");