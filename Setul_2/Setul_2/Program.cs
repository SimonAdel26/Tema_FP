//Setul 2

//Exercitiul 1 - Cate numere sunt pare intr-o secventa de n numere
using System.Runtime.InteropServices;

void Problema1()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul o sa returneze cate numere pare este in secventa data de dumneavoastra .");
    Console.WriteLine($"! Atentie ! : La fiecare numar introdus trebuie sa apasati 'Enter' ");
    Console.WriteLine();

    //Se citeste lungimii secventei 
    string line = Console.ReadLine();
    int n = int.Parse(line), x, NrPar = 0;

    // Numararea cate numere pare sunt in secventa + Citirea elementelor 
    while (n != 0)
    {
        line = Console.ReadLine();
        x = int.Parse(line);
        if (x % 2 == 0) NrPar++;
        n--;
    }

    // Afisarea cate numere pare sunt in secventa 
    Console.WriteLine();
    Console.WriteLine($"{NrPar} numere pare sunt in secventa . ");
}

//Exercitiul 2 - Cate numere pozitive , negative si egale cu 0 sunt intr-o secventa 
void Problema2()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul o sa returneze cate numere pozitive , negative si egal cu 0 sunt in secventa data de dumneavoastra .");
    Console.WriteLine($"! Atentie ! : La fiecare numar introdus trebuie sa apasati 'Enter' ");
    Console.WriteLine();

    //Se citeste lungimea secventei

    string line = Console.ReadLine();
    int n = int.Parse(line), x, NrPozitiv = 0, NrNegativ = 0, NrZero = 0;

    //Calcularea cate numere sunt negative , pozitive sau egal cu 0 din secventa 
    while (n != 0)
    {
        line = Console.ReadLine();
        x = int.Parse(line);
        if (x < 0) NrNegativ++;
        else if (x > 0) NrPozitiv++;
        else NrZero++;
        n--;
    }

    // Afisarea variabilelor NrNegativ , NrPozitiv si NrZero
    Console.WriteLine();
    Console.WriteLine($"In secventa sunt :");
    Console.WriteLine($"- {NrNegativ} numere negative");
    Console.WriteLine($"- {NrPozitiv} numere pozitive");
    Console.WriteLine($"- {NrZero} numere egale cu 0");
}

//Exercitiul 3 - Calcularea sumei si produsul a primelor n termeni
void Problema3()
{
    Console.WriteLine($"Introduceti un numar natural pentru care algoritmul sa se calculeze suma si produsul a primelor n termeni .");
    Console.WriteLine();

    //Se citeste n 
    string line = Console.ReadLine();
    int n = int.Parse(line), Suma = 0, Produs = 1;

    //Calcularea sumei si produsul a primelor n termeni
    for (int i = 1; i <= n; i++)
    {
        Suma = Suma + i;
        Produs = Produs * i;
    }

    //Afisarea suma si produsul a primelor n termeni 

    Console.WriteLine($"Suma a primelor n termeni este {Suma}");
    Console.WriteLine($"Produsul a primelor n termeni este {Produs}");
}

//Exercitiul 4 - Afisarea pozitiei numarului cautat din secventa 
void Problema4()
{

    Console.WriteLine($"Introduceti prima oara lungimea secventei ,iar dupa un numar pe care doriti sa o cautati dupa in secventa data de dumneavoastra dupa ce ati introdus numarul.");
    Console.WriteLine($"Algoritmul o sa returneze pozitia din secventa in care se afla numarul cautat . Daca nu se afla se va returna -1 ");
    Console.WriteLine($"! Atentie ! : La fiecare numar introdus in loc de spatiu apasati 'Enter'.");
    Console.WriteLine();

    //Se citeste n si a 

    string line = Console.ReadLine();
    int n = int.Parse(line);
    line = Console.ReadLine();
    int a = int.Parse(line);

    //Verificarea daca numarul a se afla in secventa 
    int i = -1, Pozitie = -2;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        i++;
        if (x == a) Pozitie = i;
        n--;
    }

    //Afisarea pozitiei daca se afla a in secventa 
    Console.WriteLine();
    if (Pozitie != -2) Console.WriteLine($"Numarul {a} se afla pe pozitia {Pozitie} .");
    else Console.WriteLine(-1);
}

