// Напишите программу, которая принимает на вход
//число N и выдаёт произведение чисел от 1 до N.

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

long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

//Выводим данные вычисления
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int number = ReadData("Введите число: ");
long factorial = CalculateFactorial
(number);
PrintResult("Факториал равен: " + factorial);