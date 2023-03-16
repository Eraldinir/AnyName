// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Enter 5 digits: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (((N - (N % 10000)) / 10000) == (N % 10) && (((N - (N % 1000)) / 1000) % 10) == (((N - (N % 10)) / 10) % 10))
// {
//     Console.WriteLine("OMG, it`s a real polyndrome!");
// }
// else
// {
//     Console.WriteLine("meh, not beautyful enough ( -_-)");
// }
//=================================================================================================================================
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Enter X1 coordinate: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Y1 coordinate: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Z1 coordinate: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter X2 coordinate: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Y2 coordinate: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Z2 coordinate: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);
// Console.WriteLine("Distance = " + d);
//=================================================================================================================================
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }
//=================================================================================================================================
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.Write("Enter a number: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter it`s power: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(A,B));
//=================================================================================================================================
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (num > 0)
// {
//     count = count + num % 10;
//     num = (num - (num % 10)) / 10;  
// }
// Console.WriteLine("Sum of elements = " + count);
//=================================================================================================================================
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-1000, 1000);   // я же правильно понял? Просто генерация случайного массива, а не ввод восьми чисел с руки?
//     Console.Write(array[i] + ", "); 
// }
//=================================================================================================================================
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[30];     // я не знаю какой длинны должен быть массив...
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);  
//     if (array[i] % 2 == 0)
//     {
//         count++; 
//     }
//     Console.Write($"{array[i]}, ");
// } 
// Console.Write($"In array there are {count} even numbers");

//=================================================================================================================================
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] array = new int[30];
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-1000, 1000);
//     if (i % 2 == 1)
//     {
//         sum = sum + array[i];
//     }
//     Console.Write($"{array[i]}, ");
// }
// Console.Write($"----> {sum} IS SUMM ! ");
