﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполннения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}

string[] SizeCount (string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        newArray[i] = array[i];    
    }
    return newArray;
    
}

string a = "hello";
string b = "2";
string c = "world";
string d = ":)";
string f = "Denmark";

string[] array = {a, b, c, d, f};

PrintArray(SizeCount(array));