﻿Console.WriteLine("Введите число от 1го до 7 ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}