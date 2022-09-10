// # 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//считываем информацию от пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

//тест на палиндром
bool TestPalin(int num)
{
    if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
    {
        return true;
    }
    else
    {
        return false;
    }

}

    //выводим данные вычисления
    void PrintResult(int num)
    {
        if (TestPalin(num))
        {
            Console.WriteLine(num + " является палиндромом");
        }
        else
        {
            Console.WriteLine(num + " не является палиндромом");
        }
    }

    int num = ReadData("Введите пятизначное число: ");
    PrintResult(num);
