namespace iGEM
{
    partial class like
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Question = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Question.Location = new System.Drawing.Point(27, 35);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(739, 93);
            this.Question.TabIndex = 55;
            this.Question.Text = "主題你來選";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.LavenderBlush;
            this.next.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.next.Location = new System.Drawing.Point(602, 615);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(164, 62);
            this.next.TabIndex = 54;
            this.next.Text = "結束";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.White;
            this.buttonC.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonC.Location = new System.Drawing.Point(27, 391);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(739, 93);
            this.buttonC.TabIndex = 53;
            this.buttonC.Text = "植物檢測";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.White;
            this.buttonB.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonB.Location = new System.Drawing.Point(27, 279);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(739, 93);
            this.buttonB.TabIndex = 52;
            this.buttonB.Text = "分解二氧化碳";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.White;
            this.buttonA.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonA.Location = new System.Drawing.Point(27, 167);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(739, 93);
            this.buttonA.TabIndex = 51;
            this.buttonA.Text = "海水油汙分離";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(27, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(739, 62);
            this.button1.TabIndex = 59;
            this.button1.Text = "選擇";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // like
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(807, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.next);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Name = "like";
            this.Text = "like";
            this.Load += new System.EventHandler(this.like_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button button1;
    }
}