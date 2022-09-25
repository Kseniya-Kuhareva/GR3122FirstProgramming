//# 54 Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Чтение данных из консоли
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

// Заполняем массив случайными числами
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

//  Сортируем строки по убыванию
int[,] UpdateArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Row.Add(arr[i, j]);
            Row.Sort();
            Row.Reverse();
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Row[j];
        }
    }
    return arr;
}


int countRow = ReadData("Введите количество строк: ");
int countColumn = ReadData("Введите количество столбцов: ");
int[,] arr = Fill2DArray(countRow, countColumn, 1, 9);
Print2DArray(arr);
Console.WriteLine("Измененный массив: ");
Print2DArray(UpdateArray(arr));
