
Console.WriteLine($"Introduceti cei 2 vectori.");
Console.WriteLine($"Algoritmul va afisa primul vector in ordine crescatoare , dupa al doilea vector.");
Console.WriteLine();

//Citire

string line = Console.ReadLine();
string[] p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int n = p.Length;
int[] v1 = new int[n];

for (int i = 0; i < n; i++)
    v1[i] = int.Parse(p[i]);

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);


int[] v2 = new int[n];

for (int i = 0; i < n; i++)
    v2[i] = int.Parse(p[i]);

//Sortare


for (int i = 0; i < n - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < n; j++)
    {
        if (v1[j] < v1[min])
            min = j;
        else if (v1[j] == v1[min])
        {
            if (v2[j] > v2[min]) min = j;
        }
    }

    if (min != i)
    {
        int aux = v1[i];
        v1[i] = v1[min];
        v1[min] = aux;

        aux = v2[i];
        v2[i] = v2[min];
        v2[min] = aux;


    }
}

//Afisare

Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.Write($"{v1[i]} ");
Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.Write($"{v2[i]} ");
