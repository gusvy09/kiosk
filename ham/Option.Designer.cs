using System.Drawing;
using System.Windows.Forms;

namespace ham
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            panel1 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            rdio_stick_2 = new RadioButton();
            pictureBox5 = new PictureBox();
            rdio_czball = new RadioButton();
            pb_ptt = new PictureBox();
            rdio_czptt = new RadioButton();
            pictureBox2 = new PictureBox();
            rdio_ptt = new RadioButton();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            rdio_fanta = new RadioButton();
            rdio_Zero = new RadioButton();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            rdio_Cider = new RadioButton();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdio_Coke = new RadioButton();
            lb_Plz = new Label();
            tb_plz = new TextBox();
            btn_Confirm = new Button();
            btn_Cancel = new Button();
            lb_Price = new Label();
            tb_Cnt = new TextBox();
            btn_Plus = new Button();
            btn_Minus = new Button();
            lb_PrName = new Label();
            pb_Product = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ptt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Product).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lb_Plz);
            panel1.Controls.Add(tb_plz);
            panel1.Controls.Add(btn_Confirm);
            panel1.Controls.Add(btn_Cancel);
            panel1.Controls.Add(lb_Price);
            panel1.Controls.Add(tb_Cnt);
            panel1.Controls.Add(btn_Plus);
            panel1.Controls.Add(btn_Minus);
            panel1.Controls.Add(lb_PrName);
            panel1.Controls.Add(pb_Product);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 950);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(label2);
            panel5.Location = new Point(3, 487);
            panel5.Name = "panel5";
            panel5.Size = new Size(709, 50);
            panel5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 30);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "음료수";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(rdio_stick_2);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(rdio_czball);
            panel4.Controls.Add(pb_ptt);
            panel4.Controls.Add(rdio_czptt);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(rdio_ptt);
            panel4.Controls.Add(pictureBox4);
            panel4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(3, 543);
            panel4.Name = "panel4";
            panel4.Size = new Size(647, 212);
            panel4.TabIndex = 1;
            // 
            // rdio_stick_2
            // 
            rdio_stick_2.AutoSize = true;
            rdio_stick_2.Location = new Point(497, 187);
            rdio_stick_2.Name = "rdio_stick_2";
            rdio_stick_2.Size = new Size(78, 21);
            rdio_stick_2.TabIndex = 6;
            rdio_stick_2.TabStop = true;
            rdio_stick_2.Text = "변동없음";
            rdio_stick_2.UseVisualStyleBackColor = true;
            rdio_stick_2.CheckedChanged += rdio_stick_2_CheckedChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.치즈스틱_2조각_;
            pictureBox5.Location = new Point(483, 4);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(127, 176);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // rdio_czball
            // 
            rdio_czball.AutoSize = true;
            rdio_czball.Location = new Point(346, 187);
            rdio_czball.Name = "rdio_czball";
            rdio_czball.Size = new Size(63, 21);
            rdio_czball.TabIndex = 5;
            rdio_czball.TabStop = true;
            rdio_czball.Text = "+1500";
            rdio_czball.UseVisualStyleBackColor = true;
            rdio_czball.CheckedChanged += rdio_czball_CheckedChanged;
            // 
            // pb_ptt
            // 
            pb_ptt.Image = Properties.Resources.basic_ptt;
            pb_ptt.Location = new Point(3, 4);
            pb_ptt.Margin = new Padding(3, 4, 3, 4);
            pb_ptt.Name = "pb_ptt";
            pb_ptt.Size = new Size(127, 176);
            pb_ptt.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_ptt.TabIndex = 0;
            pb_ptt.TabStop = false;
            pb_ptt.Click += pb_ptt_Click;
            // 
            // rdio_czptt
            // 
            rdio_czptt.AutoSize = true;
            rdio_czptt.Location = new Point(193, 187);
            rdio_czptt.Name = "rdio_czptt";
            rdio_czptt.Size = new Size(63, 21);
            rdio_czptt.TabIndex = 4;
            rdio_czptt.TabStop = true;
            rdio_czptt.Text = "+1000";
            rdio_czptt.UseVisualStyleBackColor = true;
            rdio_czptt.CheckedChanged += rdio_czptt_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ptt;
            pictureBox2.Location = new Point(167, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 176);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // rdio_ptt
            // 
            rdio_ptt.AutoSize = true;
            rdio_ptt.Location = new Point(28, 187);
            rdio_ptt.Name = "rdio_ptt";
            rdio_ptt.Size = new Size(78, 21);
            rdio_ptt.TabIndex = 3;
            rdio_ptt.TabStop = true;
            rdio_ptt.Text = "변동없음";
            rdio_ptt.UseVisualStyleBackColor = true;
            rdio_ptt.CheckedChanged += rdio_ptt_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.czball;
            pictureBox4.Location = new Point(323, 4);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 176);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 216);
            panel3.Name = "panel3";
            panel3.Size = new Size(712, 50);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "음료수";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(rdio_fanta);
            panel2.Controls.Add(rdio_Zero);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(rdio_Cider);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(rdio_Coke);
            panel2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 212);
            panel2.TabIndex = 6;
            // 
            // rdio_fanta
            // 
            rdio_fanta.AutoSize = true;
            rdio_fanta.Location = new Point(357, 186);
            rdio_fanta.Name = "rdio_fanta";
            rdio_fanta.Size = new Size(52, 21);
            rdio_fanta.TabIndex = 13;
            rdio_fanta.TabStop = true;
            rdio_fanta.Text = "환타";
            rdio_fanta.UseVisualStyleBackColor = true;
            rdio_fanta.CheckedChanged += rdio_fanta_CheckedChanged;
            // 
            // rdio_Zero
            // 
            rdio_Zero.AutoSize = true;
            rdio_Zero.Location = new Point(498, 186);
            rdio_Zero.Name = "rdio_Zero";
            rdio_Zero.Size = new Size(78, 21);
            rdio_Zero.TabIndex = 14;
            rdio_Zero.TabStop = true;
            rdio_Zero.Text = "제로콜라";
            rdio_Zero.UseVisualStyleBackColor = true;
            rdio_Zero.CheckedChanged += rdio_Zero_CheckedChanged;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.zero;
            pictureBox7.Location = new Point(484, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(127, 176);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.fanta1;
            pictureBox6.Location = new Point(324, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(127, 176);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // rdio_Cider
            // 
            rdio_Cider.AutoSize = true;
            rdio_Cider.Location = new Point(194, 188);
            rdio_Cider.Margin = new Padding(3, 4, 3, 4);
            rdio_Cider.Name = "rdio_Cider";
            rdio_Cider.Size = new Size(65, 21);
            rdio_Cider.TabIndex = 3;
            rdio_Cider.TabStop = true;
            rdio_Cider.Text = "사이다";
            rdio_Cider.UseVisualStyleBackColor = true;
            rdio_Cider.CheckedChanged += rdio_Cider_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Cider;
            pictureBox3.Location = new Point(168, 4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 176);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Coke;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // rdio_Coke
            // 
            rdio_Coke.AutoSize = true;
            rdio_Coke.Location = new Point(41, 188);
            rdio_Coke.Margin = new Padding(3, 4, 3, 4);
            rdio_Coke.Name = "rdio_Coke";
            rdio_Coke.Size = new Size(52, 21);
            rdio_Coke.TabIndex = 1;
            rdio_Coke.TabStop = true;
            rdio_Coke.Text = "콜라";
            rdio_Coke.UseVisualStyleBackColor = true;
            rdio_Coke.CheckedChanged += rdio_Coke_CheckedChanged;
            // 
            // lb_Plz
            // 
            lb_Plz.AutoSize = true;
            lb_Plz.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Plz.Location = new Point(3, 772);
            lb_Plz.Name = "lb_Plz";
            lb_Plz.Size = new Size(195, 25);
            lb_Plz.TabIndex = 12;
            lb_Plz.Text = "요청사항 (최대 20자)";
            // 
            // tb_plz
            // 
            tb_plz.Location = new Point(6, 804);
            tb_plz.Multiline = true;
            tb_plz.Name = "tb_plz";
            tb_plz.Size = new Size(368, 23);
            tb_plz.TabIndex = 11;
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.Orange;
            btn_Confirm.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Confirm.FlatAppearance.BorderSize = 0;
            btn_Confirm.FlatStyle = FlatStyle.Flat;
            btn_Confirm.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirm.ForeColor = Color.White;
            btn_Confirm.Location = new Point(327, 865);
            btn_Confirm.Margin = new Padding(3, 4, 3, 4);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(150, 75);
            btn_Confirm.TabIndex = 10;
            btn_Confirm.Text = "확인";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.SaddleBrown;
            btn_Cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Cancel.FlatAppearance.BorderSize = 0;
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cancel.ForeColor = Color.White;
            btn_Cancel.Location = new Point(147, 866);
            btn_Cancel.Margin = new Padding(3, 4, 3, 4);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(150, 75);
            btn_Cancel.TabIndex = 9;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // lb_Price
            // 
            lb_Price.AutoSize = true;
            lb_Price.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Price.Location = new Point(556, 102);
            lb_Price.Name = "lb_Price";
            lb_Price.Size = new Size(94, 37);
            lb_Price.TabIndex = 8;
            lb_Price.Text = "label1";
            // 
            // tb_Cnt
            // 
            tb_Cnt.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Cnt.Location = new Point(290, 100);
            tb_Cnt.Margin = new Padding(3, 4, 3, 4);
            tb_Cnt.Multiline = true;
            tb_Cnt.Name = "tb_Cnt";
            tb_Cnt.Size = new Size(60, 43);
            tb_Cnt.TabIndex = 7;
            // 
            // btn_Plus
            // 
            btn_Plus.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Plus.Location = new Point(360, 100);
            btn_Plus.Margin = new Padding(3, 4, 3, 4);
            btn_Plus.Name = "btn_Plus";
            btn_Plus.Size = new Size(50, 44);
            btn_Plus.TabIndex = 6;
            btn_Plus.Text = "+";
            btn_Plus.UseVisualStyleBackColor = true;
            btn_Plus.Click += btn_Plus_Click;
            // 
            // btn_Minus
            // 
            btn_Minus.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Minus.Location = new Point(230, 100);
            btn_Minus.Margin = new Padding(3, 4, 3, 4);
            btn_Minus.Name = "btn_Minus";
            btn_Minus.Size = new Size(50, 44);
            btn_Minus.TabIndex = 5;
            btn_Minus.Text = "-";
            btn_Minus.UseVisualStyleBackColor = true;
            btn_Minus.Click += btn_Minus_Click;
            // 
            // lb_PrName
            // 
            lb_PrName.AutoSize = true;
            lb_PrName.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_PrName.Location = new Point(230, 21);
            lb_PrName.Name = "lb_PrName";
            lb_PrName.Size = new Size(94, 37);
            lb_PrName.TabIndex = 4;
            lb_PrName.Text = "label1";
            // 
            // pb_Product
            // 
            pb_Product.Location = new Point(9, 4);
            pb_Product.Margin = new Padding(3, 4, 3, 4);
            pb_Product.Name = "pb_Product";
            pb_Product.Size = new Size(170, 205);
            pb_Product.TabIndex = 3;
            pb_Product.TabStop = false;
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(725, 651);
            ControlBox = false;
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Option";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Option";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ptt).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pb_ptt;
        private RadioButton rdio_Coke;
        private RadioButton rdio_Cider;
        private PictureBox pictureBox3;
        private PictureBox pb_Product;
        private Label lb_PrName;
        private TextBox tb_Cnt;
        private Button btn_Plus;
        private Button btn_Minus;
        private Label lb_Price;
        private Button btn_Confirm;
        private Button btn_Cancel;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private RadioButton rdio_czball;
        private RadioButton rdio_czptt;
        private RadioButton rdio_ptt;
        private TextBox tb_plz;
        private Label lb_Plz;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private RadioButton rdio_fanta;
        private RadioButton rdio_Zero;
        private RadioButton rdio_stick_2;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
    }
}