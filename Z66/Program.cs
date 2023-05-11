﻿Console.Clear();

// Ввод числа

int input(string text)
{
    System.Console.Write($"Введите {text}: ");
    int value = int.Parse(System.Console.ReadLine());
    return value;
}

int sum = 0;

PrintSumfromMToN(number => sum += number);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел от M до N равняется {sum}");

void PrintSumfromMToN(Action<int> action)
{
    int m = input("значение M");
    int n = input("значение N");
    for (int i = m; i<=n; i++)
    {
        action(i);
    }

}

