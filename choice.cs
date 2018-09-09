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
    public partial class choice : Form
    {
        public choice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();	//將目前表單隱藏
            Form1 myForm = new Form1();	//宣告並建立myForm為Form1的表單物件
            myForm.Show();
        }

        private void choice_Load(object sender, EventArgs e)
        {
            
        }
    }
}
