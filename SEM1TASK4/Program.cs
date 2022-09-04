// # 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

string? inputLineA = Console.ReadLine();                 //вводим три числа
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null)       //проверяем на null

{
    int inputNumberA = int.Parse(inputLineA);                //делаем числа вещественными
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberС = int.Parse(inputLineC);

    if (inputNumberA > inputNumberB)                         //условие (если неравенство верное)
        if (inputNumberA > inputNumberС)                      
        {
            Console.Write("max = ");                         //выводим число
            Console.Write(inputLineA);
        }
        else                                                 //иначе
        {
            Console.Write("max = ");                        //выводим число
            Console.Write(inputLineC);
        }
    else                                             //иначе
    {
        if (inputNumberB > inputNumberС)                         //если неравенство верное
        {
            Console.Write("max = ");                         //выводим чсило
            Console.Write(inputLineB);
        }
        else                                                     //иначе
        {
            Console.Write("max = ");                        //выводим число
            Console.Write(inputLineC);
        }
    }                                                    //получаем длинный некрасивый код
}