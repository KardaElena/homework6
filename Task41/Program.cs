// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -7, 567, 89, 223-> 3


int CountPositiveNumbers(int[] array)
{
    int[] arr = array;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Clear();

Console.WriteLine("Введите количество чисел: ");
int lenght = int.Parse(Console.ReadLine() ?? "0");

if (lenght <= 0)
{
    Console.WriteLine("Количество не может быть отрицательным. Введите положительное число: ");
    lenght = int.Parse(Console.ReadLine() ?? "0");
}

int[] numbers = new int[lenght];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("\nВведите число: ");
    numbers[i] = int.Parse(Console.ReadLine() ?? "0");
}

int countPositive = CountPositiveNumbers(numbers);
Console.WriteLine($"\nЧисло положительных числе в вашем наборе: {countPositive}");
Console.WriteLine();
