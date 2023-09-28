// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите положительное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

AF(m,n);

void AF(int m, int n)
{
    Console.Write(AkkF(m, n)); 
}

int AkkF(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkF(m - 1, 1);
    }
    else
    {
        return (AkkF(m - 1, AkkF(m, n - 1)));
    }
}




