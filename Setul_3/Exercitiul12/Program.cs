
Console.WriteLine($"Introduceti prima oara dimensiunea vectorului , iar apoi elementele acestuia .");
Console.WriteLine($"Algoritmul va afisa vectorul sortat crescator prin metoda Selectiei.");
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

// Selection Sort

for (int i = 0; i < n - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < n; j++)
    {
        if (vector[j] < vector[min])
            min = j;
    }

    if (min != i)
    {
        int aux = vector[i];
        vector[i] = vector[min];
        vector[min] = aux;
    }
}

//Afisarea vectorului sortat
Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.Write($"{vector[i]} ");
