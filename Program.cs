// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter 5 digits: "());
int N = Convert.ToInt32(Console.ReadLine());
if (((N - (N % 10000)) / 10000) == (N % 10) && (((N - (N % 1000)) / 1000) % 10) == (((N - (N % 10)) / 10) % 10));
{
    Console.WriteLine("OMG, it`s a real polyndrome!");
}
else
{
    Console.WriteLine("meh, not beautyful enough ( -_-)");
}