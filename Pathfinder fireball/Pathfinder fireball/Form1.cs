using System;

namespace Pathfinder_fireball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void d4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 5); // Next upper bound is exclusive, so we use 5 to include 4
            string randomNumberString = randomNumber.ToString();
            lblD4.Text = randomNumberString;
        }

        private void d6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string randomNumberString = randomNumber.ToString();
            lblD6.Text = randomNumberString;
        }
        private void btnD8_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 9);
            string randomNumberString = randomNumber.ToString();
            lblD8.Text = randomNumberString;
        }


        private void btnD10_click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            string randomNumberString = randomNumber.ToString();
            lblD10.Text = randomNumberString;
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 13);
            string randomNumberString = randomNumber.ToString();
            lblD12.Text = randomNumberString;
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            string randomNumberString = randomNumber.ToString();
            lblD20.Text = randomNumberString;
        }

        private void btnD100_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            string randomNumberString = randomNumber.ToString();
            lblD100.Text = randomNumberString;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFireball_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double sum = 0;
            int casterLevel = 5;
            casterLevel = int.Parse(tboxfireballCL.Text);

            int radius = int.Parse(tboxRadius.Text);
            radius = radius / 5;

            if (cboxShrunk.Checked == true && cboxWidened.Checked == false)
            {
                int shrunkAmount = 4 - radius;
                casterLevel = casterLevel + shrunkAmount;
            }

            if (cboxShrunk.Checked == true && cboxWidened.Checked == true)
            {
                int shrunkAmount = 8 - radius;
                casterLevel = casterLevel + shrunkAmount;
            }

            for (int i = 0; i < casterLevel; i++)
            {
                int randomNumber = random.Next(1, 7);
                sum += randomNumber;
            }

            if (cboxEmpowerd.Checked == true)
            {
                sum = Math.Floor(sum * 1.5);
            }

            if (cboxAcid.Checked == true)
            {
                sum = sum + casterLevel;
            }

            sum = sum + (casterLevel * 2) + 3;
            lblFireball.Text = sum.ToString();
        }

        private void lblFireball_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
