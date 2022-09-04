//Напишите программу, которая будт принимать на вход два числа и
// выводить, является ли второе число кратным первому. 
// Если число 2 
// не кратно числу 1, то программа выводит остаток от деления.

Console.Write("Первое число:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Второе число:");
int x2 = int.Parse(Console.ReadLine());

int ost = x1 % x2;

if (ost == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine(ost);


