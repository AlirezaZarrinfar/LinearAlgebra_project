using System;
using System.Linq;

static class HillCypherEncrypt
{
    public static string Encrypt_Main(int len, double[,] keyMatrix, string text)
    {
        string ciphertext = Encrypt(text, keyMatrix, len);

        return ciphertext;
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

    static string Encrypt(string text, double[,] keyMatrix, int n)
    {
        double det = GaussianJordan(keyMatrix, n);
        if (det == 0)
        {
            return "NO_VALID_KEY";
        }

        text = text.Replace(" ", "_").ToUpper();
        int[] textArray = new int[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '_')
                textArray[i] = 26;
            else
                textArray[i] = text[i] - 'A';
        }

        while (textArray.Length % n != 0)
        {
            Array.Resize(ref textArray, textArray.Length + 1);
            textArray[textArray.Length - 1] = 26;
        }

        char[] ciphertext = new char[textArray.Length];

        for (int i = 0; i < textArray.Length; i += n)
        {
            for (int j = 0; j < n; j++)
            {
                double sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += keyMatrix[j, k] * textArray[i + k];
                }
                ciphertext[i + j] = (char)((sum % 27) + 'A');
                if (ciphertext[i + j] == (char)91)
                {
                    ciphertext[i + j] = '_';
                }
            }
        }

        return new string(ciphertext);
    }
}
