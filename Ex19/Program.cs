//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите целое пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine() ?? "0");
string numberstr = Convert.ToString(n);
if (n < 10000 | n > 100000)
{
    Console.WriteLine("Введено неверное число");
}
else
{
    if(numberstr[4] == numberstr[0] && numberstr[3] == numberstr[1])
    {
        Console.WriteLine($"Число {n} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {n} не является палиндромом");
    }
}
