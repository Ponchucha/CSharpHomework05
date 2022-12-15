/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


// метод получения числа на вход
int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int number;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Попробуй ввести что-нибудь осмысленное. У тебя получится.");
        }
    }
    return number;
}

// метод инициализации массива с рандомными элементами
int[] InitRandomArray(int dimention)
{
    int[] array = new int[dimention];
    Random rnd = new Random ();

    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next (-99, 100);
    }
    return array;
}

// метод печати массива
void PrintArray (int[] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.Write ($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

// метод подсчёта суммы нечётных элементов
int GetSumIfEvenIndex (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int dim = GetNumberFromConsole ("Введите размерность массива");
int [] arr = InitRandomArray (dim);
PrintArray(arr);
Console.WriteLine($"Сумма элементов с нечётными индексами равна {GetSumIfEvenIndex(arr)}");