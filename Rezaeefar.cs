using System;
using System.Diagnostics;

public class RezaeefarDeterminantClass
{
    static double Rezaeefar(int len, double[,] matrix, int m, int n, int p, int q)
    {
        if (p - m == 1)
        {
            return matrix[m - 1, n - 1] * matrix[p - 1, q - 1] - matrix[p - 1, n - 1] * matrix[m - 1, q - 1];
        }
        else if (p - m == 0)
        {
            return matrix[m - 1, n - 1];
        }
        else if (p - m > 1)
        {
            int p1 = p - 1;
            int q1 = q - 1;
            int m1 = m + 1;
            int n1 = n + 1;

            double dt1 = Rezaeefar(len, matrix, m, n, p1, q1);
            double dt2 = Rezaeefar(len, matrix, m1, n1, p, q);
            double dt3 = Rezaeefar(len, matrix, m, n1, p1, q);
            double dt4 = Rezaeefar(len, matrix, m1, n, p, q1);
            double dt5 = Rezaeefar(len, matrix, m1, n1, p1, q1);

            return (dt1 * dt2 - dt3 * dt4) / dt5;
        }

        return 0.0;
    }
    public static void Main()
    {
        double result;
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
        while (true)
        {
            result = Rezaeefar(len, matrix, 1, 1, len, len);
            if (result.ToString() == "NaN")
            {
                for (int j = 1; j < len; j++)
                {
                    int row1 = len - j;
                    int row2 = (len - j) / 2;
                    for (int i = 0; i < len; i++)
                    {
                        double temp = matrix[row1, i];
                        matrix[row1, i] = matrix[row2, i];
                        matrix[row2, i] = temp;
                    }
                    int col1 = len - j;
                    int col2 = (len - j) / 2;
                    for (int z = 0; z < len; z++)
                    {
                        double temp = matrix[z, col1];
                        matrix[z, col1] = matrix[z, col2];
                        matrix[z, col2] = temp;
                    }
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(Math.Truncate(result));
    }
}
