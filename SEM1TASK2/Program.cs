//-------------------------------------------------------
//# 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число
//большее, а какое меньшее.
//-------------------------------------------------------

string? inputLineA = Console.ReadLine();                 //вводим два числа
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)            //проверяем на null
{
    int inputNumberA = int.Parse(inputLineA);            //делаем числа вещественными
    int inputNumberB = int.Parse(inputLineB);

    if (inputNumberA > inputNumberB)                     // условие (если неравенство верно)
    {
        Console.Write("max = ");                         //в результат выводим это число
        Console.Write(inputLineA);
    }
    else                                                 //а иначе
    {
        Console.Write("max = ");                        // в результат выводим это число
        Console.Write(inputLineB);
    }
}                                                      