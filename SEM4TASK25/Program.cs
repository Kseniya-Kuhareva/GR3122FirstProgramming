// # 25 Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

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

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

//Выводим данные вычисления
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

int exponentiation = Exponentiation(numberA, numberB);
PrintResult("Ответ: " + exponentiation);
