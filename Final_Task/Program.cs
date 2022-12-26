// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] arra =  {"Hy","its", "My", "World!", "indeed", "not", "only", "mine","gd?"};

void PrintArray(string[] arra)
{
    Console.Write("|");
    for (int i = 0; i < arra.Length; i++)
    {
        if (i < arra.Length - 1) Console.Write($"{arra[i]}, ");
        else Console.Write($"{arra[i]}");
    }
    Console.WriteLine("|");
}

void PrintArraySorting(string[] sortingArray)
{
    for (int i = 0; i < sortingArray.Length; i++)
    {
        Console.Write(sortingArray[i] + " ");
    }
}

string[] SortingArray(string[] array)
{
    string[] sortingArray = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortingArray[temp] = array[i];
            temp++;
        }
    }
    return sortingArray;
}

Console.WriteLine("  Matrix: ");
PrintArray(arra);
Console.WriteLine("===============================");
Console.WriteLine("Sorting element from matrix : ");
string[] sortingArray = SortingArray(arra);
PrintArraySorting(sortingArray);