// # 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//чтение данных из консоли
int ReadData(string line)
{
    //вводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//Создаем и заполняем массив
int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

//Выводим массив
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
    Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int arrLen = ReadData("Введите длину массива: ");
int[] array = GenArr(arrLen);
PrintArray(array);

