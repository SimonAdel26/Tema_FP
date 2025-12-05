Console.WriteLine($"Introduceti elementele unui vector .");
Console.WriteLine($"Algoritmul va afisa suma elementelor vectorului introdusa de dumneavoastra.");

//citire
string line = Console.ReadLine();

//Calcularea sumei
int Suma = 0;
string[] vector = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

foreach (string s in vector)
{
    int nr = int.Parse(s);
    Suma += nr;
}

// Afisarea sumei
Console.WriteLine();
Console.WriteLine($"Suma elementelor vectorului data de dumneavoastra este :{Suma}");