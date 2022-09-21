using static System.Console;

Clear();
Write("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Convert.ToInt32(Console.ReadLine());

if(num % num1 == 0)
{
    Write($"{num1} является кратным {num}");
}
else
{
    int num2 = num % num1;
    Write($"Остаток от деления {num2}");
}
