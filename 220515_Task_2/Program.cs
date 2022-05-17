// 2. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double DistAB(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2)), 2);
}


double XA = 3; double YA = 6; double ZA = 0;
double XB = 2; double YB = 1; double ZB = 0;
Console.WriteLine($"The distance between points"); 
Console.WriteLine($"A (coordinates: x = {XA}, y = {YA}, z = {ZA}) and");
Console.WriteLine($"B (coordinates: x = {XB}, y = {YB}, z = {ZB})");
Console.WriteLine($"= {DistAB(XA, YA, ZA, XB, YB, ZB)}.");

