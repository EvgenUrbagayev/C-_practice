
Console.Clear();
Console.Write("Введите число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num2 * num2;
if(num1 == result)
{
    Console.WriteLine($" {num1} является квадратом {num2}");
}
else
{
    Console.WriteLine($" {num1} не является квадратом {num2}");
}