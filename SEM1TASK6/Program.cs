// # 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число
//чётным (делится ли оно на два без остатка).

string? inputLine = Console.ReadLine();                                    //вводим число
if (inputLine != null)                                                     //проверяем на null

{
    int inputNumber = int.Parse(inputLine);                                //магия вещественных чисел
    if (inputNumber % 2 == 0)                                              //проверяем на остаток от деления
        Console.WriteLine("Четное");                                       //выводим четное
    else                                                                   //иначе
    {
        Console.WriteLine("Нечетное");                                     //выводим нечетное
    }
}
