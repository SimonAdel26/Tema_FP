int prim(int a)
{
    for (int d = 3; d * d <= a; d = d + 2)
        if (a % d == 0) return 0;

    return 1;
}

Console.WriteLine($"Introduceti un numar natural n pentru a putea determina numerele prime mai mici sau egal cu n.");
Console.WriteLine();

//Citire
string line = Console.ReadLine();
int n = int.Parse(line);
int[] vector = new int[n + 1];


//determinarea numerelor prime mai mici sau egali cu n 

for (int i = 2; i * i <= n; i++)
{
    if (vector[i] != 1)
    {
        if (prim(i) == 1)
        {
            int multiplu = 2;
            for (int j = i * 2; j <= n; j = i * multiplu)
            {
                vector[j] = 1;
                multiplu++;
            }
        }
    }
}

//Afisare
for (int i = 2; i <= n; i++)
    if (vector[i] == 0)
        Console.Write($"{i} ");