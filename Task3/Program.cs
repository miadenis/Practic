// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrayInReverse(array, array.Length - 1);

static void PrintArrayInReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    PrintArrayInReverse(array, index - 1);
}

