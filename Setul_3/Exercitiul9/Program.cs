Console.WriteLine($"Introduceti dimensiunea vectorului , iar o valoare k , in care doriti sa fie rotita elementele vectorului cu k pozitii spre stanga.");
Console.WriteLine($"Iar apoi sa introduceti elementele vectorului.");
Console.WriteLine();

//Citire 
string line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(p[0]);
int k = int.Parse(p[1]);

line = Console.ReadLine();
p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] vector = new int[n];
int i = 0;
foreach (var nr in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
{
    vector[i] = int.Parse(nr);
    i++;
}

// rotirea elementelor cu k pozitii spre stanga 

for (int j = 1; j <= k; j++)
{
    int salvare = vector[0];
    for (int l = 0; l < n - 1; l++)
        vector[l] = vector[l + 1];

    vector[n - 1] = salvare;
}

//Afisare 

for (int j = 0; j < n; j++)
    Console.Write($"{vector[j]} ");