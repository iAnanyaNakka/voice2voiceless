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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int k = 3;

      

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (k % 3 == 0)
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button1.BackColor = Color.Gold;
                k++;
            }
            else if (k % 3 == 1)
            {
                button2.BackColor = Color.White;
                button1.BackColor = Color.White;
                button3.BackColor = Color.White;
                button2.BackColor = Color.Gold;
                k++;
            }
            else if (k % 3 == 2)
            {
                button2.BackColor = Color.White;
                button1.BackColor = Color.White;
                button3.BackColor = Color.White;
                button3.BackColor = Color.Gold;
                k++;
            }

        }

     

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (k % 3 == 1)
            {

                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_12_33_37.wav");
                splayer.Play();
            }

            else if (k % 3 == 2)
            {

                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_12_37_15.wav");
                splayer.Play();

            }
            else if (k % 3 == 0)
            {
                MyGlobals.turn = 1;
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }

       
    }
}
