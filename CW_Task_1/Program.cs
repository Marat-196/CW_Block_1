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
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"'{arr[i]}', ");
        else Console.Write($"'{arr[i]}'");
    }
    Console.Write("]");
}

int CountLessThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count ++;
    }
    return count;
}

string[] ArrayLessThree(string[] arr)
{   
    int j = 0;
    string[] arr_A = new string[CountLessThree(arr)];
    if(arr_A.Length == 0) return arr_A;
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i].Length <= 3)
            {
                arr_A[j] = arr[i];
                j ++;
            } 
        }
        return arr_A;
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
string[] res_itog = ArrayLessThree(res);
Console.Write(" -> ");
PrintArray(res_itog);
