// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите первое число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число B: ");
int B = int.Parse(Console.ReadLine());
int result = 1 ;
void Stepen (int A, int B) 
{
    for (int i = 0; i < B; i++)
    {
        result = result * A;
        
    } Console.WriteLine($"{A},{B} -> {result}");
}
Stepen (A, B);