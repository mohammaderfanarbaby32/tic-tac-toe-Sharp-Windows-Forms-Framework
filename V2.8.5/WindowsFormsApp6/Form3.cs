using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace WindowsFormsApp6
{
    public partial class Form3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         player.URL = ("mohammad.mp3"); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.URL = ("f.mp3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            player.URL = ("2.mp3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.URL = ("erfan.mp3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.URL = ("a.mp3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player.URL = ("Void.m4a");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }
    }
}
