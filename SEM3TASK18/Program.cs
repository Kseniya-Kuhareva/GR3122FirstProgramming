// Напишите программу, которая по заданному номеру
//четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

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
string QuarterBorderAsk(int numQuarter)
{
    if (numQuarter == 1)
        return "x>0 y>0";
    if (numQuarter == 2)
        return "x<0 y>0";
    if (numQuarter == 3)
        return "x<0 y<0";
    if (numQuarter == 4)
        return "x>0 y<0";

    return "";
}

void PrintResult(string line)

{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string result = QuarterBorderAsk(num);

PrintResult(result);
