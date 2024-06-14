// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = {1, 2, 3,4 };

PrintReverse(array,array.Length-1);

void PrintReverse(int[] array, int index)
{
if (index>=0)
{
    Console.Write(array[index] + "");
    PrintReverse(array, index-1);
}
}
