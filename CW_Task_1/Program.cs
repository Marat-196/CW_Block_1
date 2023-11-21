// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreateArray(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}


Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.Write("Введите число больше 0!");
    return;
}

string[] res = CreateArray(num);
PrintArray(res);

