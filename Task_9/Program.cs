using static System.Console;

Clear();
Write("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 7 == 0)
{
    if(num % 23 == 0)
    Write($"{num} кратно числам 7 и 23");

}
else
{
    Write($"{num} не является кратно числам 7 и 23");
}