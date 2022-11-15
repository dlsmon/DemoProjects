using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Vehicle> Vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ask user how many cars(n) that will participate
            int numberOfCars = 0;
            Console.WriteLine("Enter the Race!");
            int result;
            if (!Int32.TryParse(textBox1.Text, out result))
            {
                //not number not between 2 and 10
                //Rouge warning sign
                labelWarningMessage.Text = "Input must be a number";
                labelWarningMessage.Visible = true;
            }
            else
            {
                if (Int32.Parse(textBox1.Text) < 11 && Int32.Parse(textBox1.Text) > 2)
                {
                    //START RACEEE
                    labelWarningMessage.Visible = false;
                    labelSuccessMessage.Visible = true;
                    this.Refresh();

                    //make number of vehicles visible 
                    
                    //Start Race with number of vehicles 
                    int numberOfVehicles = Int32.Parse(textBox1.Text);
                    Race race = new Race(numberOfVehicles);

                    int xFinalCoordinates = 400;
                    int progress = 25;

                    while (pictureBoxCar1.Location.X != xFinalCoordinates)
                    {
                        int x = pictureBoxCar1.Location.X;
                        int y = pictureBoxCar1.Location.Y;
                        int x2 = pictureBoxBackground1.Location.X;
                        int y2 = pictureBoxBackground1.Location.Y;
                        Thread.Sleep(500);
                        if (pictureBoxCar1.Location.X + progress >= xFinalCoordinates)
                        {
                            //Car finished 
                            pictureBoxCar1.Location = new Point(xFinalCoordinates, y);
                            CarFinishedPicture1.Visible = true;
                        }
                        else
                        {
                            //continue progress
                            pictureBoxCar1.Location = new Point(x + progress, y);
                            pictureBoxBackground1.Location = new Point(x2 + progress, y2);
                        }
                    }
                }
                else
                {
                    labelWarningMessage.Text = "Input number between 1-12";
                    labelWarningMessage.Visible = true;
                }
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
