Console.WriteLine($"Introduceti dimensiunea vectorului , iar apoi elementele acestuia.");
Console.WriteLine($"Algoritmul va afisa vectorul cu elementele inversate (primul element => ultimul element etc)");
Console.WriteLine();

//Citire

string line = Console.ReadLine();
int n = int.Parse(line);
line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int[] vector = new int[n];

for (int i = 0; i < n; i++)
{
    vector[i] = int.Parse(p[i]);
}

//inversare a elementelor 

for (int i = 0; i < n / 2; i++)
{
    int aux = vector[i];
    vector[i] = vector[n - i - 1];
    vector[n - i - 1] = aux;
}

//Afisare

for (int i = 0; i < n; i++)
    Console.Write($"{vector[i]} ");
