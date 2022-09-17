// 38 Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Заполняем массив вещественными числами
double[] FillArray(int arrLength, double start, double stop)
{
    double[] array = new double[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.NextDouble();
    }
    return array;
}

// печатаем массив
void Print1DArray(double[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();

}

// находим разницу между максимальным и минамальным элементом массива
double MaxMin(double[] arr)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return (max - min);
}

double[] arr = FillArray(10, 0, 100);

Print1DArray(arr);
PrintResult("Разница между максимальным и минимальным элементом массива: " + MaxMin(arr));



