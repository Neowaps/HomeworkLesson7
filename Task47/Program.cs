// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.

// 0,5 7,0 -2,0 -0,2

// 1,0 -3,3 8,0 -9,9

// 8,0 7,8 -7,1 9,0

System.Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];


void ShowArray(double[,] showArr)
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


void GetRandomArray(double[,] randarray)
{
    for (int i = 0; i < randarray.GetLength(0); i++)
    {
        for (int j = 0; j < randarray.GetLength(1); j++)
        {
            randarray[i, j] = new Random().Next(-10, 10);
        }
    }
}

GetRandomArray(array);
System.Console.WriteLine("Полученный массив: ");
ShowArray(array);