//Exercitiul 5 - Cate elemente sunt egale cu pozitie in care se afla din secvenat 
void Problema5()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa seventa.");
    Console.WriteLine($"Algoritmul o sa returneze cate elemente sunt egole cu poztia loc din secventa data de dumneavoastra.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste lungimea secventei 
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Numaram cate elemente sunt egale cu pozitia lor din secventa 
    int i = -1, EgalPoz = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        i++;
        if (x == i) EgalPoz++;
        n--;
    }

    //Afisarea numarul elementelor egale cu pozitia lor 
    Console.WriteLine();
    if (EgalPoz != 0)
        Console.WriteLine($"{EgalPoz} elemente sunt egale cu pozitia lor din seventa.");
    else
        Console.WriteLine($"Nu exista niciun elemente egal cu pozitia sa din secventa.");
}

//Exercitiul 6 - Verificare daca o secventa este in ordine crescatoare sau nu 

void Problema6()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina daca secventa este crescatoare sau nu .");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste lungimea secventei 
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Verificam si afisam daca secventa este crescatoare sau nu 
    int Anterior = 0, ok = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        if (Anterior == 0) Anterior = x;
        else if (Anterior > x)
        {
            ok = 1;
            break;
        }
        else
        {
            Anterior = x;
        }
        n--;
    }

    Console.WriteLine();
    if (ok == 0)
        Console.WriteLine($"Secventa data de dumneavoastra este in ordine crescatoare.");
    else
        Console.WriteLine($"Secventa data de dumneavoastra nu este in ordine crescatoare.");
}

//Exercitiul 7 - Determinarea valoarea cea mai mica si mai mare din secventa 

void Problema7()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina cea mai mica valoare si cea mai mare valoare din secventa data de dumneavoastra.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste lungimea secventei

    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Determinarea cea mai mica valoare si cea mai mare valoare din secventa

    int Valmin = int.MaxValue, Valmax = int.MinValue;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        if (Valmin > x) Valmin = x;
        if (Valmax < x) Valmax = x;
        n--;
    }

    //Afisarea cea mai mica valoare si cea mai mare valoare
    Console.WriteLine();
    Console.WriteLine($"Cea mai mica valoare din secventa este {Valmin}.");
    Console.WriteLine($"Cea mai mare valoare din secventa este {Valmax}.");
}

//Exercitiul 8 - Determinarea al n-lea termen din sirul lui fibonacci

void Problema8()
{
    Console.WriteLine($"Introduceti un numar natural pentru care algoritmul sa determine al n-lea termin din sirul lui fibonacci");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Determinarea al n-lea termen din sirul lui fibonacci

    int a = 0, b = 1, c = 0, nr = 2;
    while (nr != n)
    {
        c = a + b;
        a = b;
        b = c;
        nr++;
    }

    //Afsiarea al n-lea termin din sir
    Console.WriteLine();
    if (n > 2)
        Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este {c}");
    else if (n == 1)
        Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este {0}");
    else
        Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este {1}");
}

//Exercitiul 9 - Daca o secventa este monotona

void Problema9()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina daca secventa introdusa de dumneavoastra este monotona.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Verificare daca este monotona
    int Cresc = 1, Desc = 1, Anterior = -2, s = n;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);

        if (Anterior == -2)
        {
            Anterior = x;
        }
        else
        {
            if (Anterior < x) Cresc++;
            if (Anterior > x) Desc++;
            if (Anterior == x)
            {
                Cresc++;
                Desc++;
            }
            Anterior = x;
        }

        n--;
    }

    // Afisarea daca este crescator sau descrescator 
    Console.WriteLine($"Cresc={Cresc}, Desc={Desc}");
    if (Cresc == s && Cresc != Desc) Console.WriteLine($"Secventa data de dumneavoastra este monotona (crescatoare).");
    else if (Desc == s && Cresc != Desc) Console.WriteLine($"Secventa data de dumneavoastra este monotona (descrescatoare).");
    else Console.WriteLine($"Secventa data de dumneavoastra nu este monotona.");
}

