// See https://aka.ms/new-console-template for more information
void Kol(int n)
{
    if(n==0)
    {
       System.Console.WriteLine();

    }
    else { System.Console.Write($" {n} ");
        Kol(n-1);

    }
}
Kol(10);
