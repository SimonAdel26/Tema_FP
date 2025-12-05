
Console.WriteLine($"Introduceti prima oara dimensiunea celor 2 vectori , iar apoi elementele acestora.");
Console.WriteLine($"Algoritmul va afisa cate ori apare al doilea vector in primul vector.");
Console.WriteLine();

//Citire
string line = Console.ReadLine();
string[] part = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int n = int.Parse(part[0]);
int m = int.Parse(part[1]);

line = Console.ReadLine();
part = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int[] s = new int[n];
for (int i = 0; i < n; i++)
    s[i] = int.Parse(part[i]);

line = Console.ReadLine();
part = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int[] p = new int[m];
for (int i = 0; i < m; i++)
    p[i] = int.Parse(part[i]);

// cautare 
int Aparitie = 0;
if (m > n) Console.WriteLine($"Al doilea vector nu apare in primul vector.");
else
{
    int presupunere = 0;
    if (p[0] == p[m - 1]) presupunere = 1;

    int nrpartial = 0, pozpartial = 0;
    for (int i = 0; i < n; i++)
    {
        if (s[i] == p[pozpartial])
        {
            if (pozpartial == m - 1 && presupunere == 1)
            {
                Aparitie++;
                nrpartial = 1;
                pozpartial = 1;
            }
            else
            {
                nrpartial++;
                pozpartial++;
            }

        }
        else
        {
            pozpartial = 0;
            nrpartial = 0;
        }
    }
}

//Afisare de cate ori apare p in s 
Console.WriteLine();
Console.WriteLine($"Vectorul al doilea apare de {Aparitie} ori in primul vector.");