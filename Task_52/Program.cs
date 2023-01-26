// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество стоблцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 10); //start, end

Console.WriteLine("");
PrintArray(myArray);
Console.WriteLine("");

for (int i = 0; i < columns; i++)
{
    double average = 0;
    for (int j = 0; j < rows; j++)
    {
        average += myArray[j, i];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {average / rows:F2}");
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}