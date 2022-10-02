// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Программа, показывающая количество чётных чисел в массиве, заполненном случайными положительными трёхзначными числами.");

int size = 0;

while (true)
{
    Console.Write("\nНапишите - из скольки элементов должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            size = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
}

int[] array = FillArray(size, 100, 1000);
Console.Write("\nВ сгенерированном массиве");
PrintArray(array);
Console.WriteLine(" количество чётных чисел - " + CountEven(array));


int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        filledArray[index] = new Random().Next(min, max);
    }
    return filledArray;
}

void PrintArray(int[] array)
{
    Console.Write(" [" + String.Join(", ", array) + "]");
}

int CountEven(int[] array)
{
    int count = 0;
    for (int index = 0; index < size; index++)
    {
        if (array[index] % 2 == 0) count++;
    }
    return count;
}