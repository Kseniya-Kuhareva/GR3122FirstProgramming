// # 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

//чтение данных пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


// генерация и заполнение двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, double arrMin, double arrMax)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.NextDouble() * 100;
        }
    }
    return array2D;
}

// Печать 2D массива.
void Print2DArr(double[,] arr, string message = "Массив: ")
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


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

double[,] arr2D = Fill2DArray(row, column, 1, 99);
Print2DArr(arr2D);