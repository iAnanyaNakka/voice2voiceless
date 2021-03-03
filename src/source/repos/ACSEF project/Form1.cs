using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ACSEF_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 6;

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i % 6 == 0)
            {
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button13.BackColor = Color.Gold;
                i++;
            }
            else if (i % 6 == 1)
            {
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button15.BackColor = Color.Gold;
                i++;
            }
            else if (i % 6 == 2)
            {
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button14.BackColor = Color.Gold;
                i++;
            }
            else if (i % 6 == 3)
            {
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button16.BackColor = Color.Gold;
                i++;
            }
            else if (i % 6 == 4)
            {
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button17.BackColor = Color.Gold;
                i++;
            }
            else if (i % 6 == 5)
            {
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button18.BackColor = Color.Gold;
                i++;
            }
            
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
             
            MyGlobals.turn = 2;
            if (i % 6 == 1)
            {
                
                Form2 frm2 = new Form2();
                frm2.Show();
            }

            else if (i % 6 == 2)
            {
                Form4 frm4 = new Form4();
                frm4.Show();
            }
            else if (i % 6 == 3)
            {
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else if (i % 6 == 4)
            {
                Form5 frm5 = new Form5();
                frm5.Show();
            }
            else if (i % 6 == 5)
            {
                Form6 frm6 = new Form6();
                frm6.Show();
            }
            else if (i % 6 == 0)
            {
                Form7 frm7 = new Form7();
                frm7.Show();
            }



        }

        private void var_Tick(object sender, EventArgs e)
        {
            if (MyGlobals.turn == 1)
            {
                timer1.Enabled = true;
            }
            else if (MyGlobals.turn == 2)
            {
                timer1.Enabled = false;
            }
        }
    }
}
public static class MyGlobals
{
    public static int turn = 1;
}

