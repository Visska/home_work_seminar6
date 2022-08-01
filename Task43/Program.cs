/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.Clear();
Console.WriteLine("Для уравнения y = k1 * x + b1 : ");
Console.WriteLine("Введите значение b1...");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1...");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Для уравнения y = k2 * x + b2 : ");
Console.WriteLine("Введите значение b2...");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2...");
double k2 = Convert.ToDouble(Console.ReadLine());
LineIntersection(b1, k1, b2, k2);

void LineIntersection (double b1, double a1, double b2, double a2)
{
    if (a1 == a2 && b1==b2) 
    {
        Console.WriteLine("Прямые совпадают.");
        return;
    }

    if (a1 == a2)
    {
        Console.WriteLine("Решения нет.");
        return;
    }

    double x = (b2 - b1) / (a1 - a2);
    double y = a1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x};{y})");
    
}