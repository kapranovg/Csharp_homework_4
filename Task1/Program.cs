/*Напишите цикл, который принимает 
на вход два числа (A и B) 
и возводит число A в натуральную степень B. 
Реализовать через функции.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int numberA = Prompt("Введите число А");
int numberB = Prompt("Введите число B");

System.Console.WriteLine($"Число {numberA} в степени {numberB} = {numberDegree(numberA, numberB)}");

double numberDegree(int firstNumber, int secondNumber)
{
    double result = Math.Pow(firstNumber, secondNumber);
    return result;
}

int Prompt(string message)
{
    System.Console.Write(message + "> ");
    return Convert.ToInt32(Console.ReadLine());
}