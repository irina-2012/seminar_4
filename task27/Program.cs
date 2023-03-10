// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
int sum = 0;

int Sum(int A)
{
while (A > 0)
{
    int result = A % 10;
    sum = sum + result;
    A = A / 10;
} return sum;
}
Console.WriteLine($"Сумма цифр в числе {A} равна -> {Sum(A)}");