﻿int[] array = new int[10];
int result = 0;
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i]+" ");
}
Console.WriteLine();
for (int i=0; i<array.Length; i++)
{
    if (array[i]>=20 && array[i]<=90)
    {
        result++;
    }
}
Console.Write(result);