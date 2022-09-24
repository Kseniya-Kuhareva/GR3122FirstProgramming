// # 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Чтение данных пользователя
int ReadData(string line)
{
    
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать 2D массива.
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Заполняем массив 
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

//Находим элемент
int FindElem(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) &&
    y < array2D.GetLength(1))
    {
        return array2D[x, y];
    }
    else
    {
        return -1;
    }
}
//Выводим результат (есть такой элемент или нет)
void PrintResult(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) &&
    y < array2D.GetLength(1))
    {
        Console.WriteLine($"Значение элемента {array2D[x, y]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}

int countRow = ReadData("Введите количество строк: ");
int countColumn = ReadData("Введите количество столбцов: ");
Console.WriteLine();

int[,] array = Fill2DArray(countRow, countColumn, 1, 100);
Print2DArray(array);

Console.WriteLine();
int x = ReadData("Введите номер строки: ") - 1;
int y = ReadData("Введите номер столбца: ") - 1;

int elem = FindElem(x, y, array);
PrintResult(x, y, array);

