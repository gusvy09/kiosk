using System.Drawing;
using System.Windows.Forms;

namespace ham
{
    partial class Pay
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            label1 = new Label();
            btn_Cash = new Button();
            btn_Card = new Button();
            btn_Kakao = new Button();
            timer_Card = new Timer(components);
            button1 = new Button();
            button2 = new Button();
            lb_Time = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "결제방식";
            // 
            // btn_Cash
            // 
            btn_Cash.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Cash.FlatAppearance.BorderSize = 0;
            btn_Cash.FlatStyle = FlatStyle.Flat;
            btn_Cash.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cash.Location = new Point(3, 44);
            btn_Cash.Name = "btn_Cash";
            btn_Cash.Size = new Size(75, 23);
            btn_Cash.TabIndex = 1;
            btn_Cash.Text = "현금";
            btn_Cash.UseVisualStyleBackColor = true;
            btn_Cash.Click += btn_Cash_Click;
            // 
            // btn_Card
            // 
            btn_Card.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Card.FlatAppearance.BorderSize = 0;
            btn_Card.FlatStyle = FlatStyle.Flat;
            btn_Card.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Card.Location = new Point(84, 44);
            btn_Card.Name = "btn_Card";
            btn_Card.Size = new Size(75, 23);
            btn_Card.TabIndex = 2;
            btn_Card.Text = "카드";
            btn_Card.UseVisualStyleBackColor = true;
            btn_Card.Click += btn_Card_Click;
            // 
            // btn_Kakao
            // 
            btn_Kakao.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Kakao.FlatAppearance.BorderSize = 0;
            btn_Kakao.FlatStyle = FlatStyle.Flat;
            btn_Kakao.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Kakao.Location = new Point(165, 44);
            btn_Kakao.Name = "btn_Kakao";
            btn_Kakao.Size = new Size(75, 23);
            btn_Kakao.TabIndex = 3;
            btn_Kakao.Text = "button3";
            btn_Kakao.UseVisualStyleBackColor = true;
            btn_Kakao.Click += btn_Kakao_Click;
            // 
            // timer_Card
            // 
            timer_Card.Tick += timer_Card_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 64, 64);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "취소";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Wheat;
            button2.Location = new Point(122, 79);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "확인";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lb_Time
            // 
            lb_Time.AutoSize = true;
            lb_Time.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Time.Location = new Point(165, 9);
            lb_Time.Name = "lb_Time";
            lb_Time.Size = new Size(0, 21);
            lb_Time.TabIndex = 6;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(243, 124);
            Controls.Add(lb_Time);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_Kakao);
            Controls.Add(btn_Card);
            Controls.Add(btn_Cash);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Cash;
        private Button btn_Card;
        private Button btn_Kakao;
        private Timer timer_Card;
        private Button button1;
        private Button button2;
        private Label lb_Time;
    }
}