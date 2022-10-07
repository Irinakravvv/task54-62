// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.


void fillMatrixWithRandomPositiveIntegers(int[,] matrix)
{
    Random rnd = new Random();
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = rnd.Next(0, 10);
        }
    }
}

void printMatrixOfIntegersToConsole(int[,] matrix)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        Console.Write("\n");
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            Console.Write($"  {matrix[rowIndex, columnIndex]}");
        }
    }
    Console.Write("\n");
}

Console.WriteLine("Введите количество строк матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.WriteLine("Некорректные значения");
}
else
{
    int[,] matrix = new int[m, n];
    fillMatrixWithRandomPositiveIntegers(matrix);
    printMatrixOfIntegersToConsole(matrix);

    // insertion sort
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        int columnCount = matrix.GetLength(1);
        if (columnCount < 2)
        {
            break;
        }
        if (matrix[rowIndex, 0] < matrix[rowIndex, 1])
        {
            int temp = matrix[rowIndex, 0];
            matrix[rowIndex, 0] = matrix[rowIndex, 1];
            matrix[rowIndex, 1] = temp;
        }
        for (int unsorted = 2; unsorted < columnCount; unsorted++)
        {
            for (int sorted = 0; sorted < unsorted; sorted++)
            {
                if (matrix[rowIndex, unsorted] > matrix[rowIndex, sorted])
                {
                    int temp = matrix[rowIndex, unsorted];
                    matrix[rowIndex, unsorted] = matrix[rowIndex, sorted];
                    matrix[rowIndex, sorted] = temp;
                }
            }
        }
    }
    Console.WriteLine("Матрица отсортированных строк:");
    printMatrixOfIntegersToConsole(matrix);
}
