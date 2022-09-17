// 36 Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Заполняем массив
int[] FillArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void Print1DArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// считаем сумму элементов на нечетных позииях
int EvenSumPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] arr = FillArray(20, 0, 1000);

Print1DArray(arr);
PrintResult("Сумма элементов, стоящих на нечётных позициях: " + EvenSumPos(arr));
