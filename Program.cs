// Задание
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System;
using static System.Console;

Clear();

string[] array = AskArray();
string[] result = FindArray(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindArray(string[] input, int n) 
{
    string[] output = new string[Count(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int Count(string[] input, int n) 
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }

    return count;
}

string[] AskArray() 
{
    Write("Введите различные слова или значения через пробел: ");
    return ReadLine().Split(" ");
}