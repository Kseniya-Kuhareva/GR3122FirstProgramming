// # 10 Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число:");                                     //пользователь вводит число
string inputLine = Console.ReadLine() ?? "";                             //консоль считывает число
if (inputLine.Length == 3)                                               //условие (если число трехзначное)
{
    int inputNumber = int.Parse(inputLine);                              //делаем числа вещественными
    char[] charArray = inputNumber.ToString().ToCharArray();             //делаем из числа массив
    Console.WriteLine(charArray[1]);                                     //консоль выдает 2 цифру числа
}
else                                                                     //иначе
{
    Console.WriteLine("Число не является трехзначным");                  //консоль выдает "текст"
}