﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Prompt(string messege)
{
    System.Console.Write(messege);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumAlldigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt("Введите число:");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAlldigit(number)}");
