// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"Натуральные числа от {M} до {N}: ");
PrintNumbers(M, N);

static void PrintNumbers(int current, int end)
    {
        if (current > end)
        {
            Console.WriteLine(); 
            return; 
        }
        
        Console.Write($"{current} "); 
        PrintNumbers(current + 1, end); 
    }


