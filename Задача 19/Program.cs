// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string PalindromeCheck(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = number / 1000 % 10;
    int fourthDigit = number / 10 % 10;
    int fifthDigit = number % 10;
    string result = String.Empty;
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        result = result + "да";
    }
    else
    {
        result = result + "нет";
    }
    return result;
}

Console.Write("Введите пятизначное число для проверки, является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = PalindromeCheck(number);
Console.WriteLine(result);