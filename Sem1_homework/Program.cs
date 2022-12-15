Console.WriteLine("Введите два целых числа и узнайте какое больше!");
int number1, number2;
Console.WriteLine("Введите перове целое число: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
number2 = Convert.ToInt32(Console.ReadLine());

bool variant1 = number1 < number2;
bool variant2 = number1 == number2;
bool variant3 = number1 > number2;

if(variant1)
{
    Console.WriteLine($"Наибольшее число = {number2}");
}
if(variant2)
{
    Console.WriteLine($"Число {number1} равняется числу {number2}");
}
if(variant3)
{
    Console.WriteLine($"Наибольшее число = {number1}");
}