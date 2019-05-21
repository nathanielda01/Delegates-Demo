namespace Delegates_Demo
{
    partial class Form1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.rtxtOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(349, 270);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(76, 45);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(255, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtCharacter
            // 
            this.txtCharacter.Location = new System.Drawing.Point(429, 45);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(100, 20);
            this.txtCharacter.TabIndex = 3;
            this.txtCharacter.TextChanged += new System.EventHandler(this.txtCharacter_TextChanged);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(615, 45);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 4;
            // 
            // rtxtOutput
            // 
            this.rtxtOutput.Location = new System.Drawing.Point(76, 94);
            this.rtxtOutput.Name = "rtxtOutput";
            this.rtxtOutput.Size = new System.Drawing.Size(639, 118);
            this.rtxtOutput.TabIndex = 5;
            this.rtxtOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "NUMBER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CHARACTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "WORD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtOutput);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Delegates_Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.RichTextBox rtxtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

