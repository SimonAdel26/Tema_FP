
Console.WriteLine($"Introduceti prima numarul in baza 10 si baza in care doriti sa convertiti . ");

// Metoda - convertirea din baza 10 in baza 2,3,4,...,9

int convert_din_10(int n, int b)
{
    int putere = 1, rest = 0, nr = 0;
    while (n != 0)
    {
        rest = n % b;
        nr = rest * putere + nr;
        putere = putere * 10;
        n = n / b;
    }

    return nr;
}

//Metoda - convertirea din baza 10 in baza 11,12,...,16

void convert_in_16(int n, int b2, string[] nr)
{
    string[] v = new string[6] { "A", "B", "C", "D", "E", "F" };
    nr = new string[10000000];
    int rest = 0;
    long x = 0;

    while (n != 0)
    {
        rest = n % b2;
        if (rest > 9)
        {
            if (x == 0)
            {
                nr[x] = v[rest % 10];
                x++;
            }
            else
            {

                for (long d = x; d > 0; d--)
                    nr[d] = nr[d - 1];
                x++;

                nr[0] = v[rest % 10];
            }
        }
        else
        {
            if (x == 0)
            {
                nr[x] = Convert.ToString(rest);
            }

            for (long d = x; d > 0; d--)
                nr[d] = nr[d - 1];
            x++;

            nr[0] = Convert.ToString(rest);
        }
        n = n / b2;

    }

    Console.WriteLine(string.Join("", nr));

}

//Citire 
string line=Console.ReadLine();
string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n=int.Parse(p[0]);
int b=int.Parse(p[1]);

if (b < 10) Console.WriteLine(convert_din_10(n,b));
else
{
    string[] vector = new string[10000000];
    convert_in_16(n, b, vector);
}