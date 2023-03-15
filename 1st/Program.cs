// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам.
// Первоначальный массив модн ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Clear();

void ModifPrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            if (i == (array.Length - 1)) Console.Write("'{0}'", array[i]);
            else Console.Write("'{0}', ", array[i]);
        }
    }
    Console.Write("]");
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length - 1)) Console.Write("'{0}'", array[i]);
        else Console.Write("'{0}', ", array[i]);
    }
    Console.Write("]");
}

string[] GetArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} значение - ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int GetSize(string text)
{
    Console.Write(text);
    string size = Console.ReadLine();
    while (int.TryParse(size, out _) == false || String.IsNullOrEmpty(size) || int.Parse(size) == 0) { Console.Write(text); size = Console.ReadLine(); }
    return int.Parse(size);
}


int size = GetSize("Какой длины хотите задать массив? -  ");
string[] array = GetArray(size);
PrintArray(array);
Console.Write(" -> ");
ModifPrintArray(array);