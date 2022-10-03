/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] array = GetArray(6, 1, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Разница = {GetDifference(array)}");

int GetDifference(int[] array)
{
    int Maxnum = array[0];
    int Minnum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Maxnum)
        {
            Maxnum = array[i];
        }
        else if (array[i] < Minnum)
        {
            Minnum = array[i];
        }

    }
    Console.WriteLine($"Максимальный элемент = {Maxnum} и минимальный элемент = {Minnum}");
    return Maxnum - Minnum;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}