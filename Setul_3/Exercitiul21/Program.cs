
Console.WriteLine($"Introduceti cei 2 vectori cu valori binare.");
Console.WriteLine($"Algoritmul va afisa ordinea lor lexicografica.");
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

int m = p.Length;
int[] v2 = new int[m];

for (int i = 0; i < m; i++)
    v2[i] = int.Parse(p[i]);

// Determinarea ordini lexicografice si afisarea acesteia

int x = 0, y = 0;

while (x < n && y < m)
{
    if (v1[x] == v2[y])
    {
        x++; y++;
    }
    else if (v1[x] < v2[y])
    {
        Console.WriteLine($"Ordinea lexicografica este :");

        Console.Write($"1 - ");
        for (int i = 0; i < n; i++)
            Console.Write($"{v1[i]} ");

        Console.WriteLine();

        Console.Write($"2 - ");
        for (int i = 0; i < m; i++)
            Console.Write($"{v2[i]} ");

        return;
    }
    else
    {
        Console.WriteLine($"Ordinea lexicografica este :");

        Console.Write($"1 - ");
        for (int i = 0; i < m; i++)
            Console.Write($"{v2[i]} ");

        Console.WriteLine();

        Console.Write($"2 - ");
        for (int i = 0; i < n; i++)
            Console.Write($"{v1[i]} ");

        return;
    }
}

if (x == n - 1)
{
    Console.WriteLine($"Ordinea lexicografica este :");

    Console.Write($"1 - ");
    for (int i = 0; i < n; i++)
        Console.Write($"{v1[i]} ");

    Console.WriteLine();

    Console.Write($"2 - ");
    for (int i = 0; i < m; i++)
        Console.Write($"{v2[i]} ");

}
else
{
    Console.WriteLine($"Ordinea lexicografica este :");

    Console.Write($"1 - ");
    for (int i = 0; i < m; i++)
        Console.Write($"{v2[i]} ");

    Console.WriteLine();

    Console.Write($"2 - ");
    for (int i = 0; i < n; i++)
        Console.Write($"{v1[i]} ");

    return;
}
