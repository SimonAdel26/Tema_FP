Console.WriteLine($"Introduceti dimeninsiunea vectorului , iar apoi elementele acestuia.");
Console.WriteLine($"Programul va afisa elementele vectorului rotite cu o pozitie spre stanga.");
Console.WriteLine();

//citire
string line = Console.ReadLine();
int n = int.Parse(line);
line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] vector = new int[n];
for (int i = 0; i < n; i++)
    vector[i] = int.Parse(p[i]);

//rotirea elementelor cu o poztitie spre stanga 

int salvare = vector[0];
for (int i = 0; i < n - 1; i++)
    vector[i] = vector[i + 1];

vector[n - 1] = salvare;

//Afisare

for (int i = 0; i < n; i++)
    Console.Write($"{vector[i]} ");