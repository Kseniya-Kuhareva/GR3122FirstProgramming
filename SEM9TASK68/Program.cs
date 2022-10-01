// # 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод печати
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Функция Аккермана
int funcAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return funcAckermann(m - 1, 1);
    }
    else
    {
        return funcAckermann(m - 1, funcAckermann(m, n - 1));
    }
}

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

PrintResult("" + funcAckermann(m, n));

