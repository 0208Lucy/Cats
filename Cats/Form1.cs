using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        int time = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            label1.Text = "遊戲時間：20";
            label2.Text = "遊戲得分：0";
            label3.Text = "請打貓咪";
            count = 0;
            time = 20;
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int num = rd.Next(6);
            switch(num)
            {
                case 0:invisiable();
                    pictureBox1.Visible = true;
                    break;
                case 1:
                    invisiable();
                    pictureBox2.Visible = true;
                    break;
                case 2:
                    invisiable();
                    pictureBox3.Visible = true;
                    break;
                case 3:
                    invisiable();
                    pictureBox4.Visible = true;
                    break;
                case 4:
                    invisiable();
                    pictureBox5.Visible = true;
                    break;
                case 5:
                    invisiable();
                    pictureBox6.Visible = true;
                    break;

            }
        }
        int flag = 0;
        private void invisiable()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[0];
            pictureBox3.Image = imageList1.Images[0];
            pictureBox4.Image = imageList1.Images[0];
            pictureBox5.Image = imageList1.Images[0];
            pictureBox6.Image = imageList1.Images[0];

            flag = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = imageList1.Images[1];
            if(flag==0)
            {
                flag = 1;
                count++;
                label2.Text = "遊戲得分：" + count;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                timer1.Enabled = false;
                invisiable();
                label3.Text = "遊戲結束";
                button1.Visible = true;
                button1.Text = "再來一次";
            }
            else
            {
                time--;
                label1.Text = "遊戲時間：" + time;
            }
        }
    }
}
