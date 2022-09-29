// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату x точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

int[] arrA = {xA, yA, zA};
int[] arrB = {xB, yB, zB};

double ABdistance(int[] arrA, int[] arrB)
{
    double result = Math.Sqrt(Math.Pow((arrA[0] - arrB[0]), 2) + Math.Pow((arrA[1] - arrB[1]), 2) + Math.Pow((arrA[2] - arrB[2]), 2));
    return result;
}

double result = ABdistance(arrA, arrB);
Console.WriteLine(Math.Round(result, 2));