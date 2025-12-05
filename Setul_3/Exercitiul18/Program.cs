
Console.WriteLine($"Introduceti prima oara gradul polinomului , punctul x in care doriti sa aflati valoarea polinomului in acel punct.");
Console.WriteLine($"Iar apoi introduceti coeficientii astfel incat cel mai putin semnificativ coeficient sa fie pe pozitia zero in vector.");
Console.WriteLine();

//Citire

string line = Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int n = int.Parse(p[0]);
int x = int.Parse(p[1]);

line = Console.ReadLine();
p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//Calcularea valorii polinomului in punctul x
long Suma = 0, Multiplicator = x;
int i = 0;

foreach (var nr in p)
{
    if (i == 0)
    {
        Suma = Suma + int.Parse(nr);
    }
    else
    {
        Suma = Suma + int.Parse(nr) * Multiplicator;
        Multiplicator = Multiplicator * x;
    }

    i++;
}

// Afisarea valorii polinomului in punctul x

Console.WriteLine();
Console.WriteLine($"In punctul {x} valoarea polinomului este {Suma}");