
Console.WriteLine($"Introduceti prima oara dimensiunea vectorului , iar apoi elementele acestuia .");
Console.WriteLine($"Algoritmul va afisa vectorul schimbat in care toate elemente afisate apar de o singura data.");
Console.WriteLine();

//Citire
string line = Console.ReadLine();
int n = int.Parse(line);
line = Console.ReadLine();
int[] vector = new int[n];
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < n; i++)
{
    vector[i] = int.Parse(p[i]);
}

//eliminarea elementelor care se repeta
for (int i = 0; i < n; i++)
{
    int verificare = 0;
    for (int j = i + 1; j < n; j++)
        if (vector[j] == vector[i])
        {
            verificare = 1;
            for (int x = j; x < n - 1; x++)
                vector[x] = vector[x + 1];
            n--;
        }
    if (verificare == 1) i--;
}

// Afisarea vectorului modificat 
Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.Write($"{vector[i]} ");
