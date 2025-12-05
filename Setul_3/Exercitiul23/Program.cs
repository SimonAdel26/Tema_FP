
Console.WriteLine($"Introduceti prima oara dimensiunea vectorilor , iar apoi elementele acestora.");
Console.WriteLine($"Algoritmul va afisa intersectia , reuniunea si diferenta a celor 2 vectori.");
Console.WriteLine();

//Citire
string line = Console.ReadLine();
string[] p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int n = int.Parse(p[0]);
int m = int.Parse(p[1]);
int[] v1 = new int[n], v2 = new int[m];

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < n; i++)
    v1[i] = int.Parse(p[i]);

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < m; i++)
    v2[i] = int.Parse(p[i]);

//intersectie 
int[] intersectie = new int[n + m];
int k = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        if (v1[i] == v2[j])
        {
            intersectie[k++] = v1[i];
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

//Reuniune

int[] reuniune = new int[n + m];

int x = 0, y = 0, z = 0;

while (x < n && y < m)
{
    if (v1[x] < v2[y])
    {
        reuniune[z++] = v1[x++];
    }
    else if (v1[x] > v2[y])
    {
        reuniune[z++] = v2[y++];
    }
    else
    {
        reuniune[z++] = v2[y++];
        x++;
    }

}

while (x < n)
    reuniune[z++] = v1[x++];

while (y < m)
    reuniune[z++] = v2[y++];

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
    for (int f = 0; f < m; f++)
        if (v1[i] == v2[f]) { ok = 1; break; }

    if (ok == 0) diferenta1[d1++] = v1[i];
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
        for (int f = 0; f < n; f++)
            if (v1[f] == v2[i]) { ok = 1; break; }

        if (ok == 0) diferenta2[d2++] = v2[i];
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