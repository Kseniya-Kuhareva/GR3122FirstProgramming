//# 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
//все чётные числа от 1 до N.

string? inputLineA = Console.ReadLine();                //вводим число
int B = 1;                                              //вводим число, от которого будем вести счет
if (inputLineA != null)                                 //проверяем на null
{
    int inputNumberA = int.Parse(inputLineA);           //делаем числа вещественными
    while (B < inputNumberA)
    {
        if (B % 2 == 0)                                 //условие (если число,от которого ведем отсчет к введенному числу, делится на 2 без остатка)
            Console.Write(B + ", ");                    //то консоль выводит это число
        B = B + 1;                                      //прибавляем 1  
    }
    if(inputNumberA % 2 == 0)                           //если вводимое число четное
    Console.Write(inputNumberA);                        //оно выводится в консоль
}