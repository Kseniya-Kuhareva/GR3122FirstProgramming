// #41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Создаем из введенных чисел массив
int[] GetArray(int arrLength)
{
    int[] arr = new int[arrLength];

    for (int i = 0; i < arrLength; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return arr;
}

//Считаем количество чисел больше нуля
int CountPosNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество чисел: ");
int arr = int.Parse(Console.ReadLine() ?? "0");
int[] newArray = GetArray(arr);
Console.WriteLine("Положительных чисел: " + CountPosNums(newArray));