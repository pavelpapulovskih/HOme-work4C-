﻿int Prompt(string messege)
{
    System.Console.Write(messege);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] GeneraateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

int Length = Prompt("Длина массива:");
int minValue = Prompt("Минимальное число массива:");
int maxValue = Prompt("Максимальное число массива массива:");
int[] array = GeneraateArray(Length,minValue,maxValue);
PrintArray(array);
