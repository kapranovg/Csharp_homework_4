/*Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе. Реализовать через функции.

452 -> 11
82 -> 10
9012 -> 12*/

int number = Prompt("Введите число N");

if (Validate(number))
{
    sumRankNumber(number);
}

void sumRankNumber(int num)
{
    int sumRank = 0;
    int preNum = num;
    for (int i = 1; i <= num; i++)
    {
        sumRank += num % 10;
        num = num/10;
    }
    System.Console.WriteLine($"Сумма цифр в числе {preNum} = {sumRank}");
}

bool Validate(int num)
{
    if (number >= 0)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Введённое число меньше 0. " 
        + "Перезапустите программу и введите не отрицательное число.");
        return false;
    }
}

int Prompt(string message)
{
    System.Console.Write(message + "> ");
    return Convert.ToInt32(Console.ReadLine());
}