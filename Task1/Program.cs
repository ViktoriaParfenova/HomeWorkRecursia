//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от M до N. Использовать рекурсию, не использовать циклы.
   
        Console.Write("Введите значение m: "); 
        int m = Convert.ToInt32(Console.ReadLine()); 
 
        Console.Write("Введите значение n: "); 
        int n =Convert.ToInt32(Console.ReadLine()); 
 
        PrintNaturalNumbers(m, n); 
    

    static void PrintNaturalNumbers(int current, int n) 
    { 
        if (current <= n) 
        { 
            Console.Write(current + " "); 
            PrintNaturalNumbers(current + 1, n); 
        } 
    } 

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

/*
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(m, n);
Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно: {result}");


int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

*/
//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
/*

        int[] array = { 10, 20, 30, 40, 50 }; 
 
        Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(array, array.Length - 1); 
    
 
    static void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 

*/