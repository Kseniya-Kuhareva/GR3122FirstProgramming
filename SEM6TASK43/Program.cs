// 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


void Point(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * b2 - k2 * b1) / (k1 - k2);
    if (k1 == k2)
    {
        if (b1 != b2)
        {
            Console.WriteLine("Две прямые параллельны");
        }
        else
        {
            Console.WriteLine("Две прямые совпадают");
        }
    }
    else
    {
        Console.WriteLine($"Точка пересечения будет иметь координаты ({x};{y})");
    }
}
Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


Point(b1, b2, k1, k2);


