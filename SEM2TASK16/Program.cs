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

//тест на квадрат
bool Sqrtest(int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Выводим данные вычисления
void PrintData(int firstNum, int secondNum)
{
    if (Sqrtest(firstNum, secondNum))
    {
        Console.WriteLine("Число " + firstNum + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + firstNum + " не квадрат числа " + secondNum);
    }
}

int num1 = ReadData("Введите число 1");
int num2 = ReadData("Введите число 2");

PrintData(num1, num2);
PrintData(num2, num1);
