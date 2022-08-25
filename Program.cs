// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение переменной b1");
double firstNumber = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите значение переменой k1");
double secondNumber = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите значение переменной b2");
double thirdNumber = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите значение переменной k2");
double fourthNumber = Convert.ToInt64(Console.ReadLine());

double tempX = fourthNumber - secondNumber;
double numberX = -thirdNumber + firstNumber;
double cordinatesX = numberX / tempX;

double cordinatesY = fourthNumber * cordinatesX + thirdNumber;
Console.WriteLine($"Точкой пересечения прямых являются кординаты х = {cordinatesX} y = {cordinatesY}");