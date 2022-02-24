using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


//Bence
//
//  This program was made to rickroll your friends. Rename the program to anyithing. For exmp. : Freerobux, discordnitro, win11install
//
//  30.10.2020
//

namespace FreeRobux
{
    public partial class rickrollform : Form
    {
        public rickrollform()
        {
            InitializeComponent();

        }
        int rickx = 6;
        int ricky = 6;
        int labelx = 6;
        int labely = 6;



        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
#region egy
        private void timer1_Tick(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);


            rick.Top -= ricky; 
            rick.Left -= rickx;


            if (rick.Top < 0 || rick.Top + rick.Height > ClientSize.Height)
            {

                ricky = -ricky;
            }

            else if (rick.Left < 0 || rick.Left + rick.Width > ClientSize.Width)
            {

                rickx = -rickx;
            

            }

            cimke.Location = new Point(Cursor.Position.X +10, Cursor.Position.Y +10);
            lyrcs.Location = new Point(rick.Location.X + 0, rick.Location.Y + 160);
            lyrcs2.Location = new Point(rick.Location.X + 0, rick.Location.Y + 160);
            lyrcs3.Location = new Point(rick.Location.X + 0, rick.Location.Y + 160);

        }
   

        private void rickroll_Load(object sender, EventArgs e)
        {
            BackColor = Color.Lime;
            TransparencyKey = Color.Lime;
            System.IO.Stream rickroll = Properties.Resources.RickRoll;
            System.Media.SoundPlayer hang = new System.Media.SoundPlayer(rickroll);
            hang.Play();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rickrollform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rick.Visible == true)
            {
                e.Cancel = true;
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
        }

        private void rickrollform_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void rick_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Start();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Cursor.Position = new Point(rick.Location.X + 109, rick.Location.Y + 78);

        }

        private void rick_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            label1.Top -= labely;
            label1.Left -= labelx;
            label1.Location = new Point(label1.Location.X + 0, rick.Location.Y + 0);

            if (label1.Left < 0 || label1.Left + label1.Width > ClientSize.Width)
            {

                labelx = -labelx;
            }

        }
#endregion 
        private void timer4_Tick(object sender, EventArgs e)
        {
            int ertek = Convert.ToInt32(debugszamlalo.Text) + 1;
            debugszamlalo.Text = Convert.ToString(ertek);
            if (debugszamlalo.Text == "2")
            {
                timer5.Start();
            
            }
            else if (debugszamlalo.Text == "6")
            {
               
            }
            else if (debugszamlalo.Text == "19")
            {
           
                lyrcs.Text = "We're no strangers to love.";
            }
            else if (debugszamlalo.Text == "23")
            {
                lyrcs.Text = "You know the rules and so do I.";
            }
            else if (debugszamlalo.Text == "27")
            {
                lyrcs.Text = "A full commitment's what I'm thinking of.";
           
            }
            else if (debugszamlalo.Text == "31")
            {
                lyrcs.Text = "You wouldn't get this from any other guy.";
            }
            else if (debugszamlalo.Text == "31")
            {
               
                lyrcs.Text = "You wouldn't get this from any other guy.";
            }
            else if (debugszamlalo.Text == "35")
            {
                lyrcs.Text = "I just wanna tell you how I'm feeling.";
           
            }
            else if (debugszamlalo.Text == "41")
            {
                lyrcs.Text = "Gotta make you understand,";
            }
            else if (debugszamlalo.Text == "43")
            {
                lyrcs3.Text = "Never gonna give you up \r\nNever gonna let you down \r\nNever gonna run around and desert you \r\nNever gonna make you cry \r\nNever gonna say goodbye \r\nNever gonna tell a lie and hurt you.";
            }
            else if (debugszamlalo.Text == "61")
            {
                lyrcs.Text = "";
                lyrcs2.Text = "";
                lyrcs3.Text = "";
                rick.Visible = false;
                label1.Visible = false;
                cimke.Visible = false;
                System.IO.Stream rickroll = Properties.Resources.RickRoll;
                System.Media.SoundPlayer hang = new System.Media.SoundPlayer(rickroll);
                hang.Stop();
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                this.Close();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
           
            timer5.Stop();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
