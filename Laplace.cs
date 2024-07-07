using System;
using System.Diagnostics;

public class LaplaceDeterminantClass
{
    static double LaplaceDeterminant(double[,] matrix, int n)
    {
        if (n == 1)
        {
            return matrix[0, 0];
        }
        else if (n == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else
        {
            double det = 0.0;
            double[,] submatrix = new double[n - 1, n - 1];
            for (int i = 0; i < n; i++)
            {
                int subi = 0;
                for (int j = 1; j < n; j++)
                {
                    int subj = 0;
                    for (int k = 0; k < n; k++)
                    {
                        if (k == i) continue;
                        submatrix[subi, subj] = matrix[j, k];
                        subj++;
                    }
                    subi++;
                }
                det += Math.Pow(-1, i) * matrix[0, i] * LaplaceDeterminant(submatrix, n - 1);
            }
            return det;
        }
    }
    public static void Main()
    {
        int len = Convert.ToInt32(Console.ReadLine());
        double[,] matrix = new double[len, len];
        for (int i = 0; i < len; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int j = 0; j < len; j++)
            {
                matrix[i, j] = double.Parse(line[j]);
            }
        }
        Console.WriteLine(Math.Truncate(LaplaceDeterminant(matrix, len)));
    }
}