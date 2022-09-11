// Напишите программу, которая принимает на вход
//число (А) и выдаёт сумму чисел от 1 до А.

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

//Выводим данные вычисления
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}


int numberA = ReadData("Введите число А: ");
DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Сумма чисел от 1 до A равна(простой метод): " + res1);
PrintResult("Сумма чисел от 1 до A равна(метод Гаусса): " + res2);



