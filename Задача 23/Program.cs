// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = Convert.ToInt32(Console.ReadLine());

void Cubes(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Cubes(number);