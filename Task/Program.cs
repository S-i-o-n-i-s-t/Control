﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алкогитма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
Console.WriteLine("Введите количество необходимых индексов для массива");
int c = Convert.ToInt32(Console.ReadLine());
string[] N = new string[c];
string[] M = new string[c]; 
void CreatingArray(string[] Name)
{
    for (int index = 0; index < Name.Length;index++)
    { 
        Name[index] = (Console.ReadLine());
    }
}
void PrintArray(string[] Name)
{
    for (int pozition = 0; pozition < Name.Length; pozition++)
    {
        Console.Write($"{Name[pozition]} ");
    }
}
Console.WriteLine("Заполните массив");
CreatingArray(N);
Console.WriteLine("Ваш массив");
PrintArray(N);

