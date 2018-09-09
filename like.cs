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
    public partial class like : Form
    {
        public like()
        {
            InitializeComponent();
        }
        int tempans;
        int count1;
        int count2;
        int count3;

        private void next_Click(object sender, EventArgs e)
        {
            choice choiceform = new choice();
            choiceform.Show();
            this.Hide();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.SkyBlue;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            
            tempans = 1;
            button1.Enabled = true;

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.SkyBlue;
            buttonC.BackColor = Color.White;

            tempans = 2;
            button1.Enabled = true;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.SkyBlue;

            tempans = 3;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if(tempans==1)
            {
                count1 = count1 + 1;
            }
            else if(tempans==2)
            {
                count2 = count2 + 1;
            }
            else if(tempans==3)
            {
                count3 = count3 + 1;
            }
           
        }

        private void like_Load(object sender, EventArgs e)
        {
           
        }
    }
}
