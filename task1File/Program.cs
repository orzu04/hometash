int t=1;
void Kol(int n)
{
    if(t-1==n)
    {
    System.Console.WriteLine();
    }
    else{
       System.Console.Write(t+" ");
       t++;
       Kol(n);
    }
}
Kol(10);

