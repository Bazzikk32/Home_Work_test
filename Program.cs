
// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void FromMToN(int n, int m)
{
    if (n > m)
    {
        FromMToN(n - 1, m);
        System.Console.Write(n);
    }
    else
    {
        if (m > n)
        {
            FromMToN(n, m - 1);
            System.Console.Write(m);
        }
        else System.Console.Write(n);
    }
}

FromMToN(1, 5);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int Akkerman(int n, int m)
{

    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return Akkerman(n - 1, 1);
        else
            return Akkerman(n - 1, Akkerman(n, m - 1));
    }

}

System.Console.WriteLine(Akkerman(2, 5));

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ShowArray(int[] MyArray, int i = 0)
{

    if (i < MyArray.Length)
    {
        ShowArray(MyArray, i + 1);
        System.Console.WriteLine(MyArray[i]);
    }
}
int[] MyArray = { 2, 3, 4, 5, 5 };
ShowArray(MyArray);

