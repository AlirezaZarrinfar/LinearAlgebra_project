using System;
using System.Diagnostics;

public class HillCipherDecrypt
{
    static double[,] Cofactor(int len, double[,] matrix)
    {
        var cofMatrix = new double[len,len];
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                var temp = new double[len-1, len-1];
                int ci = 0;
                int cj = 0;
                for (int k = 0; k < len; k++)
                {
                    for (int z = 0; z < len; z++)
                    {
                        if (k != i && z != j)
                        {
                            temp[ci, cj] = matrix[k, z];
                            if (cj != len - 2)
                            {
                                cj++;
                            }
                            else if (ci == len - 2)
                            {
                                cj = 0;
                            }
                            else 
                            {
                                cj = 0;
                                ci++;
                            }
                        }
                    }
                }

                var det = GaussianJordan(temp,len-1);
                cofMatrix[i, j] = (Math.Pow(-1, i + j) * det) % 27 < 0 ? ((Math.Pow(-1, i + j) * det) % 27) + 27 : (Math.Pow(-1, i + j) * det) % 27;
            }
        }
        return cofMatrix;
    }
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

    public static string Decrypt(int len, double[,] matrix,string encryptedText)
    {
        var matInverse = new double[len,len];
        var det = Math.Round(GaussianJordan(matrix, len)) % 27 < 0 ? (Math.Round(GaussianJordan(matrix, len)) % 27) + 27 : (Math.Round(GaussianJordan(matrix, len)) % 27);
        for (int i = 0; i < 100; i++)
        {
            var mod = (i * det) % 27 < 0 ? ((i * det) % 27) + 27 : ((i * det) % 27);
            if (mod == 1)
            {
                det = i;
                break;
            }
        }
        var cofactor = Cofactor(len, matrix);
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                matInverse[i, j] =  (det * cofactor[j, i]) % 27 < 0? (det * cofactor[j, i]) % 27 + 27 : (det * cofactor[j, i]) % 27;
            }
        }

        int[] encryptedNumbers = new int[encryptedText.Length];
        for (int i = 0; i < encryptedText.Length; i++)
        {
            if (encryptedText[i] == '_')
                encryptedNumbers[i] = 26;
            else
                encryptedNumbers[i] = encryptedText[i] - 'A';
        }

        int[] decryptedNumbers = new int[encryptedText.Length];
        for (int i = 0; i < encryptedText.Length; i += len)
        {
            for (int j = 0; j < len; j++)
            {
                double sum = 0;
                for (int k = 0; k < len; k++)
                {
                    sum += matInverse[j, k] * encryptedNumbers[i + k];
                }
                decryptedNumbers[i + j] = (int)Math.Round(sum) % 27;
                if (decryptedNumbers[i + j] < 0)
                {
                    decryptedNumbers[i + j] += 27;
                }
            }
        }

        char[] decryptedText = new char[decryptedNumbers.Length];
        for (int i = 0; i < decryptedNumbers.Length; i++)
        {
            if (decryptedNumbers[i] == 26)
                decryptedText[i] = '_';
            else
                decryptedText[i] = (char)(decryptedNumbers[i] + 'A');
        }
        
        for (int i = decryptedText.Length - 1; i < decryptedText.Length; i--)
        {
            if (decryptedText[i] == '_')
            {
                decryptedText[i] = ' ';
            }
            else
            {
                break;
            }
        }

        return new string(decryptedText);

    }
}
