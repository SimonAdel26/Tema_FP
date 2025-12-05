
Console.WriteLine($"Introduceti prima oara dimensiunea vectorului , iar apoi elementele acestuia .");
Console.WriteLine($"Algoritmul va afisa pozitiile care apar cel mai mic si cel mai mare element din vector.");
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

//determinarea pozitiilor pe care apar cel mai mic si cel mai mare element 
int Valmin = int.MaxValue, Valmax = int.MinValue, PozMin = 0, PozMax = 0;

for (int j = 0; j < n; j++)
{
    if (vector[j] < Valmin)
    {
        Valmin = vector[j];
        PozMin = j;
    }
    else if (vector[j] > Valmax)
    {
        Valmax = vector[j];
        PozMax = j;
    }
}

//Afisare PozMin si PozMax
Console.WriteLine();
Console.WriteLine($"Cel mai mic element se afla pe pozitia {PozMin} , iar cel mai mare element se afla pe pozitia {PozMax}");
