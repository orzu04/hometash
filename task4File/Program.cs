// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

void All(int n)
{
    if(n==0)
    {
        return;
    }
    else {
        All(n/10);
        System.Console.Write(n % 10 + " ");
    }
}
All(1234);