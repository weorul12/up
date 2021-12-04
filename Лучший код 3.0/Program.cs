using System;

// класс с методами расширения
static class MatrixExt
{
    // метод расширения для получения количества строк матрицы
    public static int RowsCount(this int[,] matrix)
    {
        return matrix.GetLength(0);
    }

    // метод расширения для получения количества столбцов матрицы
    public static int ColumnsCount(this int[,] matrix)
    {
        return matrix.GetLength(1);
    }
}

class Program
{
    // метод для получения матрицы из консоли
    static int[,] GetMatrixFromConsole(string name)
    {
        Console.Write("Количество строк матрицы {0}:    ", name);
        var r = int.Parse(Console.ReadLine());
        Console.Write("Количество столбцов матрицы {0}: ", name);
        var c = int.Parse(Console.ReadLine());

        var matrix = new int[r, c];
        for (var i = 0; i < r; i++)
        {
            for (var j = 0; j < c; j++)
            {
                Console.Write("{0}[{1},{2}] = ", name, i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    // метод для вывода матрицы на экран
    static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.RowsCount(); i++)
        {
            for (var j = 0; j < matrix.ColumnsCount(); j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }

            Console.WriteLine();
        }
    }

    // метод для сложения двух матриц
    static int[,] MatrixSum(int[,] matrixA, int[,] matrixB)
    {
        if ((matrixA.ColumnsCount() != matrixB.ColumnsCount()) || (matrixA.RowsCount() != matrixB.RowsCount()))
        {
            throw new Exception("Для матриц с разным размером сложение не возможно!");
        }

        var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

        for (var i = 0; i < matrixA.RowsCount(); i++)
        {
            for (var j = 0; j < matrixB.ColumnsCount(); j++)
            {
                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return matrixC;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Программа для сложения двух матриц");

        var a = GetMatrixFromConsole("A");
        var b = GetMatrixFromConsole("B");

        Console.WriteLine("Матрица A:");
        PrintMatrix(a);

        Console.WriteLine("Матрица B:");
        PrintMatrix(b);

        var result = MatrixSum(a, b);
        Console.WriteLine("Сумма матриц:");
        PrintMatrix(result);

        Console.ReadLine();
    }
}

