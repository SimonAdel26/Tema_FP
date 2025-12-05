Console.WriteLine($"Introduceti dimensiunea vectorului , iar dupa un numar k pe care doriti sa o cautati in vector.");
Console.WriteLine($"Iar dupa introduceti elementele vectorului .");
Console.WriteLine($"Daca se gaseste k in vector se va afisa pozitia aflata in vector in caz contrar se va afisa -1.");
Console.WriteLine();

//Citire
string line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(p[0]);
int k = int.Parse(p[1]);

int[] vector = new int[n];
line = Console.ReadLine();
p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
for (int j = 0; j < n; j++)
    vector[j] = int.Parse(p[j]);

//cautare binara
int stanga = 0, dreapta = n - 1, mij = 0, ok = 0;

while (stanga <= dreapta && ok == 0)
{
    mij = (stanga + dreapta) / 2;
    if (vector[mij] == k)
    {
        ok = 1;
        break;
    }
    if (vector[mij] > k)
        dreapta = mij - 1;
    else stanga = mij + 1;
}

//Afisare 

if (ok == 0)
    Console.WriteLine(-1);
else
    Console.WriteLine(mij);