// # 58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

//  Перемножаем две матрицы
int[,] MatrixMultiple(int[,] matrA, int[,] matrB)
{
    int[,] matrixResult = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                matrixResult[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return matrixResult;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int m = ReadData("Введите количество строк первой матрицы: ");
int n = ReadData("Введите количество столбцов первой матрицы (и строк 2-й): ");
int[,] matrix1 = new int[m, n];

Fill2DArray(matrix1, 1, 9);
Print2DArray(matrix1);

int n1 = ReadData("Введите количество столбцов второй матрицы: ");
int[,] matrix2 = new int[n, n1];


Fill2DArray(matrix2, 1, 9);
Print2DArray(matrix2);

PrintResult("Результат перемножения матриц: ");
Print2DArray(MatrixMultiple(matrix1, matrix2));