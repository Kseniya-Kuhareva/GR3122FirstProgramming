// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой находится эта точка.

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
int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

        return -1;
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}

int x = ReadData("Введите координату x: ");
int y = ReadData("Введите координату y: ");

int result = QuarterTest(x, y);

PrintResult("Точка находится в четверти №: " + result);
