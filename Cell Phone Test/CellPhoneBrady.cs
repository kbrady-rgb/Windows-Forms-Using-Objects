using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : Cell Phone
* Author      : Kabrina Brady
* Created     : 10/20/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : Program makes an object based on user input
*               Input:  Brand, model, price, button clicks
*               Output: Brand, model, price
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace Cell_Phone_Test
{
    public partial class CellPhoneBrady : Form
    {
        public CellPhoneBrady()
        {
            InitializeComponent();
        }

        //The GetPhoneData method accepts a CellPhone object as an argument. It assigns the data entered by the user to the object's properties.
        private void GetPhoneData(CellPhone phone)
        {
            //temporary variable to hold price
            decimal price;

            //get the phone's brand and ensures it's Samsung, Apple, or Google
            if (brandTextBox.Text == "Samsung" || brandTextBox.Text == "samsung" || brandTextBox.Text == "Apple" || brandTextBox.Text == "apple" || brandTextBox.Text == "Google" || brandTextBox.Text == "google")
            {
                phone.Brand = brandTextBox.Text;
            }
            else
            {
                MessageBox.Show("Enter Samsung, Apple, or Google for the brand.");
            }

            //get the phone's model and ensures it's X, 8, Note, or Pixel
            if (modelTextBox.Text == "X" || modelTextBox.Text == "x" || modelTextBox.Text == "Note" || modelTextBox.Text == "note" || modelTextBox.Text == "8" || modelTextBox.Text == "Pixel" || modelTextBox.Text == "pixel")
            {
                phone.Model = modelTextBox.Text;
            }
            else
            {
                MessageBox.Show("Enter X, Note, 8, or Pixel for model.");
            }

            //get the phone's price
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                int MIN = 0;
                int MAX = 2000;

                if (price < MIN || price > MAX) //ensures price is between 0 and 2000
                {
                    MessageBox.Show("Enter a number between 0 and 2000.");
                }
                else
                {
                    phone.Price = price;
                }
            }
            else
            {
                //display error message
                MessageBox.Show("Invalid price");
            }
        }

        private void CreateObjectButton_Click(object sender, EventArgs e)
        {
            //create a CellPhone object
            CellPhone myPhone = new CellPhone();

            //get the phone data
            GetPhoneData(myPhone);

            //display phone data
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
}
