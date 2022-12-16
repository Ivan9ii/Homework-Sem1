Console.WriteLine("Введите число и узнайте,являетя ли оно четным");
int number;
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());


if(number % 2 == 0)
{
    Console.WriteLine($"число {number} - четное");
}
else
{
    Console.WriteLine($"число {number} не является четным");
}