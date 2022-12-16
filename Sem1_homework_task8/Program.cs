Console.WriteLine("Введите число и узнайте какие числа в интервале от 1 до вашего числа являются четными");
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i < N; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine($"Четное {i}");
    }
}