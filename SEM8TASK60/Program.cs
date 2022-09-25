// # 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать 3D массива
void Print3DArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)

            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// Заполнение массива 
void Fill3DArray(int[,,] arr, int arrMin, int arrMax)
{

    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    arr[i, j, k] = new Random().Next(arrMin, arrMax + 1);
                }
            }
        }
    }
}

int countRow = ReadData("Введите количество строк: ");
int countColumn = ReadData("Введите количество столбцов: ");
int height = ReadData("Введите высоту: ");
int[,,] arr3D = new int[countRow, countColumn, height];

Fill3DArray(arr3D, 1, 10);
Print3DArray(arr3D);
