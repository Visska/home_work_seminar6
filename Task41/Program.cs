/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
Console.Clear();
Console.WriteLine("Укажите сколько чисел вы хотите ввести (число М): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нужные числа: ");
int count = 0;
for (int i = 0; i < m; i++)
{
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber > 0)
    {
        count++;
    }
}
Console.WriteLine($"Введённых вами чисел больше 0 -> {count}.");
