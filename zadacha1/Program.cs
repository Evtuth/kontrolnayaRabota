﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

string[] array1 = new string[10] {"1", "12", "123", "1234", "12345","h", "he", "hel", "hell", "hello"};
string[] array2 = new string[array1.Length];

void CollectingArrayElementsByCondition(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

CollectingArrayElementsByCondition(array1, array2);
Console.WriteLine("Исходный массив:");
PrintArray(array1);
Console.WriteLine("Получившийся массив:");
PrintArray(array2);