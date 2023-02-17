// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("ex_41");
Console.Write("Enter integer numbers separated by space: ");
string input = Console.ReadLine();


void PrintArray(int[] array)
{
    Console.Write($"{String.Join(" ", array)}\n");
}

int[] ConvertToArray(string input)
{
    string[] parts = input.Split(' ');
    int[] numbers = new int[parts.Length];

    for (int i = 0; i < parts.Length; i++)
    {
        numbers[i] = int.Parse(parts[i]);
    }

    return numbers;
}

int CountMoreZero(int[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}






int[] array = ConvertToArray(input);
Console.Write("Our array: ");
PrintArray(array);
int moreZero = CountMoreZero(array);
Console.WriteLine($"integer numbers more zero in our array: {moreZero}");




