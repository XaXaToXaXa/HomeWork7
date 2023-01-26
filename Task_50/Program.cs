// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

// Console.Write("Задайте начальное значение массива: ");
// int start = int.Parse(Console.ReadLine());

// Console.Write("Задайте конечное значение массива: ");
// int end = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в строке массива: ");
int indexRow = int.Parse(Console.ReadLine());

Console.Write("Введите позицию в стоблце массива: ");
int indexColumn = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(rows, columns, 0, 10); //start, end

Console.WriteLine("");
PrintArray(myArray);
Console.WriteLine("");

if (indexRow>rows) Console.WriteLine("Такой позиции в массиве нет");
else if (indexColumn>columns) Console.WriteLine("Такой позиции в массиве нет");
else Console.WriteLine($"{myArray[indexRow, indexColumn] }"); // Для простоты отображения можно использовать -1 к индексам

// //Вариант с поиском числа
// Console.Write("Введите число для поиска в массиве: ");
// int number = int.Parse(Console.ReadLine());
// int checkNum = FindNumber(myArray, number);
// if (checkNum == 0) Console.WriteLine("В массиве нет такого числа");



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
// int FindNumber(int[,] inArray, int num)
// {
//     int count = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (num == inArray[i, j])
//             {
//                 Console.WriteLine($"Элемент находится в {i + 1} строке и {j + 1} столбце");
//                 count++;
//             }
//         }
//     }
//     return count;
// }