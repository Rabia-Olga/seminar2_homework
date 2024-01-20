//Задача 3
//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
//40 => 4, 96 => 9, 72 => 7

int a = 72;
int maxdigit = 0;
if ( 10 < a && a < 99 )
{
   int firstdigit = a / 10;
   int seconddigit = a % 10;
   if (firstdigit > seconddigit)
   { maxdigit = firstdigit; }
   else { maxdigit = seconddigit; }
}
Console.Write($"наибольшая цифра числа {maxdigit}");



