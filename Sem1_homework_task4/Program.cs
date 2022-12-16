Console.WriteLine("Введите три целых числа и узнайте какое больше!");
int number1, number2, number3, max;
Console.WriteLine("Введите перовое целое число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
number3 = Convert.ToInt32(Console.ReadLine());
max = number1;

if(max < number2)
{
    max = number2;
}
else
{
    if(max == number2)
     {
         max = max;
     }
}
if(max < number3)
{
    max = number3;
}
else
{
    if(max == number3)
     {
         max = max;
     }
}
Console.WriteLine($"Максимальным является число {max}");