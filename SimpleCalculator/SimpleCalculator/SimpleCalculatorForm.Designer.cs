namespace SimpleCalculator
{
    partial class SimpleCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.operand1Label = new System.Windows.Forms.Label();
            this.operandTextBox1 = new System.Windows.Forms.TextBox();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.operand2Label = new System.Windows.Forms.Label();
            this.operand2TextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operand1Label
            // 
            this.operand1Label.AutoSize = true;
            this.operand1Label.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand1Label.Location = new System.Drawing.Point(81, 82);
            this.operand1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operand1Label.Name = "operand1Label";
            this.operand1Label.Size = new System.Drawing.Size(127, 30);
            this.operand1Label.TabIndex = 0;
            this.operand1Label.Text = "Operand 1:";
            // 
            // operandTextBox1
            // 
            this.operandTextBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operandTextBox1.Location = new System.Drawing.Point(302, 82);
            this.operandTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.operandTextBox1.Name = "operandTextBox1";
            this.operandTextBox1.Size = new System.Drawing.Size(143, 35);
            this.operandTextBox1.TabIndex = 1;
            this.operandTextBox1.TextChanged += new System.EventHandler(this.clearResult);
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorLabel.Location = new System.Drawing.Point(81, 166);
            this.operatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(116, 30);
            this.operatorLabel.TabIndex = 2;
            this.operatorLabel.Text = "Operator :";
            // 
            // operatorTextBox
            // 
            this.operatorTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorTextBox.Location = new System.Drawing.Point(302, 166);
            this.operatorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.Size = new System.Drawing.Size(63, 35);
            this.operatorTextBox.TabIndex = 3;
            this.operatorTextBox.TextChanged += new System.EventHandler(this.clearResult);
            // 
            // operand2Label
            // 
            this.operand2Label.AutoSize = true;
            this.operand2Label.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand2Label.Location = new System.Drawing.Point(81, 246);
            this.operand2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operand2Label.Name = "operand2Label";
            this.operand2Label.Size = new System.Drawing.Size(133, 30);
            this.operand2Label.TabIndex = 4;
            this.operand2Label.Text = "Operand 2 :";
            // 
            // operand2TextBox
            // 
            this.operand2TextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operand2TextBox.Location = new System.Drawing.Point(302, 242);
            this.operand2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.operand2TextBox.Name = "operand2TextBox";
            this.operand2TextBox.Size = new System.Drawing.Size(143, 35);
            this.operand2TextBox.TabIndex = 5;
            this.operand2TextBox.TextChanged += new System.EventHandler(this.clearResult);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(81, 330);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(91, 30);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result :";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(302, 330);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(143, 35);
            this.resultTextBox.TabIndex = 7;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(86, 436);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(154, 48);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(286, 436);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(158, 47);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SimpleCalculator
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(534, 525);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.operand2TextBox);
            this.Controls.Add(this.operand2Label);
            this.Controls.Add(this.operatorTextBox);
            this.Controls.Add(this.operatorLabel);
            this.Controls.Add(this.operandTextBox1);
            this.Controls.Add(this.operand1Label);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operand1Label;
        private System.Windows.Forms.TextBox operandTextBox1;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.Label operand2Label;
        private System.Windows.Forms.TextBox operand2TextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
    }
}

