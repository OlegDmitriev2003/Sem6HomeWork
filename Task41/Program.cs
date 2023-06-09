Console.Clear();
int Count = 0;
Console.Write("Введите колличество чисел: ");
int i = int.Parse(Console.ReadLine()!);
for (int n = 0; n < i; n++)
    {
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    if (num > 0)
        Count++;
    }
Console.WriteLine($"Было введено {Count} чисел больше 0 ");