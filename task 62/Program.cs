// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] matrix = new int[4, 4];

for (int firstRowIndex = 0; firstRowIndex < 4; firstRowIndex++)
{
    Console.WriteLine($"Введите значение столбца {firstRowIndex + 1} первой строки");
    matrix[0, firstRowIndex] = Convert.ToInt32(Console.ReadLine());
}

for (int lastColumnIndex = 1; lastColumnIndex < 4; lastColumnIndex++)
{
    Console.WriteLine($"Введите значение строки {lastColumnIndex + 1} последнего столбца");
    matrix[lastColumnIndex, 3] = Convert.ToInt32(Console.ReadLine());
}

for (int lastRowIndex = 2; lastRowIndex >= 0; lastRowIndex--)
{
    Console.WriteLine($"Введите значение столбца {lastRowIndex + 1} последней строки");
    matrix[3, lastRowIndex] = Convert.ToInt32(Console.ReadLine());
}

for (int firstColumnIndex = 2; firstColumnIndex > 0; firstColumnIndex--)
{
    Console.WriteLine($"Введите значение строки {firstColumnIndex + 1} первого столбца");
    matrix[firstColumnIndex, 0] = Convert.ToInt32(Console.ReadLine());
}

for (int secondRowIndex = 1; secondRowIndex < 3; secondRowIndex++)
{
    Console.WriteLine($"Введите значение столбца {secondRowIndex + 1} второй строки");
    matrix[1, secondRowIndex] = Convert.ToInt32(Console.ReadLine());
}

for (int thirdRowIndex = 2; thirdRowIndex > 0; thirdRowIndex--)
{
    Console.WriteLine($"Введите значение столбца {thirdRowIndex + 1} третьей строки");
    matrix[2, thirdRowIndex] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("В итоге получилась матрица: ");
//printMatrixOfIntegersToConsole(matrix);