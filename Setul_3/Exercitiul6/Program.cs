Console.WriteLine($"Introduceti dimensiunea vectorului si o pozitie a unui element pe care doriti sa o stergeti din vector.");
Console.WriteLine($"Iar apoi introduceti elementele vectorului.");
Console.WriteLine($" ! Atentie ! : Primul element al vectorului se considera pe pozitia zero. ");
Console.WriteLine();

//Citire

string line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(p[0]);
int pozitie = int.Parse(p[1]);

line = Console.ReadLine();

int[] vector = new int[n];
int i = 0;
foreach (var nr in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
{
    vector[i] = int.Parse(nr);
    i++;
}

// stergerea elementului pe pozitia dorita

for (int j = pozitie; j < n - 1; j++)
    vector[j] = vector[j + 1];

// Afisare

for (int j = 0; j < n - 1; j++)
    Console.Write($"{vector[j]} ");