
Console.WriteLine($"Introduceti prima oara dimensiunea vectorilor , iar apoi elementele acestora.");
Console.WriteLine($"Algoritmul va afisa interclasarea acestori 2 vectori.");
Console.WriteLine();

//Citire

string line = Console.ReadLine();
string[] p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int n = int.Parse(p[0]);
int m = int.Parse(p[1]);
int[] s1 = new int[n], s2 = new int[m];

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < n; i++)
    s1[i] = int.Parse(p[i]);

line = Console.ReadLine();
p = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < m; i++)
    s2[i] = int.Parse(p[i]);

// Interclasare

int[] Interclasare = new int[n + m];
int x = 0, y = 0, z = 0;

while (x < n && y < m)
    if (s1[x] < s2[y])
        Interclasare[z++] = s1[x++];
    else
        Interclasare[z++] = s2[y++];


while (x < n)
    Interclasare[z++] = s1[x++];

while (y < m)
    Interclasare[z++] = s2[y++];

//Afisare

for (int i = 0; i < z; i++)
    Console.Write($"{Interclasare[i]} ");