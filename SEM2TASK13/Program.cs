// # 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

Console.WriteLine("Введите число:");                                     //пользователь вводит число
string inputLine = Console.ReadLine() ?? "";                             //консоль считывает число
if (inputLine.Length >= 3)                                               //условие (если число трехзначное или больше)
{
    int inputNumber = int.Parse(inputLine);                              //делаем числа вещественными
    char[] charArray = inputNumber.ToString().ToCharArray();             //делаем из числа массив
    Console.WriteLine(charArray[2]);                                     //консоль выдает 3 цифру числа
}
else                                                                     //иначе
{
    Console.WriteLine("В числе меньше трех цифр");                       //консоль выдает "текст"
}