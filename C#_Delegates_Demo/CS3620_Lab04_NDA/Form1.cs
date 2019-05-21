// Project Prolog
// Name: Nathaniel Anderton
// CS3260 Section 001
// Project: Lab_04
// Date: 10/06/2018 09:44:44 AM
// Purpose: This program is created to show the functionality of delegates
// and all things concerning delegates. The program reads in inputs and
// randomly chooses a function through which to run them. The result is
// outputted as a string.
//
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Error check action if more than one letter is entered
        /// </summary>
        private void txtCharacter_TextChanged(object sender, EventArgs e)
        {
            char letter = ' ';
            if (txtCharacter.Text.Length != 0) { letter = txtCharacter.Text[0]; }
            if (txtCharacter.Text.Length > 1)
            {
                txtCharacter.Text = letter.ToString();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            TestDelegate tg = new TestDelegate();
            int num;
            int.TryParse(txtNumber.Text, out num);
            double dec;
            double.TryParse(txtPrice.Text, out dec);
            char letter;
            char.TryParse(txtCharacter.Text, out letter);
            string word = txtWord.Text;

            rtxtOutput.Text = tg.FuncReturn(num, dec, letter, word);
        }

        /// <summary>
        /// Error check action if int is not entered
        /// </summary>
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            int result;
            if(!int.TryParse(txtNumber.Text, out result)) { txtNumber.Text = ""; }
        }

        /// <summary>
        /// Error check action if double is not entered
        /// </summary>
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (!double.TryParse(txtPrice.Text, out result)) { txtPrice.Text = ""; }
        }
    }
}
