﻿Console.WriteLine("Введите координаты X1: ");
double x1 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Y1: ");
double y1 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Z1: ");
double z1 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты X2: ");
double x2 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Y2: ");
double y2 = Double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Z2: ");
double z2 = Double.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между двумя точками с координатами ({x1},{y1},{z1}) и ({x2},{y2},{z2}) равно в 3D пространстве {result}");