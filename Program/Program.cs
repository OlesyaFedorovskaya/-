//  Задача: Написать программу, которая
//  из имеющегося массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void ElementsArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        string temp = Console.ReadLine().ToString();
        array[i] = temp;
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int NewArraySize(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] ConvertToString(string[] array, int size)
{
    string[] array2 = new string[size];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[result] = array[i];
            result++;
        }
    }
    return array2;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
ElementsArray(array1);
int size2 = NewArraySize(array1);
string[] array2 = ConvertToString(array1, size2);
PrintArray(array1);
Console.WriteLine("Формируем новый строчный массив");
PrintArray(array2);

