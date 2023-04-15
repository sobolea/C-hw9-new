
/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int n, m;
Console.Write("Введите число m: ");
int.TryParse(Console.ReadLine(), out m);

Console.Write("Введите число n: ");
int.TryParse(Console.ReadLine(), out n);



Console.Write($"M = {m}; N = {n} -> {SumNumbers(m, n)}");

int SumNumbers(int m,int n)
{


  if(m == n) return m;
  return m + SumNumbers(m+1, n);
  }