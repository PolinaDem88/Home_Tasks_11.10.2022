 /*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

void GetProd()
{
    Console.WriteLine("Введите число A:");
    int Anum = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int Bnum = int.Parse(Console.ReadLine());
    int prod = 1;
    for (int i = 1; i <= Bnum; i++)
{
    prod = prod * Anum;
}
Console.WriteLine($"{Anum} в степени {Bnum} = {prod}");
}
GetProd();