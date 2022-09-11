// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
while (N / 10000 == 0 || N / 100000 != 0)
{
    Console.WriteLine("Число не пятизначное");
    N = Convert.ToInt32(Console.ReadLine());
}
if (N / 10000 == N % 10 & N / 1000 % 10 == N % 100 / 10)
    Console.WriteLine("Число является палиндромом"); 
else
    Console.WriteLine("Число не является палиндромом");
