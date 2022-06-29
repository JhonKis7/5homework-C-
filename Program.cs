//Задача 34

Console.Write("Input lenght array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int Positive = 0;
Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
    Console.Write($"{array[i]}");
    if ( i + 1 < array.Length)
    {
        Console.Write(", ");
    }
}
Console.Write("]");
Console.Write(" -> ");
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
        Positive++;
}
Console.WriteLine($"Чётных чисел = {Positive}");


//Задача 36
//Задайте одномерный массив, заполненный случайными числами. Найдите 
//сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] - 19
//[-4, -6, 89, 6] - 0
/*
Console.Write("Input lenght array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int sumNegative = 0;
Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]}");
    if ( i + 1 < array.Length)
    {
        Console.Write(", ");
    }
}
Console.Write("]");
Console.Write("-> ");
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 != 0)
        sumNegative += array[i];
}
Console.WriteLine(sumNegative);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
Console.Write("Input lenght array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int maxNumber = 0;
int minNumber = 100;
Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]}");
    if ( i + 1 < array.Length)
    {
        Console.Write(", ");
    }
}
Console.Write("]");
Console.Write(" -> ");
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > maxNumber)
        maxNumber = array[i];
        array[i]++;
    if(array[i] < minNumber)
        minNumber = array[i] - 1;
        array[i]++;
}
Console.Write($"{maxNumber - minNumber}"); 
*/


