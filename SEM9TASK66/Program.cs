// 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод печати
void PrintResult(int line)
{
    Console.WriteLine(line);
}

//Сумма элементов от N до M
int RecMN(int m, int n)
{
    if (m >= n) return n;
    return m + RecMN(m + 1, n);
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

Console.Write("Сумма элементов в промежутке между числами: ");
PrintResult(m > n ? RecMN(n, m) : RecMN(m, n));