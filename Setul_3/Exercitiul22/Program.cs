
Console.WriteLine($"Introduceti prima oara dimensiunea vectorilor , iar apoi elementele acestora.");
Console.WriteLine($"Algoritmul va afisa intersectia , reuniunea si diferenta a celor 2 vectori.");
Console.WriteLine();

//Citire
string line = Console.ReadLine();
string[] p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int n = int.Parse(p[0]);
int m = int.Parse(p[1]);
int[] s1 = new int[n], s2 = new int[m];

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < n; i++)
    s1[i] = int.Parse(p[i]);

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < m; i++)
    s2[i] = int.Parse(p[i]);

//intersectie 
int[] intersectie = new int[n + m];
int k = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        if (s1[i] == s2[j])
        {
            int ok = 1;
            for (int x = 0; x < k; x++)
                if (intersectie[x] == s1[i])
                {
                    ok = 0;
                    break;
                }

            if (ok == 1) intersectie[k++] = s1[i];
        }
}
if (k != 0)
{
    Console.Write($"Intersesctia a celor 2 vectori este :");
    for (int i = 0; i < k; i++)
        Console.Write($"{intersectie[i]} ");
}
else Console.WriteLine($"Nu au niciun element comun.");

Console.WriteLine();


//reuniune 

int[] reuniune = new int[n + m];

for (int i = 0; i < n; i++)
    reuniune[i] = s1[i];

int z = n;
for (int i = 0; i < m; i++)
{
    int ok = 0;
    for (int x = 0; x < z; x++)
    {
        if (s2[i] == reuniune[x])
        {
            ok = 1;
            break;
        }
    }

    if (ok == 0) reuniune[z++] = s2[i];
}

Console.Write($"Reuniunea a celor 2 vectori este :");
for (int i = 0; i < z; i++)
    Console.Write($"{reuniune[i]} ");

Console.WriteLine();


//Diferenta 

int[] diferenta1 = new int[n];
int d1 = 0;

for (int i = 0; i < n; i++)
{
    int ok = 0;
    for (int x = 0; x < m; x++)
        if (s1[i] == s2[x]) { ok = 1; break; }

    if (ok == 0) diferenta1[d1++] = s1[i];
}

if (d1 != 0)
{
    Console.Write($"Diferenta 1 (elementele din primul vector nu se regasesc in al doilea vector) este :");
    for (int i = 0; i < d1; i++)
        Console.Write($"{diferenta1[i]} ");
    Console.WriteLine();

    int[] diferenta2 = new int[m];
    int d2 = 0;

    for (int i = 0; i < m; i++)
    {
        int ok = 0;
        for (int x = 0; x < n; x++)
            if (s1[x] == s2[i]) { ok = 1; break; }

        if (ok == 0) diferenta2[d2++] = s2[i];
    }

    if (d2 != 0)
    {
        Console.Write($"Diferenta 2 (elementele din al doilea vector nu se regasesc in primul vector) este :");
        for (int i = 0; i < d2; i++)
            Console.Write($"{diferenta2[i]} ");
    }
    else
    {
        Console.Write($"Al doilea vector este implicat in primul vector. Nu se poate efectua diferentierea.");
    }
}
else
{
    Console.Write($"Primul vector este implicat in al doilea vector. Nu se poate efectua diferentierea.");
}
