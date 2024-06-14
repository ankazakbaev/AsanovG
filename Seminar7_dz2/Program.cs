// See https://aka.ms/new-console-template for more information
int GetNumber()
{
    Console.WriteLine("Введите число:");
    int numA = Convert.ToInt32(Console.ReadLine());
    return numA;
}

int m = GetNumber();
int n = GetNumber();

FAkkerman(m,n);


void FAkkerman(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}