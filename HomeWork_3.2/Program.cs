Console.WriteLine("Введите трёхзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Третьего числа не существует");
}
else
{
    num = num % 100 / 10;
}
Console.WriteLine(num);

