Console.WriteLine($"Introduceti dimensiunea vectorului si un numar k , iar dupa pe o noua line introduceti elementele vectorului.");
Console.WriteLine($"Algoritmul va afisa prima pozitie din vector pe care apare k, in caz contrar se va afisa -1 .");

//Citire
string line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(p[0]);
int k = int.Parse(p[1]);

line = Console.ReadLine();
int[] vector = new int[n];
p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < n; i++)
{
    vector[i] = int.Parse(p[i]);
}

//Cautarea elementelui k in vector si afisarea pozitiei acesteia
int ok = 0;

for (int i = 0; i < k; i++)
{
    if (vector[i] == k)
    {
        Console.WriteLine($"Pe prima aparitie a elementului {k} in vectorul dat de dumneavoastra este {i}");
        ok = 1;
        break;
    }
}

if (ok == 0)
{
    Console.WriteLine($"Pe prima aparitie a elementului {k} in vectorul dat de dumneavoastra este -1");
}