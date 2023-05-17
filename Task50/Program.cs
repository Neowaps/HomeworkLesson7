// Задача 50. Напишите программу, которая на вход принимает число,
// и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

bool FindNumber(int[,] array, int num, bool res)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i,j])
            {
                System.Console.WriteLine($"Индексы нужного вам элемента: ({i}, {j})");
                res = true;
                break;
            }
        }
    }
    return res;
}

void GetRandomArray(int[,] randarray)
{
    for (int i = 0; i < randarray.GetLength(0); i++)
    {
        for (int j = 0; j < randarray.GetLength(1); j++)
        {
            randarray[i, j] = new Random().Next(1, 26);
        }
    }
}

void ShowArray(int[,] showArr)
{
    for (int i = 0; i < showArr.GetLength(0); i++)
    {
        for (int j = 0; j < showArr.GetLength(1); j++)
        {
            System.Console.Write(showArr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк массива: ");
int line = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());
int[,] arr = new int[line, column];

System.Console.Write("Введите число, которое мы будем искать: ");
int number = int.Parse(Console.ReadLine());
GetRandomArray(arr);
ShowArray(arr);
System.Console.WriteLine();
bool result = false;

if (FindNumber(arr, number, result) == false)
{
    System.Console.WriteLine("Такого числа в массиве нет :(");
}
