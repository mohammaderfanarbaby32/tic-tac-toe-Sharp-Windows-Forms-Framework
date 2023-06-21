using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Decimal a0 = 0;
        Decimal a = 0;
        Decimal b1 = 0;
        Decimal c = 0;
        Decimal d = 0;
        Decimal f = 0;
        Decimal g = 0;
        Decimal h = 0;
        Decimal o = 0;
        Decimal qt = 0;
        Decimal Qt = 0;
        Decimal QtQ = 0;
        Decimal s = 0;
        Decimal s1 = 0;
        Decimal s2 = 0;
        Double op = 1.0;
        Boolean q=true;
        Boolean _bool;
        bool _bool1 = true;
        int any = 30;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Form4 form4 = new Form4();
        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
            player.URL = ("mohammad.mp3");
        }
        private void button5_Click(object sender, EventArgs e)
        { 
            for(int i = 0; i <= 20; i++)
            {
                this.Opacity = op;
                op -= 0.09;
                Thread.Sleep(30);
                if(i == 2)
                {
                    Application.ExitThread();
                }

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            if (_bool1 == true)
            {
            _bool1 = false;
            _bool = true;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;
            lbl10.Visible = false;
            lbl11.Visible = false;
            lbl12.Visible = false;
            label2.Visible = false;
            jk.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            name1.Visible = false;
            name2.Visible = false;
            label6.Visible = true;
            label7.Visible = true;
            label1.Visible = true;
            timer2.Start();
            timer3.Stop();
            }



        }









        private void lbl4_Click(object sender, EventArgs e)
        {
            
            if (lbl4.Text == "4")
            {
                mohammad1(lbl4, q); c++;
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
           
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            if (lbl5.Text == "5")
            {
                mohammad1(lbl5, q); d++;
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            if (lbl6.Text == "6")
            {
                mohammad1(lbl6, q); f++;
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            if (lbl7.Text == "7")
            {
                mohammad1(lbl7, q); g++;
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            if (lbl8.Text == "8")
            {
                mohammad1(lbl8, q); h++;
            }
            else { MessageBox.Show("The desired house is full","full",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        private void mohammad1(Control Z, bool p)
        {
            if (p)
            {

                Z.Text = "X";
                q = false;
                Z.BackColor = Color.SpringGreen;
            }

            else
            {

                Z.Text = "O";
                q = true;
                Z.BackColor = Color.Blue;
            }



            //برد بازیکن او
            if (lbl1.Text == "O" && lbl2.Text == "O" && lbl3.Text == "O")
            {
                lbl1.BackColor = Color.Red; lbl2.BackColor = Color.Red; lbl3.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad2();


            }
            else if (lbl4.Text == "O" && lbl5.Text == "O" && lbl6.Text == "O")
            {
                lbl4.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl6.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ","!!!Win!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad2();
            }
            else if (lbl7.Text == "O" && lbl8.Text == "O" && lbl9.Text == "O")
            {
                lbl7.BackColor = Color.Red; lbl8.BackColor = Color.Red; lbl9.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad2();
            }

            else if (lbl1.Text == "O" && lbl5.Text == "O" && lbl9.Text == "O")
            {
                lbl1.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl9.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad2();


            }
            else if (lbl3.Text == "O" && lbl5.Text == "O" && lbl7.Text == "O")
            {
                lbl3.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl7.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad2();
            }
            else if (lbl3.Text == "O" && lbl6.Text == "O" && lbl9.Text == "O")
            {
                lbl3.BackColor = Color.Red; lbl6.BackColor = Color.Red; lbl9.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9"; 
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad2();
            }
            else if (lbl1.Text == "O" && lbl4.Text == "O" && lbl7.Text == "O")
            {
                lbl1.BackColor = Color.Red; lbl4.BackColor = Color.Red; lbl7.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad2();
            }
            else if (lbl2.Text == "O" && lbl5.Text == "O" && lbl8.Text == "O")
            {
                lbl2.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl8.BackColor = Color.Red;
                qt++;
                MessageBox.Show(name1.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad2();
            }
            //برد بازیکن ایکس
            else if (lbl1.Text == "X" && lbl2.Text == "X" && lbl3.Text == "X")
            {   lbl1.BackColor = Color.Red; lbl2.BackColor = Color.Red;lbl3.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad3();
            }

            else if (lbl4.Text == "X" && lbl5.Text == "X" && lbl6.Text == "X")
            {
                lbl4.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl6.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad3();

            }
            else if (lbl7.Text == "X" && lbl8.Text == "X" && lbl9.Text == "X")
            {
                lbl7.BackColor = Color.Red; lbl8.BackColor = Color.Red; lbl9.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad3();
            }
            else if (lbl1.Text == "X" && lbl5.Text == "X" && lbl9.Text == "X")
            {
                lbl1.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl9.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad3();
            }
            else if (lbl3.Text == "X" && lbl5.Text == "X" && lbl7.Text == "X")
            {
                lbl3.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl7.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;  
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad3();
            }
            else if (lbl3.Text == "X" && lbl6.Text == "X" && lbl9.Text == "X")
            {
                lbl3.BackColor = Color.Red; lbl6.BackColor = Color.Red; lbl9.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad3();
            }
            else if (lbl1.Text == "X" && lbl4.Text == "X" && lbl7.Text == "X")
            {
                lbl1.BackColor = Color.Red; lbl4.BackColor = Color.Red; lbl7.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad3();
            }
            else if (lbl2.Text == "X" && lbl5.Text == "X" && lbl8.Text == "X")
            {
                lbl2.BackColor = Color.Red; lbl5.BackColor = Color.Red; lbl8.BackColor = Color.Red;
                Qt++;
                MessageBox.Show(name2.Text + " !!!Win!!! ", "!!!Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine; 
                mohammad3();
            }
            else if (lbl1.Text == "X" | lbl1.Text == "O" && lbl2.Text == "O" | lbl2.Text == "X" && lbl3.Text == "X" | lbl3.Text == "O" && lbl4.Text == "X" | lbl4.Text == "O" && lbl5.Text == "X" | lbl5.Text == "O" && lbl6.Text == "X" | lbl6.Text == "O" && lbl7.Text == "X" | lbl7.Text == "O" && lbl8.Text == "X" | lbl8.Text == "O" && lbl9.Text == "X" | lbl9.Text == "O")
            {
                QtQ++;
                MessageBox.Show(" !!!Two players tied!!! ", "!!!Two players tied!!!", MessageBoxButtons.OK, MessageBoxIcon.Information); a0 = 0;
                a = 0;
                b1 = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                o = 0;
                lbl1.Text = "1";
                lbl2.Text = "2";
                lbl3.Text = "3";
                lbl4.Text = "4";
                lbl5.Text = "5";
                lbl6.Text = "6";
                lbl7.Text = "7";
                lbl8.Text = "8";
                lbl9.Text = "9";
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Aquamarine;
                lbl3.BackColor = Color.Aquamarine;
                lbl4.BackColor = Color.Aquamarine;
                lbl5.BackColor = Color.Aquamarine;
                lbl6.BackColor = Color.Aquamarine;
                lbl7.BackColor = Color.Aquamarine;
                lbl8.BackColor = Color.Aquamarine;
                lbl9.BackColor = Color.Aquamarine;
                mohammad4();
            }





        }
        private void mohammad2()
        {
            q = true;
            lbl10.Text = qt.ToString();

        }
        private void mohammad3()
        {
            q = true;

            lbl11.Text = Qt.ToString();


        }




        private void mohammad4()
        {

            q = true;

            lbl12.Text = QtQ.ToString();


        }










        private void lbl9_Click_1(object sender, EventArgs e)
        {
            if (lbl9.Text == "9")
            {
                mohammad1(lbl9, q); o++;
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }



        private void lbl10_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click_1(object sender, EventArgs e)
        {


            if (lbl3.Text == "3")
            {
                mohammad1(lbl3, q); o++;
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }



        }







        private void lbl1_Click(object sender, EventArgs e)
        {
            if (lbl1.Text == "1")
            {
                mohammad1(lbl1, q); a0++;
                
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "2")
            {
                mohammad1(lbl2, q); b1++;
            }
            else { MessageBox.Show("The desired house is full", "full", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            player.URL = ("Void.m4a");
            form3.ShowDialog();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (_bool == false)
            {
            name1.Visible = false;
            name2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label3.Text = name2.Text;
            label4.Text = name1.Text;
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

                label4.Visible = false;
                name1.Visible = true;
                name1.Text = label4.Text;
                
        }

        private void label3_Click(object sender, EventArgs e)
        {


                label3.Visible = false;
                name2.Visible = true;
                name2.Text = label3.Text;

            


        }

        private void label7_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            player.URL = ("Void.m4a");
            form3.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {   if(_bool1 == false)
            {
            _bool1 = true;
            _bool = false;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
            lbl7.Visible = true;
            lbl8.Visible = true;
            lbl9.Visible = true;
            lbl10.Visible = true;
            lbl11.Visible = true;
            lbl12.Visible = true;
            label2.Visible = true;
            jk.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            name1.Visible = true;
            name2.Visible = true;
            timer3.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            label5.Text = s.ToString();
            label5.Refresh();
            if (s == 59)
            {
                s = -1;
                s1 += 1;
                label8.Text = s1.ToString();
            }
            else if (s1 == 59)
            {
                s2 += 1;
                label9.Text = s2.ToString();

            }

           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Location.Y <= 450)
            {

                timer2.Stop();

            }
            if (_bool == true)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y - any);
                label6.Location = new Point(label6.Location.X, label6.Location.Y - any);
                label7.Location = new Point(label7.Location.X, label7.Location.Y - any);


            }
         

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label1.Location.Y >= 1300)
            {

                timer3.Stop();

            }
            if (_bool == false)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y + any);
                label6.Location = new Point(label6.Location.X, label6.Location.Y + any);
                label7.Location = new Point(label7.Location.X, label7.Location.Y + any);


            }
        }


    }
}



