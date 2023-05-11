Console.Clear();

// Ввод числа

int input(string text)
{
    System.Console.Write($"Введите {text}: ");
    int value = int.Parse(System.Console.ReadLine());
    return value;
}

// Проверка на положительность введеного числа

void PolojitelnostN(int number)
{
    bool work = true;
    while (work)
    {
        if (number > 0)
        {
            PrintNumbersToN(number); break;
        }
        work = false; System.Console.WriteLine("Неверное число!"); break;
    }
}

// Рекурсия, натуральные числа от N до 1

void PrintNumbersToN(int number)
{
    if (number > 0)
    {
        System.Console.Write($"{number} ");
        number = number - 1;
        PrintNumbersToN(number);
    }
}

//

int n = input("значение N");
PolojitelnostN(n);