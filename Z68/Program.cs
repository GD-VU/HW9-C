Console.Clear();

// Ввод числа

int input(string text)
{
    System.Console.Write($"Введите {text}: ");
    int value = int.Parse(System.Console.ReadLine());
    return value;
}

// Вычисление функции Аккермана
int Akkerman(int n, int m) //функция ack(n, m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
        if ((n != 0) && (m == 0))
        {
            return Akkerman(n-1,1);
        }
        else 
        {
            return Akkerman(n-1, Akkerman(n,m-1));
        }
    return m; return n;
}


int m = input("значение M");
int n = input("значение N");
System.Console.WriteLine();
System.Console.WriteLine($"Функция А({m},{n}) = {Akkerman(m, n)}");