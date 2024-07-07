namespace Encrypt_DecryptProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            exampleTxt.Text = "1 2 3 4 " + 
                Environment.NewLine + 
                "5 6 7 8 " +
                Environment.NewLine +
                "9 10 11 12"+
                Environment.NewLine +
                "13 14 15 16";
            exampleTxt.Enabled = false;
            outputTxt.Enabled= false;
        }

        private void EncButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dim = (int)dimNumbers.Value;
                if (dim > 10)
                {
                    MessageBox.Show("Dimantion of matrix is too large");
                }
                if (string.IsNullOrEmpty(mainTxt.Text) || string.IsNullOrEmpty(inputTxt.Text))
                {
                    MessageBox.Show("Please fill the text boxes");
                }
                double[,] matrix = new double[dim, dim];
                for (int i = 0; i < dim; i++)
                {
                    var line = mainTxt.Lines[i].Split(" ");
                    for (int j = 0; j < dim; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(line[j]);
                    }
                }
                string enctext = HillCypherEncrypt.Encrypt_Main(dim, matrix, inputTxt.Text.Replace(" ", "_"));
                outputTxt.Text = enctext;
            }
            catch
            {
                MessageBox.Show("There is a problem");
            }
        }

        private void DecButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dim = (int)dimNumbers.Value;
                if (dim > 10)
                {
                    MessageBox.Show("Dimantion of matrix is too large");
                }
                if (string.IsNullOrEmpty(mainTxt.Text) || string.IsNullOrEmpty(inputTxt.Text))
                {
                    MessageBox.Show("Please fill the text boxes");
                }
                double[,] matrix = new double[dim, dim];
                for (int i = 0; i < dim; i++)
                {
                    var line = mainTxt.Lines[i].Split(" ");
                    for (int j = 0; j < dim; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(line[j]);
                    }
                }
                string dectext = HillCipherDecrypt.Decrypt(dim, matrix, inputTxt.Text);
                outputTxt.Text = dectext;
            }
            catch
            {
                MessageBox.Show("There is a problem");
            }
        }
    }
}