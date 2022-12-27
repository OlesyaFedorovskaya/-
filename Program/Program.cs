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

Console.WriteLine("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());


void ElementsArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        string count = Console.ReadLine().ToString();
        count = array[i];
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        if (i < size - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int NewArraySize(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}


