// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}


//Выводим данные вычисления
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int number = ReadData("Введите число: ");
int numberOfDigits = SumDigit(number);
PrintResult("Сумма цифр в числе: " + numberOfDigits);
