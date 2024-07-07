namespace Encrypt_DecryptProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dimNumbers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exampleTxt = new System.Windows.Forms.TextBox();
            this.EncButton = new System.Windows.Forms.Button();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.DecButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dimNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // dimNumbers
            // 
            this.dimNumbers.Location = new System.Drawing.Point(92, 13);
            this.dimNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dimNumbers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimNumbers.Name = "dimNumbers";
            this.dimNumbers.Size = new System.Drawing.Size(98, 23);
            this.dimNumbers.TabIndex = 0;
            this.dimNumbers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dim : ";
            // 
            // mainTxt
            // 
            this.mainTxt.Location = new System.Drawing.Point(238, 10);
            this.mainTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTxt.Multiline = true;
            this.mainTxt.Name = "mainTxt";
            this.mainTxt.Size = new System.Drawing.Size(423, 306);
            this.mainTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "example for 4 * 4 matrix : ";
            // 
            // exampleTxt
            // 
            this.exampleTxt.Location = new System.Drawing.Point(35, 88);
            this.exampleTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exampleTxt.Multiline = true;
            this.exampleTxt.Name = "exampleTxt";
            this.exampleTxt.Size = new System.Drawing.Size(155, 97);
            this.exampleTxt.TabIndex = 4;
            // 
            // EncButton
            // 
            this.EncButton.Location = new System.Drawing.Point(35, 239);
            this.EncButton.Name = "EncButton";
            this.EncButton.Size = new System.Drawing.Size(155, 49);
            this.EncButton.TabIndex = 5;
            this.EncButton.Text = "Encrypt";
            this.EncButton.UseVisualStyleBackColor = true;
            this.EncButton.Click += new System.EventHandler(this.EncButton_Click);
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(318, 335);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(342, 23);
            this.inputTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "input text : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "output text : ";
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(318, 364);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(342, 23);
            this.outputTxt.TabIndex = 8;
            // 
            // DecButton
            // 
            this.DecButton.Location = new System.Drawing.Point(35, 294);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(155, 49);
            this.DecButton.TabIndex = 10;
            this.DecButton.Text = "Decrypt";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 405);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.EncButton);
            this.Controls.Add(this.exampleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimNumbers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Hill Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.dimNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown dimNumbers;
        private Label label1;
        private TextBox mainTxt;
        private Label label2;
        private TextBox exampleTxt;
        private Button EncButton;
        private TextBox inputTxt;
        private Label label3;
        private Label label4;
        private TextBox outputTxt;
        private Button DecButton;
    }
}