
int cmmdc(int a, int b)
{
    while (b != 0)
    {
        int rest = a % b;
        a = b;
        b = rest;
    }

    return a;
}

Console.WriteLine($"Introduceti prima oara dimensiunea vectorului , iar apoi elementele acestuia .");
Console.WriteLine($"Algoritmul va afisa cel mai mare divizor comun a vectorului dat de dumneavoastra .");
Console.WriteLine();

// citire
string line = Console.ReadLine();
int n = int.Parse(line);
line = Console.ReadLine();
int[] vector = new int[n];
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < n; i++)
    vector[i] = int.Parse(p[i]);

// cmmdc a vectorului 

int CMMDC = cmmdc(vector[0], vector[1]);

for (int i = 2; i < n; i++)
    CMMDC = cmmdc(CMMDC, vector[i]);

// Afisare cmmdc 
Console.WriteLine();
Console.WriteLine($"Cel mai mare divizor comun a vectorului este : {CMMDC}");
