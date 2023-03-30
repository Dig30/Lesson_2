/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int result = number / 10 % 10;

// if (result < 0)
// {
//     result = result * -1;
// }

Console.WriteLine(result);

