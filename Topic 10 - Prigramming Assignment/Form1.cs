using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___Prigramming_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.WhiteBread;
            lblWhitebreadDisc.Visible = true;

            lblChickenDisc.Visible = false;
            lblCornbreadDisc.Visible = false;
            lblCurrygoatDisc.Visible = false;
            lblRotiDisc.Visible = false;
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Fried_Chicken_Pieces_1;
            lblChickenDisc.Visible = true;

            lblCornbreadDisc.Visible = false;
            lblCurrygoatDisc.Visible = false;
            lblWhitebreadDisc.Visible = false;
            lblRotiDisc.Visible = false;
        }

        private void btnCurry_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.CurryGoat;
            lblCurrygoatDisc.Visible = true;

            lblChickenDisc.Visible = false;
            lblCornbreadDisc.Visible = false;
            lblWhitebreadDisc.Visible = false;
            lblRotiDisc.Visible = false;
        }

        private void btnCornbread_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Cornbread;
            lblCornbreadDisc.Visible = true;

            lblChickenDisc.Visible = false;
            lblCurrygoatDisc.Visible = false;
            lblWhitebreadDisc.Visible = false;
            lblRotiDisc.Visible = false;
        }

        private void btnRoti_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Roti;
            lblRotiDisc.Visible = true;

            lblChickenDisc.Visible = false;
            lblCornbreadDisc.Visible = false;
            lblCurrygoatDisc.Visible = false;
            lblWhitebreadDisc.Visible = false;
        }
    }
}
