
int part(int st, int dr, int[] v, int[] sort)
{
    int k = 0, poz = 0;
    for (int i = st + 1; i <= dr; i++)
        if (v[i] < v[st])
            sort[k++] = v[i];
    poz = k;
    sort[k++] = v[st];

    for (int i = st + 1; i <= dr; i++)
        if (v[i] > v[st])
            sort[k++] = v[i];
    int x = 0;
    for (int i = st; i <= dr; i++)
        v[i] = sort[x++];

    return st + poz;
}

void QuickSort(int st, int dr, int[] v, int[] sort)
{
    if (st < dr)
    {
        int poz = part(st, dr, v, sort);
        QuickSort(st, poz - 1, v, sort);
        QuickSort(poz + 1, dr, v, sort);
    }
}



Console.WriteLine($"Introduceti elementele vectorului.");
Console.WriteLine($"Algoritmul va afisa vectorul sortat crescator prin metoda QuickSort.");
Console.WriteLine();

//Citire
string line = Console.ReadLine();
string[] p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] v = new int[p.Length];
int n = 0;
foreach (var s in p)
    v[n++] = int.Parse(s);

int[] sort = new int[n];
QuickSort(0, n - 1, v, sort);


//Afisare 
Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.Write($"{v[i]} ");
