// See https://aka.ms/new-console-template for more information
int cnt=0;
int n = Convert.ToInt32(Console.ReadLine());
int Kol(int n)
{
    if(n==0)
    {
        return 0;
    }
    else{
        cnt++;
        Kol(n/10);
        return cnt;
       
    }
}

System.Console.WriteLine(Kol(n));