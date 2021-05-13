using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duaxe
{
    public partial class Form2 : Form
    {
        public int diemso;
        public Form2()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (diemchoi < 200)
            {
                tocdo(5);
                lose();
                diemdatduoc();
            }
            else
            {
                if(diemchoi < 500)
                {
                    tocdo(8);
                    lose();
                    diemdatduoc();
                }
                else
                {
                    if (diemchoi < 1000)
                    {
                        tocdo(10);
                        lose();
                        diemdatduoc();
                    }
                }
                
            }
            
        }
        Random newrock = new Random();
        int diem1;
        int diem2;
        void tocdo(int speed)
        {
            if (lephai.Top > 300) lephai.Top = 0;
            else lephai.Top += speed;
            if (lephai2.Top > 300) lephai2.Top = 0;
            else lephai2.Top += speed;
            if (bien1.Top > 300) bien1.Top = 0;
            else bien1.Top += speed;
            if (bien2.Top > 300) bien2.Top = 0;
            else bien2.Top += speed;
            if (bien3.Top > 300) bien3.Top = 0;
            else bien3.Top += speed;
            if (letrai.Top > 300) letrai.Top = 0;
            else letrai.Top += speed;
            if (letrai2.Top > 300) letrai2.Top = 0;
            else letrai2.Top += speed;
            if (rock1.Top > 290)
            {
                diem1 = newrock.Next(60, 250);
                Point tam = new Point(diem1, 0);
                rock1.Location = tam;

            }
            else rock1.Top += speed;

            if (rock2.Top > 290)
            {
                //diemchoi++;
                diem2 = newrock.Next(60, 250);
                while (Math.Abs(diem1 - diem2) <= 37) diem2 = newrock.Next(60, 250);
                Point tam = new Point(diem2, 0);
                rock2.Location = tam;

            }
            else rock2.Top += speed;

            if (rock3.Top > 290)
            {
                //diemchoi++;
                diem1 = newrock.Next(60, 250);
                while (Math.Abs(diem1 - diem2) <= 37) diem1 = newrock.Next(60, 250);
                Point tam = new Point(diem1, 0);
                rock3.Location = tam;

            }
            else rock3.Top += speed;

            if (rock4.Top > 290)
            {
                //diemchoi++;
                diem2 = newrock.Next(60, 250);
                while (Math.Abs(diem1 - diem2) <= 37) diem2 = newrock.Next(60, 250);
                Point tam = new Point(diem2, 0);
                rock4.Location = tam;

            }
            else rock4.Top += speed;

            if (rock5.Top > 290)
            {
                //diemchoi++;
                diem1 = newrock.Next(60, 250);
                while (Math.Abs(diem1 - diem2) <= 37) diem1 = newrock.Next(60, 250);
                Point tam = new Point(diem1, 0);
                rock5.Location = tam;

            }
            else rock5.Top += speed;

            if (rock6.Top > 290)
            {
                //diemchoi++;
                diem2 = newrock.Next(60, 250);
                while (Math.Abs(diem1 - diem2) <= 37) diem2 = newrock.Next(60, 250);
                Point tam = new Point(diem2, 0);
                rock6.Location = tam;

            }
            else rock6.Top += speed;
            if (diemchoi == 200) speed++;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        int speeds = 4;
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Mycar.Left > 55) Mycar.Left -= 4;
            if (e.KeyCode == Keys.Right && Mycar.Left < 255) Mycar.Left += 4;
            if (e.KeyCode == Keys.Down && speeds > 4) speeds--;
            if (e.KeyCode == Keys.Up && speeds < 50) speeds++;
        }
        int diemchoi = 0;
        void diemdatduoc()
        {
            diemchoi++;
            label1.Text = "Score:" + diemchoi.ToString() + " Km";
        }
        void lose()
        {
            if (Mycar.Bounds.IntersectsWith(rock1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true; // dieu kien de khi 2 pic cham nhau Pause- xuat hien Text Box
                Form3 fr = new Form3(diemchoi.ToString());
                this.Hide();
                fr.ShowDialog();
                this.Show();
            }
            else
            {

                if (Mycar.Bounds.IntersectsWith(rock2.Bounds))
                {
                    timer1.Enabled = false;
                    over.Visible = true;
                    Form3 fr = new Form3(diemchoi.ToString());
                    this.Hide();
                    fr.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (Mycar.Bounds.IntersectsWith(rock3.Bounds))
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                        Form3 fr = new Form3(diemchoi.ToString());
                        this.Hide();
                        fr.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        if (Mycar.Bounds.IntersectsWith(rock4.Bounds))
                        {
                            timer1.Enabled = false;
                            over.Visible = true;
                            Form3 fr = new Form3(diemchoi.ToString());
                            this.Hide();
                            fr.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            if (Mycar.Bounds.IntersectsWith(rock5.Bounds))
                            {
                                timer1.Enabled = false;
                                over.Visible = true;
                                Form3 fr = new Form3(diemchoi.ToString());
                                this.Hide();
                                fr.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                if (Mycar.Bounds.IntersectsWith(rock6.Bounds))
                                {
                                    timer1.Enabled = false;
                                    over.Visible = true;
                                    Form3 fr = new Form3(diemchoi.ToString());
                                    this.Hide();
                                    fr.ShowDialog();
                                    this.Show();
                                }
                            }
                        }
                    }
                }

            }

        }
        void exitgame()
        {
            if (MessageBox.Show("Do you exit?", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            exitgame();
        }
        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 NewForm = new Form2();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
