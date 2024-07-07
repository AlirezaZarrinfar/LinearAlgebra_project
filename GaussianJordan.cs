using System;
using System.Diagnostics;

public class GaussianJordanDeterminantClass
{

    public static double GaussianJordan(double[,] matrix, int n)
    {
        double det = 1;
        double[,] temp = new double[n, n];
        int total_swaps = 0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                temp[i, j] = matrix[i, j];

        for (int i = 0; i < n - 1; i++)
        {
            int max_row = i;

            for (int j = i + 1; j < n; j++)
                if (Math.Abs(temp[j, i]) > Math.Abs(temp[max_row, i]))
                    max_row = j;

            if (max_row != i)
            {
                total_swaps++;
                for (int k = 0; k < n; k++)
                {
                    double temp_val = temp[i, k];
                    temp[i, k] = temp[max_row, k];
                    temp[max_row, k] = temp_val;
                }
            }

            if (temp[i, i] == 0)
                return 0;

            for (int j = i + 1; j < n; j++)
            {
                double factor = temp[j, i] / temp[i, i];

                for (int k = i + 1; k < n; k++)
                    temp[j, k] -= factor * temp[i, k];
            }
        }

        for (int i = 0; i < n; i++)
            det *= temp[i, i];

        if (total_swaps % 2 != 0)
            det = -det;

        return det;
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
        Console.WriteLine(Math.Truncate(GaussianJordan(matrix, len)));
    }
}


5
1 2 3 4 5
6 7 8 9 10
11 12 15 17 28
21 23 4 5 3
41 42 5 7 8