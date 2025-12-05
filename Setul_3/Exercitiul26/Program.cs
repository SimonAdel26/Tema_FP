
Console.WriteLine($"Introduceti cele 2 numere mari scrise in vector.");
Console.WriteLine($"Algoritmul va afisa suma , produsul si diferenta acestora.");
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

//Suma

int[] Suma = new int[n + m];

int x, y, k;
x = n - 1;
y = m - 1;
k = 0;

while (x > -1 && y > -1)
{
    int s = v1[x] + v2[y];
    if (s > 9)
    {
        Suma[k] = s % 10 + Suma[k];
        k++;
        Suma[k] = s / 10;
    }
    else
    {
        Suma[k] = s + Suma[k];
        k++;
    }
    x--;
    y--;
}

while (x > -1)
{
    Suma[k] = v1[x];
    k++;
    x--;
}

while (y > -1)
{
    Suma[k] = v2[y];
    k++;
    y--;
}

Console.WriteLine();
Console.Write($"Suma : ");
for (int i = k - 1; i >= 0; i--)
    Console.Write($"{Suma[i]} ");
Console.WriteLine();

//Produs 

int[] ProdusFinal = new int[n * m];
int linie = 0, poz = 0;
for (int i = m - 1; i > -1; i--)
{
    int[] P = new int[n * m];
    k = 0;
    for (int j = n - 1; j > -1; j--)
    {
        int produs = v2[i] * v1[j];
        if (produs > 9)
        {
            P[k] = P[k] + produs % 10;
            k++;
            P[k] = produs / 10;
        }
        else
        {
            P[k] = P[k] + produs;
            k++;
        }
    }
    y = linie - 1;
    int z = 0;

    if (y == -1)
    {
        x = k - 1;
        while (x > -1)
        {
            ProdusFinal[z] = P[x];
            z++;
            x--;
        }
    }
    else
    {
        x = 0;
        int poz2 = poz, h = y;
        int[] ProdusPartial = new int[n * m];
        while (poz2 > 0)
        {
            ProdusPartial[z] = ProdusFinal[h];
            h--; poz2--;
            z++;
        }

        y = y - poz;


        while (x < k && y > -1)
        {
            int s = P[x] + ProdusFinal[y];
            if (s > 9)
            {
                ProdusPartial[z] = s % 10 + ProdusPartial[z];
                z++;
                ProdusPartial[z] = s / 10;
            }
            else
            {
                ProdusPartial[z] = s + ProdusPartial[z];
                z++;
            }
            x++;
            y--;
        }

        while (x < k)
        {
            ProdusPartial[z] = P[x] + ProdusPartial[z];
            z++;
            x++;
        }

        for (int r = 0; r < z; r++)
            ProdusFinal[r] = ProdusPartial[r];
    }

    poz++;
    linie = z;
}

Console.Write($"Produs: ");
for (int i = linie - 1; i >= 0; i--)
    Console.Write($"{ProdusFinal[i]} ");
Console.WriteLine();


//Diferenta
if (n > m)
{
    int[] d1 = new int[n];
    Diferenta(v1, v2, n, m, d1);


    Console.Write($"Diferenta: ");
    for (int i = d1.Length - 1; i >= 0; i--)
        Console.Write($"{d1[i]} ");
    Console.WriteLine();

}
else if (n < m)
{
    int[] d1 = new int[m];
    Diferenta(v2, v1, m, n, d1);


    Console.Write($"Diferenta: - ");
    for (int i = d1.Length - 1; i >= 0; i--)
        Console.Write($"{d1[i]} ");
    Console.WriteLine();
}
else
{
    int[] d1 = new int[m];
    int v = 0, w = 0;

    while (w < m && v < n)
    {
        if (v1[v] > v2[w])
        {
            Diferenta(v1, v2, n, m, d1);
            break;
        }
        else
        {
            Diferenta(v2, v1, m, n, d1);
            break;

        }
        v++;
        w++;
    }

    Console.Write($"Diferenta: ");
    for (int i = d1.Length - 1; i >= 0; i--)
        Console.Write($"{d1[i]} ");
    Console.WriteLine();

}

void Diferenta(int[] v1, int[] v2, int n, int m, int[] dif)
{

    int d = 0, c = n - 1;
    for (int i = m - 1; i >= 0; i--)
    {
        if (v1[c] == 0 && v2[i] != 0)
        {
            v1[c] = 10;
            if (c != 0)
                v1[c - 1] = v1[c - 1] - 1;
            dif[d++] = v1[c] - v2[i];
        }
        else if (v1[c] == 0 && v2[i] == 0)
        {
            dif[d++] = 0;
        }
        else if (v1[c] < v2[i])
        {
            v1[c] = v1[c] * 10;
            if (c != 0)
                v1[c - 1] = v1[c - 1] - 1;
            dif[d++] = v1[c] - v2[i];
        }
        else dif[d++] = v1[c] - v2[i];
        c--;
    }

    if (n != m)
    {
        int u = n - 1 - m;
        while (u >= 0)
        {
            dif[d++] = v1[u];
            u--;
        }
    }

}

