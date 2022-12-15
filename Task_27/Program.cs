Console.Clear();

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine()), n=a, c=0;
while (n > 0)
    {
    c = c + n % 10;
    n = n / 10;
    }
Console.WriteLine($"Сумма цифр чиcла {a} равна {c}");