// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

//Вариант Евгения 
Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);

if (inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
{
    Console.Write("Число кратно одновременно 7 и 23");
}
else
{
    Console.Write("Число не кратно одновременно 7 и 23");
}