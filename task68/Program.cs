﻿
/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int n, m;
Console.Write("Введите число m: ");
int.TryParse(Console.ReadLine(), out m);

Console.Write("Введите число n: ");
int.TryParse(Console.ReadLine(), out n);



Console.Write($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");

int Akkerman(int m,int n)
{
  if(m == 0) return n+1;
  if(n == 0 && m > 0) return Akkerman(m-1,1);
  return Akkerman(m-1, Akkerman(m, n-1));
  }