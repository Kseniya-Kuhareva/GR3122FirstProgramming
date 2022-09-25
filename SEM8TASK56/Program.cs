// # 56 Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов

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
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] arr, int arrMin, int arrMax)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(arrMin, arrMax + 1);
        }
    }
}

// Находим строку с наименьшей суммой элементов
int FindMinRow(int[,] arr)
{
    int min = int.MaxValue;
    int sum = 0;
    int outIndexRow = -1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i + 1;
        }
        sum = 0;
    }
    return outIndexRow;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int countRow = ReadData("Введите количество строк: ");
int countColumn = ReadData("Введите количество столбцов: ");
int[,] arr = new int[countRow, countColumn];

Fill2DArray(arr, 1, 3);
Print2DArray(arr);

PrintResult("Номер строки с наименьшей суммой элементов: " + FindMinRow(arr));