//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.WriteLine();

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 10);
printArray(array);

Console.WriteLine();

int[,] sortArray = GetChangeArray(array);
printArray(sortArray);

int[,] GetArray(int m, int c, int minValue, int maxValue)
{
    int[,] result = new int[m, c];
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < c; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void printArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

int[,] GetChangeArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)
            {
                if (matrix[i, x] < matrix[i, x + 1])
                {
                    int temp = matrix[i, x];
                    matrix[i, x] = matrix[i, x + 1];
                    matrix[i, x + 1] = temp;
                }
            }
        }
    }
    return matrix;
}