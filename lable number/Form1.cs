using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lable_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (btn2.Visible == false || btn5.Visible == false)
            {
                if (btn2.Visible == false)
                {
                    btn1.Visible = false;
                    btn2.Visible = true;
                    btn2.Text = btn1.Text;
                }
                else
                {
                    btn1.Visible = false;
                    btn5.Visible = true;
                    btn5.Text = btn1.Text;
                }

            }

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (btn1.Visible == false || btn3.Visible == false || btn6.Visible == false)
            {
                if (btn1.Visible == false)
                {
                    btn1.Visible = true;
                    btn2.Visible = false;
                    btn1.Text = btn2.Text;
                }
                else if (btn3.Visible == false)
                {
                    btn3.Visible = true;
                    btn2.Visible = false;
                    btn3.Text = btn2.Text;
                }
                else
                {
                    btn6.Visible = true;
                    btn2.Visible = false;
                    btn6.Text = btn2.Text;
                }

            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (btn2.Visible == false || btn4.Visible == false || btn7.Visible == false)
            {
                if (btn2.Visible == false)
                {
                    btn2.Visible = true;
                    btn3.Visible = false;
                    btn2.Text = btn3.Text;
                }
                else if (btn4.Visible == false)
                {
                    btn4.Visible = true;
                    btn3.Visible = false;
                    btn4.Text = btn3.Text;
                }
                else
                {
                    btn7.Visible = true;
                    btn3.Visible = false;
                    btn7.Text = btn3.Text;
                }
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (btn3.Visible == false || btn8.Visible == false)
            {
                if (btn3.Visible == false)
                {
                    btn3.Visible = true;
                    btn4.Visible = false;
                    btn3.Text = btn4.Text;
                }
                else
                {
                    btn8.Visible = true;
                    btn4.Visible = false;
                    btn8.Text = btn4.Text;
                }

            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (btn1.Visible == false || btn9.Visible == false || btn6.Visible == false)
            {
                if (btn1.Visible == false)
                {
                    btn1.Visible = true;
                    btn5.Visible = false;
                    btn1.Text = btn5.Text;
                }
                else if (btn9.Visible == false)
                {
                    btn9.Visible = true;
                    btn5.Visible = false;
                    btn9.Text = btn5.Text;
                }
                else
                {
                    btn6.Visible = true;
                    btn5.Visible = false;
                    btn6.Text = btn5.Text;
                }
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (btn2.Visible == false || btn5.Visible == false || btn7.Visible == false || btn10.Visible == false)
            {
                if (btn2.Visible == false)
                {
                    btn2.Visible = true;
                    btn6.Visible = false;
                    btn2.Text = btn6.Text;
                }
                else if (btn5.Visible == false)
                {
                    btn5.Visible = true;
                    btn6.Visible = false;
                    btn5.Text = btn6.Text;
                }
                else if (btn10.Visible == false)
                {
                    btn10.Visible = true;
                    btn6.Visible = false;
                    btn10.Text = btn6.Text;
                }
                else
                {
                    btn7.Visible = true;
                    btn6.Visible = false;
                    btn7.Text = btn6.Text;
                }
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (btn3.Visible == false || btn6.Visible == false || btn8.Visible == false || btn11.Visible == false)
            {
                if (btn3.Visible == false)
                {
                    btn3.Visible = true;
                    btn7.Visible = false;
                    btn3.Text = btn7.Text;
                }
                else if (btn6.Visible == false)
                {
                    btn6.Visible = true;
                    btn7.Visible = false;
                    btn6.Text = btn7.Text;
                }
                else if (btn8.Visible == false)
                {
                    btn8.Visible = true;
                    btn7.Visible = false;
                    btn8.Text = btn7.Text;
                }
                else
                {
                    btn11.Visible = true;
                    btn7.Visible = false;
                    btn11.Text = btn7.Text;
                }
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (btn4.Visible == false || btn7.Visible == false || btn12.Visible == false)
            {
                if (btn4.Visible == false)
                {
                    btn4.Visible = true;
                    btn8.Visible = false;
                    btn4.Text = btn8.Text;
                }
                else if (btn7.Visible == false)
                {
                    btn7.Visible = true;
                    btn8.Visible = false;
                    btn7.Text = btn8.Text;
                }
                else
                {
                    btn12.Visible = true;
                    btn8.Visible = false;
                    btn12.Text = btn8.Text;
                }
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (btn5.Visible == false || btn10.Visible == false || btn13.Visible == false)
            {
                if (btn5.Visible == false)
                {
                    btn5.Visible = true;
                    btn9.Visible = false;
                    btn5.Text = btn9.Text;
                }
                else if (btn10.Visible == false)
                {
                    btn10.Visible = true;
                    btn9.Visible = false;
                    btn10.Text = btn9.Text;
                }
                else
                {
                    btn13.Visible = true;
                    btn9.Visible = false;
                    btn13.Text = btn9.Text;
                }
            }
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            if (btn6.Visible == false || btn9.Visible == false || btn11.Visible == false || btn14.Visible == false)
            {
                if (btn6.Visible == false)
                {
                    btn6.Visible = true;
                    btn10.Visible = false;
                    btn6.Text = btn10.Text;
                }
                else if (btn9.Visible == false)
                {
                    btn9.Visible = true;
                    btn10.Visible = false;
                    btn9.Text = btn10.Text;
                }
                else if (btn11.Visible == false)
                {
                    btn11.Visible = true;
                    btn10.Visible = false;
                    btn11.Text = btn10.Text;
                }
                else
                {
                    btn14.Visible = true;
                    btn10.Visible = false;
                    btn14.Text = btn10.Text;
                }
            }
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            if (btn7.Visible == false || btn10.Visible == false || btn12.Visible == false || btn15.Visible == false)
            {
                if (btn7.Visible == false)
                {
                    btn7.Visible = true;
                    btn11.Visible = false;
                    btn7.Text = btn11.Text;
                }
                else if (btn10.Visible == false)
                {
                    btn10.Visible = true;
                    btn11.Visible = false;
                    btn10.Text = btn11.Text;
                }
                else if (btn12.Visible == false)
                {
                    btn12.Visible = true;
                    btn11.Visible = false;
                    btn12.Text = btn11.Text;
                }
                else
                {
                    btn15.Visible = true;
                    btn11.Visible = false;
                    btn15.Text = btn11.Text;
                }
            }
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            if (btn8.Visible == false || btn11.Visible == false || btn16.Visible == false)
            {
                if (btn8.Visible == false)
                {
                    btn8.Visible = true;
                    btn12.Visible = false;
                    btn8.Text = btn12.Text;
                }
                else if (btn11.Visible == false)
                {
                    btn11.Visible = true;
                    btn12.Visible = false;
                    btn11.Text = btn12.Text;
                }
                else
                {
                    btn16.Visible = true;
                    btn12.Visible = false;
                    btn16.Text = btn12.Text;
                }
            }
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            if (btn9.Visible == false || btn14.Visible == false)
            {
                if (btn9.Visible == false)
                {
                    btn13.Visible = false;
                    btn9.Visible = true;
                    btn9.Text = btn13.Text;
                }
                else
                {
                    btn13.Visible = false;
                    btn14.Visible = true;
                    btn14.Text = btn13.Text;
                }

            }
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            if (btn10.Visible == false || btn13.Visible == false || btn15.Visible == false)
            {
                if (btn10.Visible == false)
                {
                    btn10.Visible = true;
                    btn14.Visible = false;
                    btn10.Text = btn14.Text;
                }
                else if (btn13.Visible == false)
                {
                    btn13.Visible = true;
                    btn14.Visible = false;
                    btn13.Text = btn14.Text;
                }
                else
                {
                    btn15.Visible = true;
                    btn14.Visible = false;
                    btn15.Text = btn14.Text;
                }
            }
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            if (btn11.Visible == false || btn14.Visible == false || btn16.Visible == false)
            {
                if (btn11.Visible == false)
                {
                    btn11.Visible = true;
                    btn15.Visible = false;
                    btn11.Text = btn15.Text;
                }
                else if (btn14.Visible == false)
                {
                    btn14.Visible = true;
                    btn15.Visible = false;
                    btn14.Text = btn15.Text;
                }
                else
                {
                    btn16.Visible = true;
                    btn15.Visible = false;
                    btn16.Text = btn15.Text;
                }
            }
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            if (btn12.Visible == false || btn15.Visible == false)
            {
                if (btn12.Visible == false)
                {
                    btn16.Visible = false;
                    btn12.Visible = true;
                    btn12.Text = btn16.Text;
                }
                else
                {
                    btn16.Visible = false;
                    btn15.Visible = true;
                    btn15.Text = btn16.Text;
                }

            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            int[] btnNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] Snum = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                int x = rnd.Next(0, 15 - i);
                Snum[i] = btnNum[x];
                for (int j = 0, l = 0; j < (15 - i); j++)
                {
                    if (j == x) j += 1;
                    btnNum[l] = btnNum[j];
                    l++;
                }

            }

            btn1.Text = Snum[0] + "";
            btn2.Text = Snum[1] + "";
            btn3.Text = Snum[2] + "";
            btn4.Text = Snum[3] + "";
            btn5.Text = Snum[4] + "";
            btn6.Text = Snum[5] + "";
            btn7.Text = Snum[6] + "";
            btn8.Text = Snum[7] + "";
            btn9.Text = Snum[8] + "";
            btn10.Text = Snum[9] + "";
            btn11.Text = Snum[10] + "";
            btn12.Text = Snum[11] + "";
            btn13.Text = Snum[12] + "";
            btn14.Text = Snum[13] + "";
            btn15.Text = Snum[14] + "";

        }
    }
}