//Exercitiul 10 -determinararea numarul maxim de numere consecutive egale
void Problema10()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina numarul maxim de numere consecutive egale.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    // Se citeste n 
    string line = Console.ReadLine();
    int n = int.Parse(line);

    // Determinam numarul maxim de numere consecutive egale.
    int lungCurenta = 1, lungMaxima = 0, Anterior = -2;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        if (Anterior == -2)
        {
            Anterior = x;
        }
        else
        {
            if (Anterior == x)
            {
                lungCurenta++;
            }
            else if (lungCurenta > lungMaxima)
            {
                lungMaxima = lungCurenta;
                lungCurenta = 1;
            }

            Anterior = x;
        }
        n--;
    }

    //Afisarea numarul maxim de numere sonsecutive egale

    Console.WriteLine();
    Console.WriteLine($"Numarul maxim de numere consecutive egale este {lungMaxima}");

}

//Exercitiul 11-Suma inverselor numerelor din secventa
void Problema11()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina suma inverselor numerelor din secventa data de dumneavoastra.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    // Se determina suma inverselor numerelor din secventa
    int numarator = 0, numitor = 1, inceput = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);

        if (inceput == 0)
        {
            numarator = 1;
            numitor = x;
            inceput++;
        }
        else if (inceput == 1)
        {
            numarator = numitor + x;
            numitor = numitor * x;
            inceput++;
        }
        else
        {
            numarator = x * (numarator) + numitor;
            numitor = numitor * x;
        }

        n--;
    }

    //Determinam cel mai mare divizor comun pentru simplificare
    int a = numarator, b = numitor;
    while (b != 0)
    {
        int rest = a % b;
        a = b;
        b = rest;
    }

    numarator = numarator / a;
    numitor = numitor / a;

    //Afisarea suma inverselor numerelor din secventa
    Console.WriteLine();
    Console.WriteLine($"Suma inverselor numerelor din secventa data de dumneavoastra este {numarator}/{numitor}");
}

//Exercitiul 12-Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere

void Problema12()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina cate grupuri de numere consecutive diferite de zero sunt in secventa data de dumneavoastra.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    // Se citeste n 
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Numaram cate grupuri de numere consecutive de zero sunt in secventa 
    int Numar = 0, Curent = 0;
    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        if (x != 0)
        {
            Curent++;
        }
        else if (Curent > 0)
        {
            Numar++;
            Curent = 0;
        }

        n--;
    }

    //Afisam cate grupuri de numere consecutive de zero sunt in secventa 
    Console.WriteLine();
    Console.WriteLine($"In secventa data sunt {Numar} grupuri de numere consecutive diferite de zero .");
}
//Exercitiul 13- Determinarea unei secvente daca este este o secventa crescatoare rotita

void Problema13()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina daca secventa data de dumneavoastra este o secventa crescatoare rotita sau nu.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Verificarea daca secventa este o secventa crescatoare rotita

    int Anterior = -2, verif = 0, prim = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        if (n == 1)
        {
            if (x > prim) verif++;
            if (Anterior >= x)
            {
                verif++;
            }
        }
        else if (Anterior == -2)
        {
            Anterior = x;
            if (prim == 0) prim = x;
        }
        else if (Anterior >= x)
        {
            verif++;
        }

        Anterior = x;
        n--;
    }

    //Afisam rezultatul verificarii
    Console.WriteLine();
    if (verif > 1)
        Console.WriteLine($"Secventa data de dumneavoastra nu este o secventa crescatoare rotita.");
    else
        Console.WriteLine($"Secventa data de dumneavoastra este o secventa crescatoare rotita.");
}

//Exercitiul 14 - Determinarea unei secvente daca este este o secventa monotona rotita

