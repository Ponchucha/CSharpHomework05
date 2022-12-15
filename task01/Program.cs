/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


// метод инициализации массива со случайными трёхзначными элементами

int[] InitRandomArray (int dimention, int capacity)
{
    int min = Convert.ToInt32 (Math.Pow (10,(capacity - 1)));
    int max = Convert.ToInt32 (Math.Pow (10,capacity));

    int[] array = new int [dimention];
    Random rnd = new Random ();

    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next (min,max);
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

// метод получения числа на ввод

int GetNumberFromConsole (string message)
{
    int number;
    Console.WriteLine (message);

    while (true)
    {
        if (int.TryParse (Console.ReadLine(), out number) && number > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Не разочаровывай меня. Попробуй ещё раз.");
        }
    }
    return number;
}

// метод подсчёта количества чётных элементов

int CountEvenInteger (int [] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }    
    }
    return count;
}


int dim = GetNumberFromConsole ("Введите размерность массива");
int cap = GetNumberFromConsole ("Введите разрядность (количество цифр) для элементов массива");
int[] arr = InitRandomArray (dim,cap);
PrintArray(arr);

Console.WriteLine ($"Количество чётных элементов в массиве равно {CountEvenInteger (arr)}");