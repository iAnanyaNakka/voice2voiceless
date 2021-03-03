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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int y = 3;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (y % 3 == 0)
            {
                button2.BackColor = Color.White;
                button1.BackColor = Color.White;
                button3.BackColor = Color.White;
                button1.BackColor = Color.Gold;
                y++;
            }
            else if (y % 3 == 1)
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button2.BackColor = Color.Gold;
                y++;
            }
            else if (y % 3 == 2)
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button3.BackColor = Color.Gold;
                y++;
            }
        }

      
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            
            
            if (y % 3 == 0)
            {

              
                MyGlobals.turn = 1;
                Form1 frm1 = new Form1();
                frm1.Show();
            }

            else if (y % 3 == 1)
            {


                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-27_21_38_23.wav");
                splayer.Play();
            }
            else if (y % 3 == 2)
            {
               
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-27_21_38_23.wav");
                splayer.Play();

            }
        }
    }
}
