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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int b = 3;

       

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (b % 3 == 0)
            {
                button3.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.Gold;
                b++;
            }
            else if (b % 3 == 1)
            {
                button1.BackColor = Color.White;
                button3.BackColor = Color.White;
                button2.BackColor = Color.White;
                button1.BackColor = Color.Gold;
                b++;
            }
            else if (b % 3 == 2)
            {
                button1.BackColor = Color.White;
                button3.BackColor = Color.White;
                button2.BackColor = Color.White;
                button2.BackColor = Color.Gold;
                b++;
            }
        }

      

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (b % 3 == 1)
            {

                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-27_22_57_23.wav");
                splayer.Play();

              
            }

            else if (b % 3 == 2)
            {

                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-27_23_13_16 (online-audio-converter.com).wav");
                splayer.Play();

            }
            else if (b % 3 == 0)
            {
                MyGlobals.turn = 1;
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }
    }    
}