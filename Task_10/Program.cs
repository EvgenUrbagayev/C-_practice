using static System.Console;

Clear();
Write("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Convert.ToInt32(Console.ReadLine());

if(num == num1 * num1)
{
    Write($"{num} является квадратом {num1}");
}
else
{
if(num1 == num * num)
{
    Write($"{num1} является квадратом {num}");
}

else
{
    Write($"{num1} не является квадратом {num} и {num} не является квадратом {num1}");
}
}