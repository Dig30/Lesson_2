/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифрцу: ");
int number = int.Parse(Console.ReadLine());

/*Console.WriteLine(number == 6 ? "Да" : number == 7 ? "Да" : "Нет");*/


if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}



