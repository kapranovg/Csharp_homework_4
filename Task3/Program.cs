/*Напишите программу, которая выводит массив из 8 элементов, 
заполненный случайными числами. 
Оформите заполнение массива и вывод в виде функции 
(пригодится в следующих задачах).  Реализовать через функции. 
(* Доп сложность, “введите количество элементов массива”, 
“Введите минимальный порог случайных значений”, 
“Введите максимальный порог случайных значений”)*/

int number = Prompt("Введите количество элементов массива");

if (ValidateLengthArray(number))
{
    int minValue = Prompt("Введите минимальный порог случайных значений");
    int maxValue = Prompt("Введите максимальный порог случайных значений");

    PrintArray(number, minValue, maxValue);
}

bool ValidateLengthArray(int num)
{
    if (num > 0)
    {
        return true;
    }
    else
    {
        System.Console.WriteLine("Длина массива не может быть меньше 1.");
        return false;
    }
}

void PrintArray(int num, int min, int max)
{
    Random rnd = new Random();
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
        System.Console.WriteLine("Минимальный и максимальный пороги поменяны местами.");
    }
    int[] listNumbers = new int[num];
    for (int i = 0; i < listNumbers.Length; i++)
    {
        listNumbers[i] = rnd.Next(min, max + 1);
    }
    System.Console.WriteLine(string.Join(",", listNumbers));
}

int Prompt(string message)
{
    System.Console.Write(message + "> ");
    return Convert.ToInt32(Console.ReadLine());
}
