/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// метод приёма числа на ввод
int GetNumberFromConsole (string message)
{
    int result;
    Console.WriteLine (message);

    while(true)
    {
        if (int.TryParse (Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Не надо так. Введите положительное число");
        }
    }
    return result;
}

// метод инициализации массива с ручным вводом элементов

double[] GetArrayFromConsole (int dimention)
{
    double[] array = new double [dimention];
    for (int i = 0; i < dimention; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i+1}");
        while(true)
        {
            if (double.TryParse(Console.ReadLine(), out array[i]))
            {
                break;
            }
            else
            {
                Console.WriteLine("Это в массив не засунуть. Он не такой. Введите число.");
            }
        }
    }
    return array;
}

// метод печати массива
void PrintArray (double[] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.Write ($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

// метод посика максимального и минимального значения (с кортежем)
(double, double) GetMInMax(double [] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    }
    return (min, max);
}

int dim = GetNumberFromConsole("Введите размерность массива");
double[] arr = GetArrayFromConsole(dim);
PrintArray(arr);
(double minimum, double maximum) = GetMInMax(arr);
Console.WriteLine($"Минимальный элемент массива равен {minimum}, максимальный элемент равен {maximum}.");
Console.WriteLine($"{maximum} - {minimum} = {maximum - minimum}");