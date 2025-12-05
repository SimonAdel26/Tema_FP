Console.WriteLine($"Introduceti dimensiunea vectorului , o valoare si o pozitie pe care doriti sa inserati in vector.");
Console.WriteLine($"Iar dupa ce ati introdus datele de mai sus , introduceti elementele vectorului.");
Console.WriteLine($"! Atentie ! : Primul element al vectorului se considera pe pozitia zero. ");
Console.WriteLine();

//Citire

string line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(p[0]);
int valoare = int.Parse(p[1]);
int pozitie = int.Parse(p[2]);

line = Console.ReadLine();
int[] vector = new int[n + 1];
int i = 0;
foreach (var nr in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
{
    vector[i] = int.Parse(nr);
    i++;
}

// inserarea valorii date pe poztia dorita

for (int j = n; j > pozitie; j--)
{
    vector[j] = vector[j - 1];
}

vector[pozitie] = valoare;

// Afisare

for (int j = 0; j <= n; j++)
    Console.Write($"{vector[j]} ");