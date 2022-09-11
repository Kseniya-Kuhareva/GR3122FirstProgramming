// Напишите программу, которая принимает на вход
//число и выдаёт количество цифр в числе.

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

int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum+=1;
        num = num / 10;
    }
    return num;
}

//Выводим данные вычисления
void PrintResult(string line)
{
    Console.WriteLine(line);
}


//Вариант с длиной строки

int CalculateDigitsString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}

int number = ReadData("Введите число: ");

int numberOfDigits = CalculateDigitsString(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);

numberOfDigits = DigitCount(number);
PrintResult("Количество цифр в числе: " + numberOfDigits);
