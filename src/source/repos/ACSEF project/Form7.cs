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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int z = 6;

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (z % 6 == 0)
            {
                button5.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button6.BackColor = Color.White;
                button1.BackColor = Color.Gold;
                z++;
            }
            else if (z % 6 == 1)
            {
                button5.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button6.BackColor = Color.White;
                button3.BackColor = Color.Gold;
                z++;
            }
            else if (z % 6 == 2)
            {
                button5.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button6.BackColor = Color.White;
                button2.BackColor = Color.Gold;
                z++;
            }
            else if (z % 6 == 3)
            {
                button5.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button6.BackColor = Color.White;
                button5.BackColor = Color.Gold;
                z++;
            }
            else if (z % 6 == 4)
            {
                button5.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button6.BackColor = Color.White;
                button6.BackColor = Color.Gold;
                z++;
            }
            else if (z % 6 == 5)
            {
                button5.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.Gold;
                z++;
            }


        }

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            if (z % 6 == 1)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_13_6_35.wav");
                splayer.Play();
            }
            else if (z % 6 == 2)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_13_8_26.wav");
                splayer.Play();
            }
            else if (z % 6 == 3)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_13_12_4.wav");
                splayer.Play();
            }
            else if (z % 6 == 4)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_13_13_47.wav");
                splayer.Play();
            }
            else if (z % 6 == 5)
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_13_15_27.wav");
                splayer.Play();
            }
            else if (z % 6 == 0)
            {
                MyGlobals.turn = 1;
                Form1 frm1 = new Form1();
                frm1.Show();
            }

        }
    }
}
