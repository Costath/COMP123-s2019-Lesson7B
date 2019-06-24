using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_s2019_Lesson7B
{
    public partial class HelloWorldForm : Form
    {
        /// <summary>
        /// This is the HelloWorldForm constructor.
        /// </summary>
        public HelloWorldForm()
        {
            InitializeComponent();
            Start();
        }

        /// <summary>
        /// The start method is used for property initialization.
        /// </summary>
        public void Start()
        {
            HelloWorldLabel.BackColor = Color.Black;
            HelloWorldLabel.ForeColor = Color.White;
            HelloWorldLabel.Text = "Hello, Thales";

            GenerateRandomNumber();
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            //Ternary operator
            HelloWorldLabel.Text = (HelloWorldLabel.Text == "Clicked!") ? "Unclicked!" : "Clicked!";

            GenerateRandomNumber();
        }

        /// <summary>
        /// This methods creates a random integer from 1 to 49.
        /// </summary>
        private void GenerateRandomNumber()
        {
            RandomNumberLabel.Text = (new Random().Next(1, 49) + 1).ToString();
        }
    }
}
