﻿//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

void Koordinat()
{
Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; ");

Console.Write("Введите значение для k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение для b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение для k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение для b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1*x + b1;
Console.WriteLine($"Координаты точки пересечения двух прямых: X = {x}, Y = {y}");
}
Koordinat();
Koordinat();