
Console.WriteLine($"Introduceti prima oara dimensiunea vectorului si unn index in vectorul respectiv.");
Console.WriteLine($"Iar apoi introduceti elementele vectorului .");
Console.WriteLine($"Algoritmul va afisa elementul aflat pe indexul data dupa sortare.");
Console.WriteLine();

//Metode de sortare crescatoare si descrescatoare

void Cresc(int[] v1, int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < n; j++)
        {
            if (v1[j] < v1[min])
                min = j;
        }

        if (min != i)
        {
            int aux = v1[i];
            v1[i] = v1[min];
            v1[min] = aux;
        }
    }
}

void Descresc(int[] v2, int n)
{
    for (int j = 1; j < n; j++)
    {
        int min = -1;
        for (int k = j - 1; k > -1; k--)
        {
            if (v2[j] > v2[k])
                min = k;
        }

        if (min != -1)
        {
            int uNr = v2[j];
            for (int x = j; x > min; x--)
                v2[x] = v2[x - 1];

            v2[min] = uNr;
        }
    }
}

//Citire

string line = Console.ReadLine();
string[] p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(p[0]);
int index = int.Parse(p[1]);

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] v1 = new int[n], v2 = new int[n];

for (int i = 0; i < n; i++)
{
    v1[i] = int.Parse(p[i]);
    v2[i] = int.Parse(p[i]);
}

// determinarea si afisarea elementului dorit dupa sortare crescatoare
Cresc(v1, n);
Console.WriteLine($"Elementul aflat pe pozitia {index} dupa sortare crescatoare este : {v1[index]}");

//determinarea si afisarea elementului dorit dupa sortare descrescatoare
Descresc(v2, n);
Console.WriteLine($"Elementul aflat pe pozitia {index} dupa sortare descrescatoare este :{v2[index]}");


