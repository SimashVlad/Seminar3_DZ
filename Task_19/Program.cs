/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

// Универсальная программа
Console.WriteLine("Введите число");
var n = (Console.ReadLine());
if (n.Reverse().SequenceEqual(n)) Console.WriteLine("Палиндром");
else
{
    Console.WriteLine("Не палиндром");
}


/* Console.WriteLine("Введите размерность массива = ");
int n = int.Parse(Console.ReadLine());
int[] masiv = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write(i + " элемент = ");
    masiv[i] = int.Parse(Console.ReadLine());
}
if (masiv[4] == masiv[0] & masiv[3] == masiv[1]) // (пока не разобрался как сделать универсально)
    if (masiv[index] == masiv[index2])
    {
        Console.WriteLine("Число является полиндромом");
    }
    else
    {
        Console.WriteLine("Число не является полиндромом");
    } */