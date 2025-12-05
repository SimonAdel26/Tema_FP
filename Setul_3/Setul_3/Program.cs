
Console.WriteLine($"Introduceti prima oara dimensiunea vectorului , iar apoi elementele acestuia.");
Console.WriteLine($"Algoritmul va afisa elementul majoritate daca exista , in caz contrar va afisa mesajul : 'Nu exista' ");
Console.WriteLine();

//Citire
string line= Console.ReadLine();
int n=int.Parse(line);

line=Console.ReadLine();
string[] p=line.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[] v = new int[n], aparitii=new int[n];
int max=-1,ElementMaj=0;
for(int i=0;i<n;i++)
{
    v[i]=int.Parse(p[i]);
    
}

// determinare element majoritate

elem_maj(v, 0, n - 1, ref max, ref ElementMaj);

void elem_maj(int[] v,int st,int dr,ref int max, ref int ElementMaj)
{
    if(st<dr)
    {
        int mij = (st + dr) / 2;
        elem_maj(v, st, mij, ref max,ref ElementMaj);
        elem_maj(v,mij+1,dr,ref max, ref ElementMaj);

        for(int i=st;i<mij;i++)
        {
            for (int j = mij;j<=dr;j++)
            {
                if (v[j] == v[i]) aparitii[i]++;
                else aparitii[j]++;
            }

            if (aparitii[i] > max)
            {
                max = aparitii[i];
                ElementMaj = v[i];
            }
        }

    }
}

//Afisare 

if (max > n / 2) Console.WriteLine($"Elementul majoritate din vector este : {ElementMaj}");
else Console.WriteLine($"Nu exista.");



