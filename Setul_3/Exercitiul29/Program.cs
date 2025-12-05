
void MergeSort(int st, int dr, int[] v, int[] sort)
{
    if (st >= dr)
        return;
    else
    {
        int mij = (st + dr) / 2;
        MergeSort(st, mij, v, sort);
        MergeSort(mij + 1, dr, v, sort);

        int i, j, k;
        i = st;
        j = mij + 1;
        k = 0;

        while (i <= mij && j <= dr)
            if (v[i] <= v[j])
                sort[k++] = v[i++];
            else sort[k++] = v[j++];

        while (i <= mij)
            sort[k++] = v[i++];

        while (j <= dr)
            sort[k++] = v[j++];

        for (int x = st; x <= dr; x++)
            v[x] = sort[x - st];
    }
}

Console.WriteLine($"Introduceti elementele vectorului.");
Console.WriteLine($"Algoritmul va afisa vectorul sortat crescator prin metoda MergeSort.");
Console.WriteLine();

//Citire

string line = Console.ReadLine();
string[] p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] v = new int[p.Length];
int n = 0;
foreach (var s in p)
    v[n++] = int.Parse(s);

int[] sort = new int[n];
MergeSort(0, n - 1, v, sort);

//Afisare 
Console.WriteLine();
for (int i = 0; i < n; i++)
    Console.Write($"{v[i]} ");

