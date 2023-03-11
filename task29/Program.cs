// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Random rand = new Random();
int[] array = new int[rand.Next(1,8)];
int n = array.Length;
int index = 0;

void Array(int[] array)
{
    Console.Write("[");
    for (; index < n - 1; index++)
    {
        array[index] = rand.Next(100);
        Console.Write($"{array[index]}, ");
    }
    Console.Write($"{array[index]}]");
}
Array(array);
