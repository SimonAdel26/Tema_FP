
Console.WriteLine($"Introduceti prima oara dimensiunea vectorului , iar apoi elementele acestuia .");
Console.WriteLine($"Algoritmul va afisa vectorul sortat crescator prin metoda Insertiei.");
Console.WriteLine();

//Citire 

string line = Console.ReadLine();
int n = int.Parse(line);
line = Console.ReadLine();
int[] vector = new int[n];
int i = 0;
foreach (var nr in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
{
    vector[i++] = int.Parse(nr);
}

// Insertion Sort

for (int j = 1; j < n; j++)
{
    int min = -1;
    for (int k = j - 1; k > -1; k--)
    {
        if (vector[j] < vector[k])
            min = k;
    }

    if (min != -1)
    {
        int uNr = vector[j];
        for (int x = j; x > min; x--)
            vector[x] = vector[x - 1];

        vector[min] = uNr;
    }
}

//Afisarea vectorului sortat crescator
Console.WriteLine();
for (int j = 0; j < n; j++)
    Console.Write($"{vector[j]} ");
