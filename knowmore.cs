using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iGEM
{
    public partial class knowmore : Form
    {
      


        int scoreRIGHT;
        public int[] choiceans2 = new int[5];
        public int[] bestans2 = new int[5];
        public String[,] QAchoice2 = new String[5, 5];


        public knowmore()
        {
            InitializeComponent();
        }

        private void knowmore_Load(object sender, EventArgs e)
        {
            scoreRIGHT = 0;
            for (int i = 0; i < 5; i++)
            {
                if (choiceans2[i] == bestans2[i])
                {
                    scoreRIGHT = scoreRIGHT + 1;
                }
            }
            score.Text = "答對"+scoreRIGHT.ToString()+"分";


            this.Hide();






            label1.Text = QAchoice2[0, 0] + "\n選擇答案: " + QAchoice2[0, choiceans2[0]] + "\n正確答案 :" + QAchoice2[0, bestans2[0]];
            label2.Text = QAchoice2[1, 0] + "\n選擇答案: " + QAchoice2[1, choiceans2[1]] + "\n正確答案 :" + QAchoice2[1, bestans2[1]];
            label3.Text = QAchoice2[2, 0] + "\n選擇答案: " + QAchoice2[2, choiceans2[2]] + "\n正確答案 :" + QAchoice2[2, bestans2[2]];
            label4.Text = QAchoice2[3, 0] + "\n選擇答案: " + QAchoice2[3, choiceans2[3]] + "\n正確答案 :" + QAchoice2[3, bestans2[3]];
            label5.Text = QAchoice2[4, 0] + "\n選擇答案: " + QAchoice2[4, choiceans2[4]] + "\n正確答案 :" + QAchoice2[4, bestans2[4]];
            if (QAchoice2[0, 0] == "picture")
            {
                pictureBox6.Visible = true;
                label1.Text = "\n\t選擇答案: " + QAchoice2[0, choiceans2[0]] + "\n\t正確答案 :" + QAchoice2[0, bestans2[0]];
               
            }
            if (QAchoice2[1, 0] == "picture")
            {
                pictureBox7.Visible = true;
                label2.Text = "\n\t選擇答案: " + QAchoice2[1, choiceans2[1]] + "\n\t正確答案 :" + QAchoice2[1, bestans2[1]];
               
            }
            if (QAchoice2[2, 0] == "picture")
            {
                pictureBox8.Visible = true;
                label3.Text = "\n\t選擇答案: " + QAchoice2[2, choiceans2[2]] + "\n\t正確答案 :" + QAchoice2[2, bestans2[2]];
               
            }
            if (QAchoice2[3, 0] == "picture")
            {
                pictureBox9.Visible = true;
                label4.Text = "\n\t選擇答案: " + QAchoice2[3, choiceans2[3]] + "\n\t正確答案 :" + QAchoice2[3, bestans2[3]];
                
            }
            if (QAchoice2[4, 0] == "picture")
            {
                pictureBox10.Visible = true;
                label4.Text = "\n\t選擇答案: " + QAchoice2[4, choiceans2[4]] + "\n\t正確答案 :" + QAchoice2[4, bestans2[4]];
               
            }
            if (choiceans2[0] == bestans2[0])
            {
                pictureBox1.Image = Properties.Resources.text;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.text_1;
            }
            if (choiceans2[1] == bestans2[1])
            {
                pictureBox2.Image = Properties.Resources.text;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.text_1;
            }
            if (choiceans2[2] == bestans2[2])
            {
                pictureBox3.Image = Properties.Resources.text;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.text_1;
            }
            if (choiceans2[3] == bestans2[3])
            {
                pictureBox4.Image = Properties.Resources.text;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.text_1;
            }
            if (choiceans2[4] == bestans2[4])
            {
                pictureBox5.Image = Properties.Resources.text;
            }
           else
            {
                pictureBox5.Image = Properties.Resources.text_1;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choice choiceform = new choice();
            choiceform.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            like likeform = new like();
            likeform.Show();
            this.Hide();
        }

       
    }
}  