void Problema14()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina daca secventa data de dumneavoastra este o secventa monotona rotita sau nu.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Determinarea daca secventa data este o secventa monotona 
    // O secventa este monotona daca este crescatoare sau descrescatoare 

    int Anterior = -2, Cresc = 0, prim = 0, Desc = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);
        if (n == 1)
        {
            if (x > prim) Desc++;
            if (x < prim) Cresc++;

            if (Anterior >= x)
            {
                Desc++;
            }
            else
            {
                Cresc++;
            }
        }
        else
        if (Anterior == -2)
        {
            Anterior = x;
            if (prim == 0) prim = x;
        }
        else if (Anterior >= x)
        {
            Desc++;
        }
        else
        {
            Cresc++;
        }

        Anterior = x;
        n--;
    }

    //Afisam rezultatul verificarii
    Console.WriteLine();
    if (Cresc <= 1)
        Console.WriteLine($"Secventa data de dumneavoastra este o secventa monotona rotita.");
    else if (Desc <= 1)
        Console.WriteLine($"Secventa data de dumneavoastra este o secventa monotona rotita.");
    else
        Console.WriteLine($"Secventa data de dumneavoastra nu este o secventa monotona rotita.");

}
//Exercitiul 15 - Determinarea unei secvente daca este secventa bitonica
void Problema15()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina daca secventa data de dumneavoastra este o secventa bitonica sau nu.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Verificarea daca o secventa este bionica
    int anterior = -2, cresc = 0, desc = 0, ok = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);

        if (anterior == -2) anterior = x;
        else if (anterior <= x && desc == 0)
        {
            cresc++;
        }
        else if (anterior >= x && cresc > 0)
        {
            desc++;
        }
        else
        {
            ok = 1;
        }

        anterior = x;
        n--;
    }

    //Afisrea rezultatului verificarii 

    if (ok == 1)
        Console.WriteLine($"Secventa data de dumneavoastra nu este o secventa bitonica.");
    else
        Console.WriteLine($"Secventa data de dumneavoastra  este o secventa bitonica.");
}
//Exercitiul 16 - determinarea unei secventa daca este o secventa bitonica rotita

void Problema16()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa .");
    Console.WriteLine($"Algoritmul determina daca secventa data de dumneavoastra este o secventa bitonica rotita sau nu.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Verificarea daca o secventa este bionica
    int anterior = -2, cresc = 0, verif = 0, desc = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);

        if (anterior == -2) anterior = x;
        else if (anterior <= x && verif != 2)
        {
            cresc++;
            if (verif == 0) verif = 1;
        }
        else if (anterior >= x)
        {
            desc++;
            if (verif == 1) verif = 2;
        }
        else
        {
            verif++;
        }

        anterior = x;
        n--;
    }

    //Afisrea rezultatului verificarii 
    Console.WriteLine();
    if (verif > 2)
        Console.WriteLine($"Secventa data de dumneavoastra nu este o secventa bitonica rotita.");
    else
        Console.WriteLine($"Secventa data de dumneavoastra  este o secventa bitonica rotita.");
}

//Exercitiul 17 - determinarea unei secvente daca reprezinta o secventa de paranteze corecta

void Problema17()
{
    Console.WriteLine($"Introduceti prima oara lungimea secventei , iar dupa secventa de 0 si 1.");
    Console.WriteLine($"Algoritmul determina daca secventa introdusa de dumneavoastra reprezinta o secventa de paranteze corecta sau nu.");
    Console.WriteLine($"! Atentie !: La fiacare numar introdus in loc de spatiu apasati 'Enter'");
    Console.WriteLine();

    //Se citeste n
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Verificarea daca fiecare paranteza deshisa este inchisa si invers 
    int deschis = 0, prim = -1, ok = 0;

    while (n != 0)
    {
        line = Console.ReadLine();
        int x = int.Parse(line);

        if (prim == -1)
        {
            prim = x;
            if (x == 0) deschis++;
            else
            {
                ok = 1;
                break;
            }
        }
        else if (x == 0)
        {
            deschis++;
        }
        else if (x == 1 && deschis > 0)
        {
            deschis--;
        }
        else
        {
            ok = 1;
            break;
        }

        n--;
    }

    //Afisamm rezultatul verificarii 
    Console.WriteLine();
    if (ok == 1 || (ok == 0 && deschis > 0))
        Console.WriteLine($"Secventa data de dumneavoastra nu este o secventa de paranteze corecta.");
    else
        Console.WriteLine($"Secventa data de dumneavoastra este o secventa de paranteze corecta.");
}