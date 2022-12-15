Console.Clear();

Console.WriteLine("Введите через пробел два числа, где 1-е это производное, а 2-е степень");
string[] array = Console.ReadLine().Split(" ");
int a = int.Parse(array[0]);
int b = int.Parse(array[1]);
int c = 1;

for (int i = 1; i <= b; i++)
    c = c * a;
Console.WriteLine($"Число {a} в степени {b} равно {c}");
