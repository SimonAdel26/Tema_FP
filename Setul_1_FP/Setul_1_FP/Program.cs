// Laborator - Setul 1 

// Exercitiul 1 - Sa se calculeze ecuatia de gradul I : ax+b=0;

using System;
using System.Security.AccessControl;

void Exercitiul1()
{
    Console.WriteLine($"Introduceti valorile a si b pentru a se putea calcula ecuatia de gradul I . ");
    Console.WriteLine($"Pentru valori cu fractii sa introduceti caracterul '/' si pentru cei radicali sa intraduceti caracterul 'r' De exemplu : 2/3 , r5 , r2/3 , 6r2.");

    int a = 0, b = 0;
    string line = Console.ReadLine();
    string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    #region Intreg
    // calcularea ecautiei de gradul I pentru a si b apartinand a multimi Z

    if (int.TryParse(p[0], out a) && int.TryParse(p[1], out b))
    {
        if (((-1) * b) % a == 0)
        {
            double x = ((-1) * b) / a;
            Console.WriteLine($"x = {x}");
        }
        else
        {
            int numarator, numitor;
            numarator = ((-1) * b);
            numitor = a;
            Console.WriteLine($"x = {numarator} / {numitor}");
        }


    }
    #endregion

    #region Dublu_Radical/Numar
    //Calcularea ecuatiei de gradul I cand a si b sunt numere de forma radical/numar

    if ((p[0].IndexOf('r') != -1 && p[0].IndexOf('/') != -1) && (p[1].IndexOf('r') != -1 && p[1].IndexOf("/") != -1))
    {
        int n1=0, m1=0,n2=0,m2=0, a1 = 0, a2 = 0,a3=0, b1 = 0, b2 = 0,b3=0, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n1 = p[0].IndexOf('r');
        m1 = p[0].IndexOf('/');

        n2 = p[1].IndexOf('r');
        m2 = p[1].IndexOf('/');

        if(n1==0 && n2==0)
        {
            for (int i = n1 + 1; i < p[0].Length; i++)
            {
                if (i < m1)
                {
                    a1 = a1 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m1)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            for (int i = n2 + 1; i < p[1].Length; i++)
            {
                if (i < m2)
                {
                    b1 = b1 * 10 + int.Parse(p[1][i].ToString());
                }

                if (i > m2)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }
            }
            if (ok == 0)
                Console.WriteLine($"x = - {a2}r{b1 * a1}/{b2 * a1}");
            else
                Console.WriteLine($"x = {a2}r{b1 * a1}/{b2 * a1}");
        }
        else if(n1==0 && n2!=0)
        {
            for (int i = n1 + 1; i < p[0].Length; i++)
            {
                if (i < m1)
                {
                    a1 = a1 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m1)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            for (int i = 0; i < n2; i++)
            {
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());
            }

            for (int i = n2 + 1; i < p[1].Length; i++)
            {
                if (i < m2)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }

                if (i > m2)
                {
                    b3 = b3 * 10 + int.Parse(p[1][i].ToString());
                }
            }

            int numarator = b1 * a2;
            int NumaratorPartial = b2 * a1;

            double rad=Math.Sqrt(NumaratorPartial);

            if(ok==0)
            {
                if(rad*rad==NumaratorPartial)
                {
                    if((numarator%a1==0 && numarator%b3==0) || ((numarator / b3) % a1 == 0 && numarator % b3 == 0))
                    {
                        Console.WriteLine($"x = -{numarator/a1/b3*rad}");
                    }
                    else if ((numarator % a1 != 0 && numarator % b3 == 0) || ((numarator / b3) % a1 != 0 && numarator % b3 == 0))
                    {
                        Console.WriteLine($"x = -{numarator /b3*rad} / {a1}");
                    }
                    else if ((numarator % a1 == 0 && numarator % b3 != 0) || (numarator % a1 == 0 && (numarator / a1) % b3 != 0))
                    {
                        Console.WriteLine($"x = -{numarator/a1*rad} / {b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad / b3) % a1 == 0 && (rad / a1) % b3 == 0)
                    {
                        Console.WriteLine($"x = -{numarator}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad / b3) % a1 != 0 && (rad / a1) % b3 == 0)
                    {
                        Console.WriteLine($"x = -{numarator}/{a1}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad / b3) % a1 == 0 && (rad / a1) % b3 != 0)
                    {
                        Console.WriteLine($"x = -{numarator}/{b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad / b3) % a1 != 0 && rad % b3 == 0)
                    {
                        Console.WriteLine($"x = -{numarator}/{a1}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 == 0 && (rad / a1) % b3 != 0)
                    {
                        Console.WriteLine($"x = -{numarator}/{b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 != 0 && rad % b3 == 0)
                    {
                        Console.WriteLine($"x = -{numarator*rad/b3}/{a1}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 == 0 && rad % b3 != 0)
                    {
                        Console.WriteLine($"x = -{numarator*rad/a1}/ {b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 != 0 && rad % b3 != 0)
                    {
                        Console.WriteLine($"x = -{numarator*rad}/{b3*a1}");
                    }
                }
                else
                {
                    if (numarator % a1 == 0 && numarator % b3 == 0)
                    {
                        Console.WriteLine($"x = -{numarator / a1 / b3} r{NumaratorPartial}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 == 0)
                    {
                        Console.WriteLine($"x = -{numarator / b3} r{NumaratorPartial} / {a1}");
                    }
                    else if (numarator % a1 == 0 && numarator % b3 != 0)
                    {
                        Console.WriteLine($"x = -{numarator / a1 } r{NumaratorPartial} / {b3}");
                    }
                    else
                    {
                        Console.WriteLine($"x = -{numarator} r{NumaratorPartial} / {b3*a1}");
                    }
                }
            }
            else
            {
                if (rad * rad == NumaratorPartial)
                {
                    if ((numarator % a1 == 0 && (numarator/a1) % b3 == 0) || ((numarator/b3) % a1 == 0 && numarator% b3 == 0))
                    {
                        Console.WriteLine($"x = {numarator / a1 / b3 * rad}");
                    }
                    else if ((numarator % a1 != 0 && numarator % b3 == 0)|| ((numarator / b3) % a1 != 0 && numarator % b3 == 0))
                    {
                        Console.WriteLine($"x = {numarator / b3 * rad} / {a1}");
                    }
                    else if ((numarator % a1 == 0 && numarator % b3 != 0) || (numarator % a1 == 0 && (numarator / a1) % b3 != 0))
                    {
                        Console.WriteLine($"x = {numarator / a1 * rad} / {b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad/b3) % a1 == 0 && (rad/a1) % b3 == 0)
                    {
                        Console.WriteLine($"x = {numarator}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad / b3) % a1 != 0 && (rad / a1) % b3 == 0)
                    {
                        Console.WriteLine($"x = {numarator}/{a1}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad / b3) % a1 == 0 && (rad / a1) % b3 != 0)
                    {
                        Console.WriteLine($"x = {numarator}/{b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && (rad / b3) % a1 != 0 && rad % b3 == 0)
                    {
                        Console.WriteLine($"x = {numarator}/{a1}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 == 0 && (rad / a1) % b3 != 0)
                    {
                        Console.WriteLine($"x = {numarator}/{b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 != 0 && rad % b3 == 0)
                    {
                        Console.WriteLine($"x = {numarator * rad / b3}/{a1}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 == 0 && rad % b3 != 0)
                    {
                        Console.WriteLine($"x = {numarator * rad / a1}/ {b3}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 != 0 && rad % a1 != 0 && rad % b3 != 0)
                    {
                        Console.WriteLine($"x = {numarator * rad}/{b3 * a1}");
                    }
                }
                else
                {
                    if (numarator % a1 == 0 && numarator % b3 == 0)
                    {
                        Console.WriteLine($"x ={numarator / a1 / b3} r{NumaratorPartial}");
                    }
                    else if (numarator % a1 != 0 && numarator % b3 == 0)
                    {
                        Console.WriteLine($"x = {numarator / b3} r{NumaratorPartial} / {a1}");
                    }
                    else if (numarator % a1 == 0 && numarator % b3 != 0)
                    {
                        Console.WriteLine($"x = {numarator / a1} r{NumaratorPartial} / {b3}");
                    }
                    else
                    {
                        Console.WriteLine($"x = {numarator} r{NumaratorPartial} / {b3 * a1}");
                    }
                }
            }

        }
        else if(n1!=0 && n2==0)
        {
            for (int i = 0; i < n1; i++)
            {
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());
            }

            for (int i = n1 + 1; i < p[0].Length; i++)
            {
                if (i < m1)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m1)
                {
                    a3 = a3 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            for (int i = n2+1; i < p[1].Length; i++)
            {
                if (i < m2)
                    b1 = b1 * 10 + int.Parse(p[1][i].ToString());

                if (i > m2)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }
            }

            int numarator = a3;
            int NumaratorPartial = b1 * a2;
            double rad = Math.Sqrt(NumaratorPartial);

            if(ok==0)
            {
                if(rad*rad==NumaratorPartial)
                {

                    if (numarator % a1 == 0) { numarator = numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }
                    if (numarator % b2 == 0) { numarator = numarator / b2; b2 = 1; }
                    if (rad % a1 == 0 && a1 != 1) { rad =rad / a1; a1 = 1; }
                    if (rad % a2 == 0 && a2 != 1) { rad = rad / a2; a2 = 1; }
                    if (rad % b2 == 0 && b2 != 1) { rad = rad / b2; b2 = 1; }

                    if(a1==1 && a2==1 && b2==1)
                    {
                        Console.WriteLine($"x = -{numarator*rad}");
                    }
                    else
                    {
                        Console.WriteLine($"x = -{numarator*rad}/{a1*a2*b2}");
                    }

                }
                else
                {
                    if (numarator % a1 == 0) { numarator = numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }
                    if (numarator % b2 == 0) { numarator = numarator / b2; b2 = 1; }

                    if (a1 == 1 && a2 == 1 && b2 == 1)
                    {
                        Console.WriteLine($"x = -{numarator} r{NumaratorPartial} ");
                    }
                    else
                    {
                        Console.WriteLine($"x = -{numarator} r{NumaratorPartial}/{a1 * a2 * b2}");
                    }
                }
            }
            else
            {
                if (rad * rad == NumaratorPartial)
                {

                    if (numarator % a1 == 0) { numarator = numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }
                    if (numarator % b2 == 0) { numarator = numarator / b2; b2 = 1; }
                    if (rad % a1 == 0 && a1 != 1) { rad = rad / a1; a1 = 1; }
                    if (rad % a2 == 0 && a2 != 1) { rad = rad / a2; a2 = 1; }
                    if (rad % b2 == 0 && b2 != 1) { rad = rad / b2; b2 = 1; }

                    if (a1 == 1 && a2 == 1 && b2 == 1)
                    {
                        Console.WriteLine($"x = {numarator * rad}");
                    }
                    else
                    {
                        Console.WriteLine($"x = {numarator * rad}/{a1 * a2 * b2}");
                    }

                }
                else
                {
                    if (numarator % a1 == 0) { numarator = numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }
                    if (numarator % b2 == 0) { numarator = numarator / b2; b2 = 1; }

                    if (a1 == 1 && a2 == 1 && b2 == 1)
                    {
                        Console.WriteLine($"x = {numarator} r{NumaratorPartial} ");
                    }
                    else
                    {
                        Console.WriteLine($"x = {numarator} r{NumaratorPartial}/{a1 * a2 * b2}");
                    }
                }
            }

        }
        else
        {
            for (int i = 0; i < n1; i++)
            {
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());
            }

            for (int i = n1 + 1; i < p[0].Length; i++)
            {
                if (i < m1)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m1)
                {
                    a3 = a3 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            for (int i = 0; i < n2; i++)
            {
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());
            }

            for (int i = n2 + 1; i < p[1].Length; i++)
            {
                if (i < m2)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }

                if (i > m2)
                {
                    b3 = b3 * 10 + int.Parse(p[1][i].ToString());
                }
            }

            int numarator = b1 * a3;
            int NumaratorPartial = b2 * a2;
            double rad=Math.Sqrt(NumaratorPartial);

            if(ok==0)
            {
                if(rad*rad==NumaratorPartial)
                {
                    if(numarator%b3==0) { numarator = numarator / b3;b3 = 1; }
                    if(numarator%a1==0) { numarator= numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }
                    if(rad%b3==0 && b3!=1) { rad = rad / b3;b3 = 1; }
                    if (rad % a1 == 0 && a1 != 1) { rad = rad / a1; a1 = 1; }
                    if (rad % a2 == 0 && a2 != 1) { rad = rad / a2; a2 = 1; }

                    if(a1!=1 && a2!=1 && b3!=1)
                    {
                        Console.WriteLine($"x = {(-1)*numarator*rad}");
                    }
                    else
                    {
                        Console.WriteLine($"x = {(-1)*numarator*rad}/{a1*a2*b3}");
                    }
                }
                else
                {
                    if (numarator % b3 == 0) { numarator = numarator / b3; b3 = 1; }
                    if (numarator % a1 == 0) { numarator = numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }

                    if (a1 != 1 && a2 != 1 && b3 != 1)
                    {
                        Console.WriteLine($"x = {(-1) * numarator} r{NumaratorPartial}");
                    }
                    else
                    {
                        Console.WriteLine($"x = {(-1) * numarator} r{NumaratorPartial}/{a1 * a2 * b3}");
                    }
                }
            }
            else
            {
                if (rad * rad == NumaratorPartial)
                {
                    if (numarator % b3 == 0) { numarator = numarator / b3; b3 = 1; }
                    if (numarator % a1 == 0) { numarator = numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }
                    if (rad % b3 == 0 && b3 != 1) { rad = rad / b3; b3 = 1; }
                    if (rad % a1 == 0 && a1 != 1) { rad = rad / a1; a1 = 1; }
                    if (rad % a2 == 0 && a2 != 1) { rad = rad / a2; a2 = 1; }

                    if (a1 != 1 && a2 != 1 && b3 != 1)
                    {
                        Console.WriteLine($"x = {(-1) * numarator * rad}");
                    }
                    else
                    {
                        Console.WriteLine($"x = {(-1) * numarator * rad}/{a1 * a2 * b3}");
                    }
                }
                else
                {
                    if (numarator % b3 == 0) { numarator = numarator / b3; b3 = 1; }
                    if (numarator % a1 == 0) { numarator = numarator / a1; a1 = 1; }
                    if (numarator % a2 == 0) { numarator = numarator / a2; a2 = 1; }

                    if (a1 != 1 && a2 != 1 && b3 != 1)
                    {
                        Console.WriteLine($"x = { numarator} r{NumaratorPartial}");
                    }
                    else
                    {
                        Console.WriteLine($"x = { numarator} r{NumaratorPartial}/{a1 * a2 * b3}");
                    }
                }
            }

        }


    }

    #endregion

    #region Radical/Numar_NrInterg
    //Calcularea ecuatiei de gradul I cand a este radical/numar si b este un numar intreg
    if ((p[0].IndexOf('r') != -1 && p[0].IndexOf('/') != -1) && (p[1].IndexOf('r') == -1 && p[1].IndexOf("/") == -1))
    {
        b = int.Parse(p[1]);
        int n, m, a1 = 0, a2 = 0,a3=0, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('r');
        m = p[0].IndexOf('/');

        if(n==0)
        {
            for (int i = n + 1; i < p[0].Length; i++)
            {
                if (i < m)
                {
                    a1 = a1 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            int numarator = b * a2;
            if (ok == 0)
            {
                if (numarator % a1 == 0)
                {
                    Console.WriteLine($"x = - {numarator / a1}r{a1}");
                }
                else
                {
                    Console.WriteLine($"x = - {numarator}r{a1}/{a1}");
                }
            }
            else
            {
                if (numarator % a1 == 0)
                {
                    Console.WriteLine($"x = {numarator / a1}r{a1}");
                }
                else
                {
                    Console.WriteLine($"x = {numarator}r{a1}/{a1}");
                }
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());
            }

            for (int i = n + 1; i < p[0].Length; i++)
            {
                if (i < m)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m)
                {
                    a3 = a3 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            int numarator = b *a3;
            if(ok==0)
            {
                if(numarator%a1 == 0 && numarator%a2==0)
                {
                    Console.WriteLine($"x = -{numarator/a1/a2}r{a2}");
                }
                else if (numarator % a1 == 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = -{numarator / a1}r{a2} / {a2}");
                }
                else if (numarator % a1 != 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = -{numarator / a2}r{a2} / {a1}");
                }
                else
                {
                    Console.WriteLine($"x = -{numarator}r{a2}/{a1*a2}");
                }

            }
            else
            {
                if (numarator % a1 == 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = {numarator / a1 / a2}r{a2}");
                }
                else if (numarator % a1 == 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = {numarator / a1}r{a2} / {a2}");
                }
                else if (numarator % a1 != 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = {numarator / a2}r{a2} / {a1}");
                }
                else
                {
                    Console.WriteLine($"x = {numarator}r{a2}/{a1 * a2}");
                }
            }
        }

    }

    // Calcularea ecuatiei de gradul I cand a este un numar intreg si b este radical/numar

    if ((p[0].IndexOf('r') == -1 && p[0].IndexOf('/') == -1) && (p[1].IndexOf('r') != -1 && p[1].IndexOf("/") != -1))
    {
        a = int.Parse(p[0]);
        int n, m, b1 = 0, b2 = 0,b3=0, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[1].IndexOf('r');
        m = p[1].IndexOf('/');

        if(n==0)
        {
            for (int i = n + 1; i < p[1].Length; i++)
            {
                if (i < m)
                {
                    b1 = b1 * 10 + int.Parse(p[1][i].ToString());
                }

                if (i > m)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }
            }
            if (ok == 0)
                Console.WriteLine($"x = - r{b1}/{b2 * a}");
            else
                Console.WriteLine($"x = r{b1}/{b2 * a}");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());
            }

            for (int i = n + 1; i < p[1].Length; i++)
            {
                if (i < m)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }

                if (i > m)
                {
                    b3 = b3 * 10 + int.Parse(p[1][i].ToString());
                }
            }

            int numarator = b1;

            if (ok == 0)
            {
                if (numarator % a == 0)
                {
                    Console.WriteLine($"x = -{numarator / a}r{b2}/{b3}");
                }
                else
                {
                    Console.WriteLine($"x = -{numarator}r{b2}/{b3 * a}");
                }
            }else
            {
                if (numarator % a == 0)
                {
                    Console.WriteLine($"x = {numarator / a}r{b2}/{b3}");
                }
                else
                {
                    Console.WriteLine($"x = {numarator}r{b2}/{b3 * a}");
                }
            }
        }

        
    }
    #endregion

    #region Radical/Numar_Fractie
    //Calcularea ecuatiei de gradul I cand a este radical/numar si b este o fractie

    if ((p[0].IndexOf('r') != -1 && p[0].IndexOf('/') != -1) && p[1].IndexOf("/") != -1)
    {
        int n, m, a1 = 0, a2 = 0,a3=0, b1 = 0, b2 = 0, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('r');
        m = p[0].IndexOf('/');

        if(n==0)
        {
            for (int i = n + 1; i < p[0].Length; i++)
            {
                if (i < m)
                {
                    a1 = a1 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            m = p[1].IndexOf('/');
            for (int i = 0; i < p[1].Length; i++)
            {
                if (i < m)
                    b1 = b1 * 10 + int.Parse(p[1][i].ToString());

                if (i > m)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }
            }

            int numarator = b1 * a2;
            if (ok == 0)
            {
                if (numarator % a1 == 0)
                    Console.WriteLine($"x = -{numarator / a1}r{a1}/{b2}");
                else
                    Console.WriteLine($"x = -{numarator}r{a1}/{b2}");
            }
            else
            {
                if (numarator % a1 == 0)
                    Console.WriteLine($"x = {numarator / a1}r{a1}/{b2}");
                else
                    Console.WriteLine($"x = {numarator}r{a1}/{b2}");
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());
            }

            for (int i = n + 1; i < p[0].Length; i++)
            {
                if (i < m)
                {
                    a2 = a2 * 10 + int.Parse(p[0][i].ToString());
                }

                if (i > m)
                {
                    a3 = a3 * 10 + int.Parse(p[0][i].ToString());
                }
            }

            m = p[1].IndexOf('/');
            for (int i = 0; i < p[1].Length; i++)
            {
                if (i < m)
                    b1 = b1 * 10 + int.Parse(p[1][i].ToString());

                if (i > m)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }
            }

            int numarator = b1 * a3;
            if (ok == 0)
            {
                if (numarator % b2 == 0 && numarator % a1 == 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = -{numarator / b2 / a1 / a2}r{a2}");
                }
                else if (numarator % b2 == 0 && numarator % a1 == 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = -{numarator / b2 / a1}r{a2}/ {a2}");
                }
                else if (numarator % b2 == 0 && numarator % a1 != 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = -{numarator / b2}r{a2} / {a1 * a2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 == 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = -{numarator / a1 / a2}r{a2} / {b2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 != 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = -{numarator / a2}r{a2} / {a1 * b2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 == 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = -{numarator / a1}r{a2} / {b2 * a2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 != 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = -{numarator}r{a2} / {a1 * a2 * b2}");
                }
            }
            else
            {
                if (numarator % b2 == 0 && numarator % a1 == 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = {numarator / b2 / a1 / a2}r{a2}");
                }
                else if (numarator % b2 == 0 && numarator % a1 == 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = {numarator / b2 / a1}r{a2}/ {a2}");
                }
                else if (numarator % b2 == 0 && numarator % a1 != 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = {numarator / b2}r{a2} / {a1 * a2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 == 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = {numarator / a1 / a2}r{a2} / {b2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 != 0 && numarator % a2 == 0)
                {
                    Console.WriteLine($"x = {numarator / a2}r{a2} / {a1 * b2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 == 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = {numarator / a1}r{a2} / {b2 * a2}");
                }
                else if (numarator % b2 != 0 && numarator % a1 != 0 && numarator % a2 != 0)
                {
                    Console.WriteLine($"x = {numarator}r{a2} / {a1 * a2 * b2}");
                }
            }

        }



    }

    //Calcularea ecuatiei de gradul I cand a este o fractie si b este un numar de radical/numar

    if (p[0].IndexOf('/') != -1 && (p[1].IndexOf('r') != -1 && p[1].IndexOf("/") != -1))
    {
        int a1 = 0, a2 = 0, n, b1 = 0, b2 = 0,b3=0, m, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('/');
        for (int i = 0; i < p[0].Length; i++)
        {
            if (i < n)
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());

            if (i > n)
            {
                a2 = a2 * 10 + int.Parse(p[0][i].ToString());
            }
        }

        n = p[1].IndexOf('r');
        m = p[1].IndexOf('/');

        if(n==0)
        {
            for (int i = n + 1; i < p[1].Length; i++)
            {
                if (i < m)
                {
                    b1 = b1 * 10 + int.Parse(p[1][i].ToString());
                }

                if (i > m)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }
            }
            if (ok == 0)
            {
                if ((a1 * b2) % a2 == 0)
                    Console.WriteLine($"x = - r{b1}/{(a1 * b2) / a2}");
                else
                    Console.WriteLine($"x = - {a2}r{b1}/{a1 * b2}");
            }
            else
            {
                if ((a1 * b2) % a2 == 0)
                    Console.WriteLine($"x = r{b1}/{(a1 * b2) / a2}");
                else
                    Console.WriteLine($"x = {a2}r{b1}/{a1 * b2}");
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());
            }

            for(int i = n + 1; i < p[1].Length; i++)
            {
                if (i < m)
                {
                    b2 = b2 * 10 + int.Parse(p[1][i].ToString());
                }

                if (i > m)
                {
                    b3 = b3 * 10 + int.Parse(p[1][i].ToString());
                }
            }

            int numarator = b1 * a2;
            if (ok == 0)
            {
                if (numarator % b3 == 0 && numarator % a1 == 0)
                {
                    Console.WriteLine($"x =- {numarator / b3 / a1}r{b2}");
                }
                else if (numarator % b3 == 0 && numarator % a1 != 0)
                {
                    Console.WriteLine($"x = -{numarator / b3}r{b2}/{a1}");
                }
                else if (numarator % b3 != 0 && numarator % a1 == 0)
                {
                    Console.WriteLine($"x = -{numarator / a1}r{b2}/{b3}");
                }
                else
                {
                    Console.WriteLine($"x = -{numarator}r{b2}/{b3 * a1}");
                }
            }
            else
            {
                if (numarator % b3 == 0 && numarator % a1 == 0)
                {
                    Console.WriteLine($"x = {numarator / b3 / a1}r{b2}");
                }
                else if (numarator % b3 == 0 && numarator % a1 != 0)
                {
                    Console.WriteLine($"x = {numarator / b3}r{b2}/{a1}");
                }
                else if (numarator % b3 != 0 && numarator % a1 == 0)
                {
                    Console.WriteLine($"x = {numarator / a1}r{b2}/{b3}");
                }
                else
                {
                    Console.WriteLine($"x = {numarator}r{b2}/{b3*a1}");
                }
            }
        }

    }
    #endregion

    #region Fractie_Nr_Irational
    //Calcularea ecuatiei de gradul I cand a este o fractie si b este un numar irational

    if (p[0].IndexOf('/') != -1 && p[1].IndexOf('r') != -1)
    {
        int a1 = 0, a2 = 0, n, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('/');
        for (int i = 0; i < p[0].Length; i++)
        {
            if (i < n)
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());

            if (i > n)
            {
                a2 = a2 * 10 + int.Parse(p[0][i].ToString());
            }
        }

        int m = p[1].IndexOf('r');

        for (int i = m + 1; i < p[1].Length; i++)
        {
            b = b * 10 + int.Parse(p[1][i].ToString());
        }

        int numarator, numitor;
        if (ok == 0)
            Console.WriteLine($"x = -{a2}r{b}/{a1}");
        else
            Console.WriteLine($"x = {a2}r{b}/{a1}");
    }

    //Calcularea ecuatiei de gradul I cand a este un numar irational si b este o fractie

    if (p[0].IndexOf('r') != -1 && p[1].IndexOf('/') != -1)
    {
        int n = p[0].IndexOf('r');
        int m = p[1].IndexOf('/');
        int ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;

        for (int i = n + 1; i < p[0].Length; i++)
        {
            a = a * 10 + int.Parse(p[0][i].ToString());
        }
        int b1 = 0, b2 = 0;

        for (int i = 0; i < p[1].Length; i++)
        {
            if (i < m)
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());

            if (i > m)
            {
                b2 = b2 * 10 + int.Parse(p[1][i].ToString());
            }
        }
        if (ok == 0)
        {
            if (b1 % a == 0)
            {
                Console.WriteLine($"x = - r{a}/{b2}");
            }
            else
            {
                Console.WriteLine($"x = - {b1}r{a}/{b2 * a}");
            }
        }
        else
        {
            if (b1 % a == 0)
            {
                Console.WriteLine($"x = r{a}/{b2}");
            }
            else
            {
                Console.WriteLine($"x = {b1}r{a}/{b2 * a}");
            }
        }

    }

    #endregion

    #region Fractii
    // Calcularea ecuatiei de gradul I cand a si b sunt fractii

    if (p[0].IndexOf('/') != -1 && p[1].IndexOf('/') != -1)
    {
        int a1 = 0, a2 = 0, n, b1 = 0, b2 = 0, m, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('/');
        m = p[1].IndexOf('/');

        for (int i = 0; i < p[0].Length; i++)
        {
            if (i < n)
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());

            if (i > n)
            {
                a2 = a2 * 10 + int.Parse(p[0][i].ToString());
            }
        }

        for (int i = 0; i < p[1].Length; i++)
        {
            if (i < m)
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());

            if (i > m)
            {
                b2 = b2 * 10 + int.Parse(p[1][i].ToString());
            }
        }

        int numarator, numitor;
        if (ok == 0)
            numarator = (-1) * a2 * b1;
        else
            numarator = a2 * b1;
        numitor = a1 * b2;
        if (numarator % numitor == 0)
            Console.WriteLine($"x = {numarator / numitor}");
        else
            Console.WriteLine($"x = {numarator} / {numitor}");

    }

    // Calcularea ecuatiei de gradul I cand a este o fractie si b este un numar intreg

    if (p[0].IndexOf('/') != -1 && (p[1].IndexOf('/') == -1 || p[1].IndexOf('r') == -1))
    {
        int a1 = 0, a2 = 0, n, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('/');
        b = int.Parse(p[1]);
        for (int i = 0; i < p[0].Length; i++)
        {
            if (i < n)
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());

            if (i > n)
            {
                a2 = a2 * 10 + int.Parse(p[0][i].ToString());
            }
        }
        int numarator, numitor;
        if (ok == 0)
            numarator = (-1) * b * a2;
        else
            numarator = b * a2;
        numitor = a1;

        if (numarator % numitor == 0)
            Console.WriteLine($"x = {numarator / numitor}");
        else
            Console.WriteLine($"x = {numarator} / {numitor}");
    }

    //Calcularea ecuatiei de gradul de I cand a este un numar intreg si b este o fractie 

    if (p[1].IndexOf('/') != -1 && (p[0].IndexOf('/') == -1 || p[0].IndexOf('r') == -1))
    {
        int b1 = 0, b2 = 0, n, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[1].IndexOf('/');
        a = int.Parse(p[0]);
        for (int i = 0; i < p[1].Length; i++)
        {
            if (i < n)
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());

            if (i > n)
            {
                b2 = b2 * 10 + int.Parse(p[1][i].ToString());
            }
        }
        int numarator, numitor;
        if (ok == 0)
            numarator = (-1) * b1;
        else
            numarator = b1;
        numitor = a * b2;

        if (numarator % numitor == 0)
            Console.WriteLine($"x = {numarator / numitor}");
        else
            Console.WriteLine($"x = {numarator} / {numitor}");


    }
    #endregion

    #region Radical
    //Calcularea ecuatiei de gradul I cand a si b sunt numere irationale (radical)

    if (p[0].IndexOf('r') != -1 && p[1].IndexOf('r') != -1)
    {
        int n, m, ok = 0,a1=0,a2=0,b1=0,b2=0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('r');
        m = p[1].IndexOf('r');

        if(n==0)
        {
            for (int i = n + 1; i < p[0].Length; i++)
            {
            a = a * 10 + int.Parse(p[0][i].ToString());
            }
        }
        else
        {
            for (int i =0; i < n; i++)
            {
                a1 = a1 * 10 + int.Parse(p[0][i].ToString());
            }

            for (int i = n + 1; i < p[0].Length; i++)
            {
                a2 = a2 * 10 + int.Parse(p[0][i].ToString());
            }
        }


        if (m == 0)
        {
            for (int i = m + 1; i < p[1].Length; i++)
            {
                b = b * 10 + int.Parse(p[1][i].ToString());
            }
        }
        else
        {
            for (int i = 0; i < m; i++)
            {
                b1 = b1 * 10 + int.Parse(p[1][i].ToString());
            }
            for (int i = m + 1; i < p[1].Length; i++)
            {
                b2 = b2 * 10 + int.Parse(p[1][i].ToString());
            }
        }

        if (m == 0 && n == 0)
        {
            int numarator, numitor;
            numarator = a * b;
            numitor = a;
            double rad = Math.Sqrt(numarator);

            if (ok == 0)
            {
                if (rad * rad == numarator)
                {
                    if (rad % numitor == 0)
                        Console.WriteLine($"x = {(-1) * rad / numitor}");
                    else
                        Console.WriteLine($"x = -{rad}/{numitor}");
                }
                else
                {
                    Console.WriteLine($"x = -r{numarator}/{numitor}");
                }
            }
            else
            {
                if (rad * rad == numarator)
                {
                    if (rad % numitor == 0)
                        Console.WriteLine($"x = {rad / numitor}");
                    else
                        Console.WriteLine($"x = {rad}/{numitor}");
                }
                else
                {
                    Console.WriteLine($"x = r{numarator}/{numitor}");
                }
            }
        }
        else if(m!=0 && n==0)
        {
            int numaratorPartial = a * b2;
            double rad=Math.Sqrt(numaratorPartial);

            if(rad*rad==numaratorPartial)
            {
                int numarator = numaratorPartial * b1;
                if(numarator%a==0)
                {
                    Console.WriteLine($"x = {numarator/a}");
                }
                else
                {
                    Console.WriteLine($"x = {numarator}/{a}");
                }
            }
            else
            {
                Console.WriteLine($"x = r{numaratorPartial*b1}/{a}");
            }
        }
        else if(m==0 && n!=0)
        {
            int numaratorPartial = a2 * b;
            double rad = Math.Sqrt(numaratorPartial);

            if (rad * rad == numaratorPartial)
            {
                if (rad % a1 == 0)
                {
                    Console.WriteLine($"x = {rad / a1}/{a2}");
                }
                else if (rad % a2 == 0)
                {
                    Console.WriteLine($"x = {rad / a2}/{a1}");
                }
                else
                {
                    Console.WriteLine($"x = {rad}/{a1 * a2}");
                }
            }
            else
            {
                Console.WriteLine($"x = r{numaratorPartial}/{a1*a2}");
            }
        }
        else
        {
            int numaratorPartial = a2 * b2;
            double rad = Math.Sqrt(numaratorPartial);

            if (rad * rad == numaratorPartial)
            {
                int numarator=numaratorPartial * b1;
                if (numarator % a1 == 0)
                {
                    Console.WriteLine($"x = {numarator / a} / {a2}");
                }
                else if(numarator % a2 == 0)    
                {
                    Console.WriteLine($"x = {rad /a2}/{a1}");
                }
                else if(numarator%a1==0 &&  numarator%a2==0)
                {
                    Console.WriteLine($"x = {numarator/a1/a2}");
                }
                else
                {
                    Console.WriteLine($"x = {numarator}/{a1*a2}");
                }
            }
            else
            {
                Console.WriteLine($"x = {b1}r{numaratorPartial}/{a1 * a2}");
            }
        }

    }

    //Calcularea ecuatiei de gradul I cand a este un numar irational si b este un numar intreg

    if (p[0].IndexOf('r') != -1 && (p[1].IndexOf('/') == -1 || p[1].IndexOf('r') == -1))
    {
        int n, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[0].IndexOf('r');
        b = int.Parse(p[1]);

        for (int i = n + 1; i < p[0].Length; i++)
        {
            a = a * 10 + int.Parse(p[0][i].ToString());
        }

        // a este numitorul si b este numaratorul
        if (ok == 0)
            Console.WriteLine($"x = {(-1) * b} * r{a}/{a}");
        else
            Console.WriteLine($"x = {b} * r{a}/{a}");
    }

    // Calcularea ecuatiei de gradul I cand a este un numar intreg si b este un numar irational

    if (p[1].IndexOf('r') != -1 && (p[0].IndexOf('/') == -1 || p[0].IndexOf('r') == -1))
    {
        int n, ok = 0;
        if (p[0][0] == '-' || p[1][0] == '-') ok = 1;
        n = p[1].IndexOf('r');
        a = int.Parse(p[b]);

        for (int i = n + 1; i < p[1].Length; i++)
        {
            b = b * 10 + int.Parse(p[1][i].ToString());
        }

        // a este numitorul si b este numaratorul
        if (ok == 0)
            Console.WriteLine($"x = - r{b}/{a}");
        else
            Console.WriteLine($"x = r{b}/{a}");
    }
    #endregion

}
// Execitiul 2 - Calcularea ecuatiei de gradul 2 
void Exercitiul2()
{
    Console.WriteLine($"Introduceti 3 numere intregi pentru a calcula ecuatia de gradul 2 : ax^2+bx+c=0");
    int a, b, c, Verif = 0;
    string line = Console.ReadLine();
    string[] p = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);
    c = int.Parse(p[2]);

    if (a < 0) Verif = 1;

    int Delta = (b * b) - 4 * a * c;

    if (Delta < 0)
    {
        Delta = Delta * (-1);
        double rad = Math.Sqrt(Delta);
        if (rad * rad == Delta)
        {
            Console.WriteLine($"x1 = {(-1) * b} - {rad}i/{2 * a} , x2 = {(-1) * b} + {rad}i/{2 * a}");
        }
        else
        {
            Console.WriteLine($"x1 = {(-1) * b} - {Delta}i/{2 * a} , x2 = {(-1) * b} + {Delta}i/{2 * a}");
        }
    }
    else
    if (Delta == 0)
    {
        int ok1 = 0, ok2 = 0;
        if (b % 2 == 0)
        {
            b = b / 2;
            ok1 = 1;
        }
        if (b % a == 0)
        {
            b = b / a;
            ok2 = 1;
        }
        if (Verif == 0)
        {
            if (ok1 != 0 && ok2 != 0)
                Console.WriteLine($"x = {(-1) * b}");
            else if (ok1 == 0 && ok2 == 0)
                Console.WriteLine($"x = {(-1) * b}/{2 * a}");
            else if (ok1 == 1 && ok2 == 0)
                Console.WriteLine($"x = {(-1) * b}/{a}");
            else
                Console.WriteLine($"x = {(-1) * b}/{2}");
        }
        else
        {
            if (ok1 != 0 && ok2 != 0)
                Console.WriteLine($"x = {b}");
            else if (ok1 == 0 && ok2 == 0)
                Console.WriteLine($"x = {(-1) * b}/{2 * a}");
            else if (ok1 == 1 && ok2 == 0)
                Console.WriteLine($"x = {(-1) * b}/{a}");
            else
                Console.WriteLine($"x = {(-1) * b}/{2}");
        }
    }
    else
    {
        double rad = Math.Sqrt(Delta);
        if (rad * rad == Delta)
        {
            double numarator1 = (-1) * b - rad;
            double numarator2 = (-1) * b + rad;

            int ok1 = 0, ok2 = 0, ok3 = 0, ok4 = 0;
            if (numarator1 % 2 == 0)
            {
                numarator1 = numarator1 / 2;
                ok1 = 1;
            }
            if (numarator1 % a == 0)
            {
                numarator1 = numarator1 / a;
                ok2 = 1;
            }
            if (numarator2 % 2 == 0)
            {
                numarator2 = numarator2 / 2;
                ok3 = 1;
            }
            if (numarator2 % a == 0)
            {
                numarator2 = numarator2 / a;
                ok4 = 1;
            }

            if ((ok1 == 1 && ok2 == 1) && (ok3 == 1 && ok4 == 1))
            {
                Console.WriteLine($"x1 = {numarator1} ; x2 = {numarator2}");
            }
            else if ((ok1 == 1 && ok2 == 0) && (ok3 == 1 && ok4 == 1))
            {
                Console.WriteLine($"x1 = {numarator1}/{a} ; x2 = {numarator2}");
            }
            else if ((ok1 == 0 && ok2 == 1) && (ok3 == 1 && ok4 == 1))
            {
                Console.WriteLine($"x1 = {numarator1}/{2} ; x2 = {numarator2}");
            }
            else if ((ok1 == 0 && ok2 == 0) && (ok3 == 1 && ok4 == 1))
            {
                Console.WriteLine($"x1 = {numarator1}/{2 * a} ; x2 = {numarator2}");
            }
            else if ((ok1 == 1 && ok2 == 1) && (ok3 == 1 && ok4 == 0))
            {
                Console.WriteLine($"x1 = {numarator1} ; x2 = {numarator2}/{a}");
            }
            else if ((ok1 == 1 && ok2 == 1) && (ok3 == 0 && ok4 == 1))
            {
                Console.WriteLine($"x1 = {numarator1} ; x2 = {numarator2}/{2}");
            }
            else if ((ok1 == 1 && ok2 == 1) && (ok3 == 0 && ok4 == 0))
            {
                Console.WriteLine($"x1 = {numarator1} ; x2 = {numarator2}/{2 * a}");
            }
            else if ((ok1 == 0 && ok2 == 0) && (ok3 == 0 && ok4 == 0))
            {
                Console.WriteLine($"x1 = {numarator1}/{2 * a} ; x2 = {numarator2}/{2 * a}");
            }
            else if ((ok1 == 0 && ok2 == 1) && (ok3 == 0 && ok4 == 1))
            {
                Console.WriteLine($"x1 = {numarator1}/{2} ; x2 = {numarator2}/{2}");
            }
            else if ((ok1 == 0 && ok2 == 1) && (ok3 == 1 && ok4 == 0))
            {
                Console.WriteLine($"x1 = {numarator1}/{2} ; x2 = {numarator2}/{a}");
            }
            else if ((ok1 == 1 && ok2 == 0) && (ok3 == 1 && ok4 == 0))
            {
                Console.WriteLine($"x1 = {numarator1}/{a} ; x2 = {numarator2}/{a}");
            }
            else if ((ok1 == 1 && ok2 == 0) && (ok3 == 0 && ok4 == 1))
            {
                Console.WriteLine($"x1 = {numarator1}/{a} ; x2 = {numarator2}/{2}");
            }
        }
        else
        {
            Console.WriteLine($"x1 = {(-1) * b} - r{Delta}/{2 * a} ,x2 = {(-1) * b} + r{Delta}/{2 * a} ");
        }
    }

}
//Exercitiul 3  - Verificare daca n se divide cu k 

 void Exercitiul3()
 {
    Console.WriteLine($"Intoduceti 2 numere pentru a le verifica daca primul numar se divide cu al doilea numar . ");
    // Citim numerele n si k 

    int n, k;
  string line;
  line = Console.ReadLine();
  string[] p = line.Split(" ");
  n = int.Parse(p[0]);
  k = int.Parse(p[1]);

  // Verificam daca n se divide cu k , daca da se afiseaza mesajul "DA" , in caz contrat se va afisa mesajul "NU";

  if (n % k == 0)
       Console.WriteLine($"DA");
  else
        Console.WriteLine($"NU");
  }



// Exercitiul 4 - Verificare daca un an este bisect 
void Exercitiul4()
{
    Console.WriteLine($"Intoduceti un an pentru a verifica daca este bisect . ");

    // Citim n ;

    int n;
    string line;
    line = Console.ReadLine();
    n = int.Parse(line);

    // Verificam daca anul este bisect , daca da se va afisa ca este bisect altfel nu 

    if ((n % 4 == 0 && n%100!=0) || n%400==0)
        Console.WriteLine($"Anul {n} este bisect .");
    else
        Console.WriteLine($"Anul {n} nu este bisect.");
}


// Exercitiul 5 - Afisarea a k-a cifra de la sfarsitul unui numar

void Exercitiul5()
{
    Console.WriteLine($"Intoduceti un numar si o pozitie a unei cifre din numar pe care le doriti sa afisati . ");
    // Citim n si k , unde k este a k-a cifra de la sfarsitul unui numar

    int n, k;
    string line;
    line = Console.ReadLine();
    string[] p = line.Split(" ");

    n = int.Parse(p[0]);
    k = int.Parse(p[1]);

    // Afisam a k-lea cifrea de la sfarsitul unui numar

    while (k != 1)
    {
        n = n / 10;
        k--;
    }

    Console.WriteLine(n % 10);
}



// Exercitiul 6- Verificare daca trei numere consecutive a,b,c pot fi laturilor unui triunghi 
void Exercitiul6()
{
    Console.WriteLine($"Intoduceti 3 numere consecutive pentru a verifica daca pot fi laturilor a unui triunghi . ");
    int a, b, c;
    string line = Console.ReadLine();
    string[] p = line.Split(" ");
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);
    c = int.Parse(p[2]);

    if (a + b > c && a + c > b && b + c > a)
        Console.WriteLine($"Cele trei numere {a} {b} si {c} pot fi laturi a unui triunghi");
    else
        Console.WriteLine($"Cele trei numere {a} {b} si {c} nu pot fi laturi a unui triunghi");
}

// Exercitiul 7 -Swap 
void Exercitiul7()
{
    Console.WriteLine($"Intoduceti 2 numere pentru a le interschimba (metoda restrictionata) ");
    //Citim a si b
    int a, b;
    string line = Console.ReadLine();
    string[] p = line.Split(" ");
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);

    // Se aplica interschimbarea 

    int aux = a;
    a = b;
    b = aux;

    // Afisam a si b schimbate 

    Console.WriteLine($"{a} {b}");
}


// Exercitiul 8 -Swap restrictionat 
void Exercitiul8()
{
    Console.WriteLine($"Intoduceti 2 numere pentru a le interschimba (metoda restrictionata) ");
    // Citim a si b

    int a, b;
    string line = Console.ReadLine();
    string[] p = line.Split(" ");
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);

    // Se aplica interschimbarea fara a utiliza in plus o variabila

    a = a + b;
    b = a - b;
    a = a - b;

    // Afisam a si b schimbate 

    Console.WriteLine($"{a} {b}");
}


// Exercitiul 9 -Afisarea a toti divizorii unui numar 
void Exercitiul9()
{
    Console.WriteLine($"Intoduceti un numar pentru a afisa toti divizorii lui .");
    // Citim numarul 
    int n;
    string line = Console.ReadLine();
    n = int.Parse(line);

    // Afisarea divizorilor a unui numar 

    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0) Console.Write($"{i} ");
    }
}


// Exercitiul 10 - Verificam daca un numar n este prim 
void Exercitiul10()
{
    Console.WriteLine($"Intoduceti un numar pentru a verifica daca este prim . ");
    //Citim n
    int n;
    string line = Console.ReadLine();
    n = int.Parse(line);

    if (n <= 1)
    {
        Console.WriteLine($"{n} nu este prim");
        return;
    }
    if (n != 2 && n % 2 == 0)
    {
        Console.WriteLine($"{n} nu este prim");
        return;
    }
    for (int i = 3; i * i <= n; i = i + 2)
    {
        if (n % i == 0)
        {
            Console.WriteLine($"{n} nu este prim");
            return;
        }
    }

    Console.WriteLine($"{n} este prim");

}

// Exercitiul 11- Afisarea in ordine inversa cifrele unui numar n
void Exercitiul11()
{
    Console.WriteLine($"Intoduceti un numar pentru a afisa in ordine inversa cifrele numarului . ");
    // Citim n;
    int n;
    string line = Console.ReadLine();
    n = int.Parse(line);

    // Afisarea in ordine inversa cifrele unui numar n

    while (n != 0)
    {
        Console.Write($"{n % 10} ");
        n = n / 10;
    }
}

// Exercitiul 12 - Afisarea numarului de numere intregi divizibile cu n care se afla in intervalul inchis [a,b]
void Exercitiul12()
{
    Console.WriteLine($"Intoduceti 3 numere . Primele 2 sunt pentru a determina intervalul in care afisam cate numere intregi sunt divizibile cu al treilea numar . ");
    // Citim a , b si n 

    int n, a, b;
    string line = Console.ReadLine();
    string[] p = line.Split(" ");
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);
    n = int.Parse(p[2]);

    // Afisarea numarului de numere intregi divizibile cu n care se afla in intervalul inchis [a,b]

    int nr = 0;

    for (int i = a; i <= b; i++)
        if (i % n == 0) nr++;

    Console.WriteLine($"Numarul de numere intregi divizibile cu n care se afla in intervalul inchis [a,b] este {nr}");
}

// Exercitiul 13 - Numarul de ani care sunt bisecti intre anii y1 si y2 
void Exercitiul13()
{
    Console.WriteLine($"Intoduceti 2 ani pentru care sa se numere cate ani bisecti sunt . ");
    // Citim y1 si y2

    int y1, y2;
    string line = Console.ReadLine();
    string[] p = line.Split(" ");
    y1 = int.Parse(p[0]);
    y2 = int.Parse(p[1]);

    if(y1>y2)
    {
        y1 = y1 + y2;
        y2 = y1 - y2;
        y1 = y1 - y2;
    }

    int nr = 0;

    for (int i = y1; i <= y2; i++)
    {
        if ((i % 4 == 0 && i%100!=0) || i%400==0)
        {
            nr++;
        }
    }
    Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti .");
}

//Exercitiul 14 - Verificare daca n este palindrom 
void Exercitiul14()
{
    Console.WriteLine($"Intoduceti un numar pentru a verifica daca numarul ales este palindrom sau nu . ");
    // Citim n

    int n;
    string line = Console.ReadLine();
    n = int.Parse(line);

    // Crearea inversa numarlui 

    int invers = 0, s = n; ;

    while (n != 0)
    {
        invers = invers * 10 + n % 10;
        n = n / 10;
    }

    if (invers == s)
        Console.WriteLine($"Numarul {s} este palindrom");
    else
        Console.WriteLine($"Numarul {s} nu este palindrom");
}


// Exercitiul 15 - Afisarea in ordine crescatoare celor trei numere de intrare 
void Exercitiul15()
{
    Console.WriteLine($"Intoduceti 3 numere aleatoriu pentru a putea fi ordonate in ordine crescatoare . ");
    // Citim cele trei numere
    int a, b, c;
    string line = Console.ReadLine();
    string[] p = line.Split(" ");
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);
    c = int.Parse(p[2]);

    if (a < b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    if (a < c)
    {
        a = a + c;
        c = a - c;
        a = a - c;
    }

    if (b < a)
    {
        b = b + a;
        a = b - a;
        b = b - a;
    }

    if (b < c)
    {
        b = b + c;
        c = b - c;
        b = b - c;
    }

    if (c < a)
    {
        c = c + a;
        a = c - a;
        c = c - a;
    }

    if (c < b)
    {
        c = c + b;
        b = c - b;
        c = c - b;
    }

    Console.WriteLine($"{a} {b} {c}");
}

// Exercitiul 16 - Afisarea in ordine crescatoare celor 5 numere de intrare 
void Exercitiul16()
{
    Console.WriteLine($"Intoduceti 5 numere aleatoriu pentru a putea fi ordonate in ordine crescatoare . ");

    // Citim datele de intrare
    string line = Console.ReadLine();
    string[] p = line.Split(' ');
    int a, b, c, d, e;
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);
    c = int.Parse(p[2]);
    d = int.Parse(p[3]);
    e = int.Parse(p[4]);

    int minim, maxim, medie;

    // Aflam cea mai mare si cea mai mica dintre cele 5 numere 

    minim = Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))));
    maxim = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));

    //Punem pe minimul si maximul pe locul lor ; minimul pe primul loc , iar maximul pe ultimul loc 

    if (minim == b)
    {
        b = a;
        a = minim;
    }
    else if (minim == c)
    {
        c = a;
        a = minim;
    }
    else if (minim == d)
    {
        d = a;
        a = minim;
    }
    else if (minim == e)
    {
        e = a;
        a = minim;
    }

    if (maxim == a)
    {
        a = e;
        e = maxim;
    }
    else if (maxim == b)
    {
        b = e;
        e = maxim;
    }
    else if (maxim == c)
    {
        c = e;
        e = maxim;
    }
    else if (maxim == d)
    {
        d = e;
        e = maxim;
    }

    //Aflam maximul , minimul si numarul mijlociu dintre cele 3 numere ramase 

    minim = Math.Min(b, Math.Min(c, d));
    maxim = Math.Max(b, Math.Max(c, d));
    medie = b + c + d - minim - maxim;

    //Punem pe maxim , minim si medie la locul lor 

    b = minim;
    c = medie;
    d = maxim;

    Console.WriteLine($"{a} {b} {c} {d} {e}");
}

//Exercitiul 17 - cmmdc si cmmmc a 2 numere;
void Exercitiul17()
{
    Console.WriteLine($"Intoduceti 2 numere pentru a putea fi calculate cel mai mare divizor comun si cel mai mic multiplu comun . ");
    // Citim datele de intrare
    int a, b;
    string line = Console.ReadLine();
    string[] p = line.Split(' ');
    a = int.Parse(p[0]);
    b = int.Parse(p[1]);

    //Aflam cel mai mare divizor comun dintre cele 2 numere
   
    int cmmdc = a, b1 = b;
    while (b1 > 0)
    {
        int rest = cmmdc % b1;
        cmmdc = b1;
        b1 = rest;
    }
    //Aflam cel mai mic multiplu comun dintre cele 2 numere , stiind ca produsul celor 2 numere este egal cu produsul dintre cmmdc si cmmmc
    int cmmmc = (a * b) / cmmdc;

    //Afisam cel mai mare divizor comun si cel mai mic multiplu comun

    Console.WriteLine($"cmmdc : {cmmdc}");
    Console.WriteLine($"cmmmc : {cmmmc}");
}

// Exercitiul 18 -factori primi a unui numar
void Exercitiul18()
{
    Console.WriteLine($"Intoduceti un numar pentru a putea fi scris in factori primi . ");
    //Citim datele de intrare
    int n;
    string line = Console.ReadLine();
    n = int.Parse(line);

    Console.Write($"n = ");

    //Descompunem in factori primi 

    int d = 2;
    while (n > 1)
    {
        int p = 0;
        while (n % d == 0)
        {
            n = n / d;
            p++;
        }

        if (p > 0)
        {
            if (n > 1)
                Console.Write($"{d}^{p} * ");
            else
                Console.Write($"{d}^{p} ");
        }
        d++;
    }
}


//Exercitiul 19 - Verificarea daca un numar este format doar din 2 cifre 
void Exercitiul19()
{
    Console.WriteLine($"Intoduceti un numar pentru a putea fi verificata daca este format doar din 2 cifre . ");
    // Citim datele de intrare 
    string line = Console.ReadLine();
    int n = int.Parse(line);

    //Verificam daca numare este format din 2 cifre sau nu 

    int cifra1 = -1, cifra2 = -1, s = n;

    while (n > 0)
    {
        if (cifra1 == -1)
        {
            cifra1 = n % 10;
        }
        else if (cifra2 == -1 && n % 10 != cifra1)
        {
            cifra2 = n % 10;
        }
        else if (cifra1 != -1 && cifra2 != -1)
        {
            if (cifra1 != n % 10 && cifra2 != n % 10)
            {
                Console.WriteLine($"Numarul {s} nu este format doar din 2 cifre");
                return;
            }
        }

        n = n / 10;
    }

    Console.WriteLine($"Numarul {s} este format din 2 cifre");
}

// Exerctiul 20 - Afisarea fractiei m/n in format zecimal

int factorial(int n)
{
    int d = 2,nr=0;
    while(n!=1)
    {
        int p = 0;
        while(n%d==0)
        {
            n = n / d;
            p++;
        }

        if(p>0)
        {
            if (d == 2 || d == 5) nr++;
            else
            {
                nr = -99999999;
                break;
            }
        }

        d++;
    }

    return nr;

}

void Exercitiul20()
{
    //Citim m si n 
    Console.WriteLine($"Introduceti doua numere pe care le doriti sa scrieti in forma zecimala.");
    int m, n;
    string line = Console.ReadLine();
    string[] p = line.Split(' ');
    m = int.Parse(p[0]);
    n = int.Parse(p[1]);

    // Verificare daca m/n este o fractie neperiodica
    if (factorial(n) >= 1 && factorial(n) <= 2)
    {
        int intreg = 0, rest = 0;
        long zecimal = 0;
        intreg = m / n;
        rest = m % n;
        rest *= 10;
        while (rest != 0)
        {
            zecimal = zecimal * 10 + rest / n;
            rest = rest % n;
            rest *= 10;
        }
        Console.WriteLine($"Fractia {m}/{n} = {intreg}.{zecimal}");
        return;
    }
    else if (n % 2 != 0 && n % 5 != 0) //Verificare daca m/n este o fractie periodica
    {
        int intreaga = 0, ok = 0, zecimal = 0;
        long perioada = 0;
        intreaga = m / n;
        zecimal = m % n;
        zecimal *= 10;

        // Cream o lista care ne ajuta sa cautam restul care reincepe perioada
        List<int> rest = new List<int>();
        rest.Add(zecimal);

        while (ok == 0)
        {
            perioada = perioada * 10 + zecimal / n;
            zecimal = zecimal % n;
            zecimal *= 10;
            foreach (int i in rest)
                if (i == zecimal)
                {
                    ok = 1; break;
                }
            rest.Add(zecimal);
        }

        Console.WriteLine($"Fractia {m}/{n} = {intreaga}.({perioada})");
        return;
    }
    else
    {
        int intreaga = 0, ok = 0, zecimal = 0;
        long perioada = 0, nr = 1;
        intreaga = m / n;
        zecimal = m % n;
        zecimal *= 10;

        List<int> rest = new List<int>();
        rest.Add(zecimal);

        while (ok == 0)
        {
            nr = 1;
            perioada = perioada * 10 + zecimal / n;
            zecimal = zecimal % n;
            zecimal *= 10;
            foreach (int i in rest)
                if (i == zecimal)
                {
                    nr *= 10;
                    ok = 1; break;
                }
            rest.Add(zecimal);
        }
        Console.WriteLine($"Fractia {m}/{n} = {intreaga}.{perioada / nr}({perioada % nr})");
    }
}
    //Exercitiul 21 - Ghicirea unui numar aflat din [1,1024]
    void Exercitiul21()
    {
        //Mesajul 'START'
        Console.WriteLine($"Gandeste-te la un numar .");
        Console.WriteLine($"Cand esti gata scrie 'START' !");

        string line = Console.ReadLine();

        int st = 1, dr = 1024, mij;
        mij = (st + dr) / 2;

        while (st <= dr)
        {
            Console.WriteLine($"Numarul este mai mare sau egal decat {mij}? ");
            string raspuns = Console.ReadLine();
            if (raspuns == "DA")
            {
                st = mij + 1;
            }
            else
            {
                dr = mij - 1;
            }
            mij = (st + dr) / 2;
        }

        Console.WriteLine($"Numarul tau este {mij}");
    }