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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int r = 3;

       

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (r % 3 == 0)
            {
                button4.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button4.BackColor = Color.Gold;
                r++;
            }
            else if (r % 3 == 1)
            {
                button1.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                button1.BackColor = Color.Gold;
                r++;
            }
            else if (r % 3 == 2)
            {
                button1.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                button2.BackColor = Color.Gold;
                r++;
            }
        }

      

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (r % 3 == 1)
            {

                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_12_40_13.wav");
                splayer.Play();
            }

            else if (r % 3 == 2)
            {

                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Satish\Downloads\ttsMP3.com_VoiceText_2021-2-28_12_44_58 (1).wav");
                splayer.Play();

            }
            else if (r % 3 == 0)
            {
                MyGlobals.turn = 1;
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }
    }
}
