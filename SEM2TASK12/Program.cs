// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным
//первому. Если второе число некратно первому, то программа выводит о статок от деления .

//Вариант 1

int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
CalculateData();
PrintData();


//Получаем два числа от пользователя
void ReadData()
{
    Console.WriteLine("Введите первое число:");
    string inputLineA = Console.ReadLine();
    Console.WriteLine("Введите второе число:");
    string inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

//Определяем кратность чисел
void CalculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

//Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления:" + inputNumberB % inputNumberA);
    }
}



// //Вариант Константина

// Console.WriteLine("Введите первое число:");
// string? inputLineA = Console.ReadLine();
// Console.WriteLine("Введите второе число:");
// string? inputLineB = Console.ReadLine();

// int inputNumberA = int.Parse(inputLineA);
// int inputNumberB = int.Parse(inputLineB);

// Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Число B кратно A") : ("Остаток от деления:" + inputNumberB % inputNumberA));
