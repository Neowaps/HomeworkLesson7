// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void GetRandomArray(int[,] randArray)
{
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            randArray[i, j] = new Random().Next(1, 26);
        }
    }
}

void ShowArray2D(int[,] showArr)
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

void ShowArray(double[] showArray)
{
    for (int i = 0; i < showArray.Length; i++)
    {
        System.Console.Write(showArray[i] + " ");
    }
}

double[] GetAvg(int[,] arrAvg)
{
    int len = arrAvg.GetLength(1);
    double[] avg = new double[len];
    for (int i = 0; i < arrAvg.GetLength(1); i++)
    {
        for (int j = 0; j < arrAvg.GetLength(0); j++)
        {
            avg[i] += arrAvg[j,i];
        }
    avg[i] /= arrAvg.GetLength(0);
    avg[i] = Math.Round(avg[i], 2);
    }
    return avg;
}


System.Console.Write("Введите количество строк массива: ");
int line = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());
int[,] arr = new int[line, column];
int arrayLen = arr.GetLength(1);

System.Console.WriteLine("Сгенерированный массив: ");
GetRandomArray(arr);
ShowArray2D(arr);
System.Console.WriteLine();
double[] result = GetAvg(arr);
System.Console.WriteLine("Среднее арифметическое в каждом столбце: ");
ShowArray(result);
