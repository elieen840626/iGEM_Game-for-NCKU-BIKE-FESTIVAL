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
    public partial class Form1 : Form
    {
        int[] randomArray = new int[5];
        String[,] QA = new String[14,5];
        String[,] QAchoice = new String[5, 5];
        int[] ans = new int[14];
        int[] choiceans = new int[5];
        int[] bestans = new int[5];
        int tempans = 0;

       
        int count = 0;
        public Form1()
        {
            InitializeComponent();        
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.SkyBlue;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            tempans = 1;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.SkyBlue;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            tempans = 2;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.SkyBlue;
            buttonD.BackColor = Color.White;
            tempans = 3;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.SkyBlue;
            tempans = 4;
        }

        private void next_Click(object sender, EventArgs e)
        {
            buttonA.BackColor = Color.White;
            buttonB.BackColor = Color.White;
            buttonC.BackColor = Color.White;
            buttonD.BackColor = Color.White;
            choiceans[count] = tempans;
            bestans[count] = ans[randomArray[count]];
            count = count + 1;
            
            
           
            if ((count + 1) == 5)
            {
                next.Text = "Finish";
                label1.Text = "第" + (count + 1) + "題" ;
                Question.Text = QA[randomArray[count], 0];
                buttonA.Text = QA[randomArray[count], 1];
                buttonB.Text = QA[randomArray[count], 2];
                buttonC.Text = QA[randomArray[count], 3];
                buttonD.Text = QA[randomArray[count], 4];
                QAchoice[count, 0] = QA[randomArray[count], 0];
                QAchoice[count, 1] = QA[randomArray[count], 1];
                QAchoice[count, 2] = QA[randomArray[count], 2];
                QAchoice[count, 3] = QA[randomArray[count], 3];
                QAchoice[count, 4] = QA[randomArray[count], 4];

               
                if (randomArray[count] != 0)
                {
                    pictureBox1.Visible = false;
                    Question.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = true;
                    Question.Visible = false;
                }
            }
            else if ((count + 1) < 5)
            {
                next.Text = "Next";
                label1.Text = "第" + (count + 1) + "題";
                Question.Text = QA[randomArray[count], 0];
                buttonA.Text = QA[randomArray[count], 1];
                buttonB.Text = QA[randomArray[count], 2];
                buttonC.Text = QA[randomArray[count], 3];
                buttonD.Text = QA[randomArray[count], 4];
               

                QAchoice[count, 0]= QA[randomArray[count], 0];
                QAchoice[count, 1] = QA[randomArray[count], 1];
                QAchoice[count, 2] = QA[randomArray[count], 2];
                QAchoice[count, 3] = QA[randomArray[count], 3];
                QAchoice[count, 4] = QA[randomArray[count], 4];

               
                if (randomArray[count] != 0)
                {
                    pictureBox1.Visible = false;
                    Question.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = true;
                    Question.Visible = false;
                }
            }
            else if (count  == 5)
            {
                this.Hide();


                knowmore Resultform = new knowmore();

                Resultform.choiceans2 = choiceans;
                Resultform.bestans2 = bestans;
                Resultform.QAchoice2 = QAchoice;
                Resultform.Show();

            }
            tempans = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random();  //產生亂數初始值
            for (int i = 0; i < 5; i++)
            {
                randomArray[i] = rnd.Next(0, 14);   //亂數產生，亂數產生的範圍是1~14

                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        randomArray[i] = rnd.Next(1, 14);   //重新產生，存回陣列，亂數產生的範圍是1~9
                    }
                }
            }
         
            QA[0,0] = "picture";
            QA[0, 1] = "ug賴";
            QA[0, 2] = "terminate";
            QA[0, 3] = "禁止停車";
            QA[0, 4] = "禁止右轉";
            ans[0] = 3;
           

            QA[1, 0] = "iGEM的全名為何?";
            QA[1, 1] = "international geneticaly engineered machine competition";
            QA[1, 2] = "introduction of Germany and English Math Summercamp";
            QA[1, 3] = "international gene ecology mechanism";
            QA[1, 4] = "an apple product named iGEM";
            ans[1] = 1;

            QA[2, 0] = "iGEM的比賽地點?";
            QA[2, 1] = "紐約";
            QA[2, 2] = "波士頓";
            QA[2, 3] = "巴黎";
            QA[2, 4] = "聖多美普林西比";
            ans[2] = 2;

            QA[3, 0] = "iGEM的比賽內容??";
            QA[3, 1] = "細胞生物學";
            QA[3, 2] = "系統生物學";
            QA[3, 3] = "分子生物學";
            QA[3, 4] = "合成生物學";
            ans[3] = 4;


           QA[4, 0] ="iGEM的比賽項目包含下列哪一項?";
           QA[4, 1] = "環境";
           QA[4, 2] = "醫療診斷";
           QA[4, 3] = "基本研究";
           QA[4, 4] = "以上皆是";
           ans[4] = 4;

           QA[5, 0] = "2017iGEM_NCKU隊伍的主題為何?";
           QA[5, 1] = "糖尿病的偵測";
           QA[5, 2] = "含氮廢物轉換";
           QA[5, 3] = "水泥隙縫的修補";
           QA[5, 4] = "魔性生物膜";
           ans[5] = 2;

           QA[6, 0] = "E. coli 的中文名稱??";
           QA[6, 1] = "木質醋酸桿菌";
           QA[6, 2] = "大腸桿菌";
           QA[6, 3] = "酵母菌";
           QA[6, 4] = "希瓦士菌";
           ans[6] = 2;


           QA[7, 0] = "下列何者為細胞的發電廠?";
           QA[7, 1] = "粒線體";
           QA[7, 2] = "葉綠體";
           QA[7, 3] = "高基氏體";
           QA[7, 4] = "核醣體";
           ans[7] = 1;



           QA[8, 0] = "下列何者非痕跡器官?";
           QA[8, 1] = "脾臟";
           QA[8, 2] = "尾椎";
           QA[8, 3] = "闌尾";
           QA[8, 4] = "智齒";
           ans[8] = 1;


           QA[9, 0] = "2017諾貝爾獎得主的研究主題???";
           QA[9, 1] = "PCR的發明";
           QA[9, 2] = "青蒿素的製備";
           QA[9, 3] = "性聯遺傳";
           QA[9, 4] = "生理時鐘";
           ans[9] = 4;

           QA[10, 0] = "下列何者植物的食用部位為根?";
           QA[10, 1] = "薑";
           QA[10, 2] = "馬鈴薯";
           QA[10, 3] = "番薯";
           QA[10, 4] = "芋頭";
           ans[10] = 3;



           QA[11, 0] = "實驗室通常殺菌使用的酒精為多少%?";
           QA[11, 1] = "99.5-90%";
           QA[11, 2] = "87-80%";
           QA[11, 3] = "70-75%";
           QA[11, 4] = "5-10%";
           ans[11] = 3;


           QA[12, 0] = "藍綠藻的分類為何?";
           QA[12, 1] = "藻類";
           QA[12, 2] = "古細菌";
           QA[12, 3] = "植物";
           QA[12, 4] = "靈長目";
           ans[12] = 2;




           QA[13, 0] = "生物分類的階層有幾層?";
           QA[13, 1] = "2";
           QA[13, 2] = "5";
           QA[13, 3] = "7";
           QA[13, 4] = "9487";
           ans[13] = 3;

           label1.Text = "第" + (count + 1) + "題";
           Question.Text = QA[randomArray[count], 0];
           buttonA.Text = QA[randomArray[count], 1];
           buttonB.Text = QA[randomArray[count], 2];
           buttonC.Text = QA[randomArray[count], 3];
           buttonD.Text = QA[randomArray[count], 4];
           QAchoice[count, 0] = QA[randomArray[count], 0];
           QAchoice[count, 1] = QA[randomArray[count], 1];
           QAchoice[count, 2] = QA[randomArray[count], 2];
           QAchoice[count, 3] = QA[randomArray[count], 3];
           QAchoice[count, 4] = QA[randomArray[count], 4];
           

           if (randomArray[count] != 0)
           {
               pictureBox1.Visible = false;
               Question.Visible = true;
           }
           else
           {
               pictureBox1.Visible = true;
               Question.Visible = false;
           }











           

           
        }


    }
}
