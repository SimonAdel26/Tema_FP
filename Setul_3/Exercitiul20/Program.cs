

Console.WriteLine($"Introduceti cele 2 siraguri de margele (able=0 si negre=1).");
Console.WriteLine($"Algoritmul va afisa numarul de suprapuneri a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.");
Console.WriteLine();

//Citire
string s1 = Console.ReadLine();
string s2 = Console.ReadLine();

int n = s1.Length;
int m = s2.Length;

if (n != m)
{
    Console.WriteLine($"Nu se suprapun cele 2 siraguri de margele.");
}
else
{
    int NrSuprapunere = 0;
    for (int i = 0; i < n; i++)
    {
        int verif = 0;
        for (int j = 0; j < n; j++)
        {
            if (s1[j] != s2[j])
            {
                verif = 1;
                break;
            }
        }

        if (verif == 0) { NrSuprapunere++; }

        char[] k = s1.ToCharArray();
        char u = k[0];
        for (int j = 0; j < n - 1; j++)
            k[j] = k[j + 1];

        k[n - 1] = u;

        s1 = new string(k);
    }

    if (NrSuprapunere > 0)
    {
        Console.WriteLine($"Cele 2 margele se suprapun de {NrSuprapunere} ori.");
    }
    else
    {
        Console.WriteLine($"Nu se suprapun cele 2 siraguri de margele.");
    }
}