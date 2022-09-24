// #52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Чтение данных пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Генерация и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int arrMin, int arrMax)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(arrMin, arrMax + 1);
        }
    }
    return array2D;
}

// Генерация одномерного массива
void Print1DArray(double[] arr)
{
    string arrString = String.Empty;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
    }

    arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
}

// // Находим среднее арифметическое по столбцам и выводим в одномерный массив
double[] CalcAvrgColumns(int[,] arr)
{
    double[] colAverages = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            colAverages[j] += arr[i, j];
        }
    }

    return DivideArr(colAverages, arr.GetLength(0));
}

// Делим элементы в одномерном массиве на делитель
double[] DivideArr(double[] arr, int divider)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i] / divider, 2);
    }

    return arr;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int countRow = ReadData("Введите количество строк: ");
int countColumn = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(countRow, countColumn, 1, 99);
PrintResult("Массив: ");
Print2DArray(array2D);
Console.WriteLine();
PrintResult("Cредние арифметические по столбцам: ");
Print1DArray(CalcAvrgColumns(array2D));
