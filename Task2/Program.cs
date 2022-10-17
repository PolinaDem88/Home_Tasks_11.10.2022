/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("Введите число");

int number = Int32.Parse(Console.ReadLine());
int summ = 0;
while(number > 0)
{
    summ = summ + 1;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр в числе {summ}");