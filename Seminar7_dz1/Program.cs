// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
int GetNumber()
{
    Console.WriteLine("Введите число:");
    int numA = Convert.ToInt32(Console.ReadLine());
    return numA;
}

int alfa = GetNumber();
int beta = GetNumber();
ListNumber(beta,alfa);

void ListNumber(int beta, int alfa)
{
    if (alfa <= beta)
    {
        Console.WriteLine(alfa);
        ListNumber(beta, alfa+1);
    }
    
}  
