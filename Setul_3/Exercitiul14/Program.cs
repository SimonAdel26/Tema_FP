
Console.WriteLine($"Introduceti prima oara dimensiunea vectorului , iar apoi elementele acestuia .");
Console.WriteLine($"Algoritmul va afisa vectorul schimbat in care toatele elemente egale cu 0 sunt puse la final.");
Console.WriteLine();

// Citire 
string line = Console.ReadLine();
int n = int.Parse(line);
line = Console.ReadLine();
int[] vector = new int[n];
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < n; i++)
{
    vector[i] = int.Parse(p[i]);
}

// Interschimbarea - toate elementele egale cu 0 puse la final

int Numarare = 0;
for (int j = 0; j < n; j++)
{
    if (vector[j] != 0)
    {
        vector[Numarare++] = vector[j];
    }
}

while (Numarare < n)
    vector[Numarare++] = 0;

// Afisarea vectorului interschimbat 
Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.Write($"{vector[i]} ");


