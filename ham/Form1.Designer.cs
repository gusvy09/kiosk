using System.Drawing;
using System.Windows.Forms;

namespace ham
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lb_Sum_Price = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_Confirm = new Button();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_Clear = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pn_copy = new Panel();
            tabControl1 = new TabControl();
            tpage_burger = new TabPage();
            btn_Back = new Button();
            btn_Next = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            lb_burger5 = new Label();
            lb_burger4 = new Label();
            lb_burger3 = new Label();
            lb_burger2 = new Label();
            lb_burger1 = new Label();
            lb_bName5 = new Label();
            lb_bName4 = new Label();
            lb_bName3 = new Label();
            lb_bName2 = new Label();
            lb_bName1 = new Label();
            pictureBox1 = new PictureBox();
            tpage_Ck = new TabPage();
            btn_ck_Next = new Button();
            btn_ck_Back = new Button();
            lb_Ck_Price4 = new Label();
            lb_Ck_Price3 = new Label();
            lb_Ck_Price2 = new Label();
            lb_Ck_Price1 = new Label();
            lb_ckName4 = new Label();
            lb_ckName3 = new Label();
            lb_ckName2 = new Label();
            lb_ckName1 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            Ss_Price = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpage_burger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tpage_Ck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lb_Sum_Price
            // 
            lb_Sum_Price.AutoSize = true;
            lb_Sum_Price.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Sum_Price.Location = new Point(3, 96);
            lb_Sum_Price.Name = "lb_Sum_Price";
            lb_Sum_Price.Size = new Size(22, 25);
            lb_Sum_Price.TabIndex = 4;
            lb_Sum_Price.Text = "0";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(button2, 0, 4);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 64, 64);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(3, 83);
            button2.Name = "button2";
            button2.Size = new Size(155, 14);
            button2.TabIndex = 7;
            button2.Text = "전체 취소";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(3, 37);
            button3.Name = "button3";
            button3.Size = new Size(155, 52);
            button3.TabIndex = 8;
            button3.Text = "결제확인";
            button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(btn_Confirm, 0, 5);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(lb_Sum_Price, 0, 3);
            tableLayoutPanel4.Controls.Add(label7, 0, 2);
            tableLayoutPanel4.Controls.Add(btn_Clear, 0, 4);
            tableLayoutPanel4.Location = new Point(720, 300);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8078814F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7487679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(161, 215);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = Color.DarkOrange;
            btn_Confirm.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Confirm.FlatAppearance.BorderSize = 0;
            btn_Confirm.FlatStyle = FlatStyle.Flat;
            btn_Confirm.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirm.ForeColor = Color.White;
            btn_Confirm.Location = new Point(3, 162);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(155, 50);
            btn_Confirm.TabIndex = 8;
            btn_Confirm.Text = "결제확인";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 32);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 7;
            label3.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 4;
            label6.Text = "주문 수량";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 64);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 3;
            label7.Text = "결제 금액";
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(128, 64, 64);
            btn_Clear.BackgroundImageLayout = ImageLayout.None;
            btn_Clear.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Clear.FlatAppearance.BorderSize = 0;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.ForeColor = Color.White;
            btn_Clear.Location = new Point(3, 126);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(155, 28);
            btn_Clear.TabIndex = 7;
            btn_Clear.Text = "전체 취소";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 34);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(601, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 11;
            label5.Text = "금액";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(479, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 10;
            label4.Text = "수량";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 9;
            label2.Text = "상품명";
            // 
            // pn_copy
            // 
            pn_copy.AutoScroll = true;
            pn_copy.BackColor = Color.Transparent;
            pn_copy.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pn_copy.Location = new Point(2, 340);
            pn_copy.Name = "pn_copy";
            pn_copy.Size = new Size(715, 175);
            pn_copy.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpage_burger);
            tabControl1.Controls.Add(tpage_Ck);
            tabControl1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(853, 282);
            tabControl1.TabIndex = 9;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tpage_burger
            // 
            tpage_burger.BackColor = Color.Transparent;
            tpage_burger.Controls.Add(btn_Back);
            tpage_burger.Controls.Add(btn_Next);
            tpage_burger.Controls.Add(pictureBox4);
            tpage_burger.Controls.Add(pictureBox3);
            tpage_burger.Controls.Add(pictureBox2);
            tpage_burger.Controls.Add(pictureBox5);
            tpage_burger.Controls.Add(lb_burger5);
            tpage_burger.Controls.Add(lb_burger4);
            tpage_burger.Controls.Add(lb_burger3);
            tpage_burger.Controls.Add(lb_burger2);
            tpage_burger.Controls.Add(lb_burger1);
            tpage_burger.Controls.Add(lb_bName5);
            tpage_burger.Controls.Add(lb_bName4);
            tpage_burger.Controls.Add(lb_bName3);
            tpage_burger.Controls.Add(lb_bName2);
            tpage_burger.Controls.Add(lb_bName1);
            tpage_burger.Controls.Add(pictureBox1);
            tpage_burger.Location = new Point(4, 30);
            tpage_burger.Name = "tpage_burger";
            tpage_burger.Padding = new Padding(3);
            tpage_burger.Size = new Size(845, 248);
            tpage_burger.TabIndex = 0;
            tpage_burger.Text = "햄버거세트";
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.DarkOrange;
            btn_Back.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.White;
            btn_Back.Location = new Point(683, 219);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(75, 23);
            btn_Back.TabIndex = 10;
            btn_Back.Text = "이전";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Next
            // 
            btn_Next.BackColor = Color.DarkOrange;
            btn_Next.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_Next.FlatAppearance.BorderSize = 0;
            btn_Next.FlatStyle = FlatStyle.Flat;
            btn_Next.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Next.ForeColor = Color.White;
            btn_Next.Location = new Point(764, 219);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 23);
            btn_Next.TabIndex = 11;
            btn_Next.Text = "다음";
            btn_Next.UseVisualStyleBackColor = false;
            btn_Next.Click += btn_Next_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(466, 8);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(130, 150);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(316, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(130, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(163, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(615, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(130, 150);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lb_burger5
            // 
            lb_burger5.AutoSize = true;
            lb_burger5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_burger5.Location = new Point(615, 203);
            lb_burger5.Name = "lb_burger5";
            lb_burger5.Size = new Size(47, 21);
            lb_burger5.TabIndex = 2;
            lb_burger5.Text = "price";
            // 
            // lb_burger4
            // 
            lb_burger4.AutoSize = true;
            lb_burger4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_burger4.Location = new Point(466, 203);
            lb_burger4.Name = "lb_burger4";
            lb_burger4.Size = new Size(47, 21);
            lb_burger4.TabIndex = 2;
            lb_burger4.Text = "price";
            // 
            // lb_burger3
            // 
            lb_burger3.AutoSize = true;
            lb_burger3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_burger3.Location = new Point(316, 203);
            lb_burger3.Name = "lb_burger3";
            lb_burger3.Size = new Size(47, 21);
            lb_burger3.TabIndex = 2;
            lb_burger3.Text = "price";
            // 
            // lb_burger2
            // 
            lb_burger2.AutoSize = true;
            lb_burger2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_burger2.Location = new Point(163, 203);
            lb_burger2.Name = "lb_burger2";
            lb_burger2.Size = new Size(47, 21);
            lb_burger2.TabIndex = 2;
            lb_burger2.Text = "price";
            // 
            // lb_burger1
            // 
            lb_burger1.AutoSize = true;
            lb_burger1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_burger1.Location = new Point(9, 203);
            lb_burger1.Name = "lb_burger1";
            lb_burger1.Size = new Size(47, 21);
            lb_burger1.TabIndex = 2;
            lb_burger1.Text = "price";
            // 
            // lb_bName5
            // 
            lb_bName5.AutoSize = true;
            lb_bName5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_bName5.Location = new Point(615, 161);
            lb_bName5.Name = "lb_bName5";
            lb_bName5.Size = new Size(74, 21);
            lb_bName5.TabIndex = 1;
            lb_bName5.Text = "버거이름";
            // 
            // lb_bName4
            // 
            lb_bName4.AutoSize = true;
            lb_bName4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_bName4.Location = new Point(466, 161);
            lb_bName4.Name = "lb_bName4";
            lb_bName4.Size = new Size(74, 21);
            lb_bName4.TabIndex = 1;
            lb_bName4.Text = "버거이름";
            // 
            // lb_bName3
            // 
            lb_bName3.AutoSize = true;
            lb_bName3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_bName3.Location = new Point(316, 161);
            lb_bName3.Name = "lb_bName3";
            lb_bName3.Size = new Size(74, 21);
            lb_bName3.TabIndex = 1;
            lb_bName3.Text = "버거이름";
            // 
            // lb_bName2
            // 
            lb_bName2.AutoSize = true;
            lb_bName2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_bName2.Location = new Point(163, 161);
            lb_bName2.Name = "lb_bName2";
            lb_bName2.Size = new Size(74, 21);
            lb_bName2.TabIndex = 1;
            lb_bName2.Text = "버거이름";
            // 
            // lb_bName1
            // 
            lb_bName1.AutoSize = true;
            lb_bName1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_bName1.Location = new Point(6, 161);
            lb_bName1.Name = "lb_bName1";
            lb_bName1.Size = new Size(74, 21);
            lb_bName1.TabIndex = 1;
            lb_bName1.Text = "버거이름";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tpage_Ck
            // 
            tpage_Ck.BackColor = Color.Transparent;
            tpage_Ck.Controls.Add(btn_ck_Next);
            tpage_Ck.Controls.Add(btn_ck_Back);
            tpage_Ck.Controls.Add(lb_Ck_Price4);
            tpage_Ck.Controls.Add(lb_Ck_Price3);
            tpage_Ck.Controls.Add(lb_Ck_Price2);
            tpage_Ck.Controls.Add(lb_Ck_Price1);
            tpage_Ck.Controls.Add(lb_ckName4);
            tpage_Ck.Controls.Add(lb_ckName3);
            tpage_Ck.Controls.Add(lb_ckName2);
            tpage_Ck.Controls.Add(lb_ckName1);
            tpage_Ck.Controls.Add(pictureBox9);
            tpage_Ck.Controls.Add(pictureBox8);
            tpage_Ck.Controls.Add(pictureBox7);
            tpage_Ck.Controls.Add(pictureBox6);
            tpage_Ck.Location = new Point(4, 30);
            tpage_Ck.Name = "tpage_Ck";
            tpage_Ck.Padding = new Padding(3);
            tpage_Ck.Size = new Size(845, 248);
            tpage_Ck.TabIndex = 1;
            tpage_Ck.Text = "치킨";
            // 
            // btn_ck_Next
            // 
            btn_ck_Next.BackColor = Color.DarkOrange;
            btn_ck_Next.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_ck_Next.FlatAppearance.BorderSize = 0;
            btn_ck_Next.FlatStyle = FlatStyle.Flat;
            btn_ck_Next.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ck_Next.ForeColor = Color.White;
            btn_ck_Next.Location = new Point(764, 219);
            btn_ck_Next.Name = "btn_ck_Next";
            btn_ck_Next.Size = new Size(75, 23);
            btn_ck_Next.TabIndex = 13;
            btn_ck_Next.Text = "다음";
            btn_ck_Next.UseVisualStyleBackColor = false;
            btn_ck_Next.Click += btn_ck_Next_Click;
            // 
            // btn_ck_Back
            // 
            btn_ck_Back.BackColor = Color.DarkOrange;
            btn_ck_Back.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_ck_Back.FlatAppearance.BorderSize = 0;
            btn_ck_Back.FlatStyle = FlatStyle.Flat;
            btn_ck_Back.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ck_Back.ForeColor = Color.White;
            btn_ck_Back.Location = new Point(683, 219);
            btn_ck_Back.Name = "btn_ck_Back";
            btn_ck_Back.Size = new Size(75, 23);
            btn_ck_Back.TabIndex = 12;
            btn_ck_Back.Text = "이전";
            btn_ck_Back.UseVisualStyleBackColor = false;
            btn_ck_Back.Click += btn_ck_Back_Click;
            // 
            // lb_Ck_Price4
            // 
            lb_Ck_Price4.AutoSize = true;
            lb_Ck_Price4.Location = new Point(587, 217);
            lb_Ck_Price4.Name = "lb_Ck_Price4";
            lb_Ck_Price4.Size = new Size(47, 21);
            lb_Ck_Price4.TabIndex = 11;
            lb_Ck_Price4.Text = "Price";
            // 
            // lb_Ck_Price3
            // 
            lb_Ck_Price3.AutoSize = true;
            lb_Ck_Price3.Location = new Point(400, 217);
            lb_Ck_Price3.Name = "lb_Ck_Price3";
            lb_Ck_Price3.Size = new Size(47, 21);
            lb_Ck_Price3.TabIndex = 10;
            lb_Ck_Price3.Text = "Price";
            // 
            // lb_Ck_Price2
            // 
            lb_Ck_Price2.AutoSize = true;
            lb_Ck_Price2.Location = new Point(209, 217);
            lb_Ck_Price2.Name = "lb_Ck_Price2";
            lb_Ck_Price2.Size = new Size(47, 21);
            lb_Ck_Price2.TabIndex = 9;
            lb_Ck_Price2.Text = "Price";
            // 
            // lb_Ck_Price1
            // 
            lb_Ck_Price1.AutoSize = true;
            lb_Ck_Price1.Location = new Point(34, 217);
            lb_Ck_Price1.Name = "lb_Ck_Price1";
            lb_Ck_Price1.Size = new Size(47, 21);
            lb_Ck_Price1.TabIndex = 8;
            lb_Ck_Price1.Text = "Price";
            // 
            // lb_ckName4
            // 
            lb_ckName4.AutoSize = true;
            lb_ckName4.Location = new Point(587, 180);
            lb_ckName4.Name = "lb_ckName4";
            lb_ckName4.Size = new Size(82, 21);
            lb_ckName4.TabIndex = 7;
            lb_ckName4.Text = "Ck_Name";
            // 
            // lb_ckName3
            // 
            lb_ckName3.AutoSize = true;
            lb_ckName3.Location = new Point(400, 180);
            lb_ckName3.Name = "lb_ckName3";
            lb_ckName3.Size = new Size(82, 21);
            lb_ckName3.TabIndex = 6;
            lb_ckName3.Text = "Ck_Name";
            // 
            // lb_ckName2
            // 
            lb_ckName2.AutoSize = true;
            lb_ckName2.Location = new Point(209, 180);
            lb_ckName2.Name = "lb_ckName2";
            lb_ckName2.Size = new Size(82, 21);
            lb_ckName2.TabIndex = 5;
            lb_ckName2.Text = "Ck_Name";
            // 
            // lb_ckName1
            // 
            lb_ckName1.AutoSize = true;
            lb_ckName1.Location = new Point(34, 180);
            lb_ckName1.Name = "lb_ckName1";
            lb_ckName1.Size = new Size(82, 21);
            lb_ckName1.TabIndex = 4;
            lb_ckName1.Text = "Ck_Name";
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(587, 22);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(130, 150);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(400, 22);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(130, 150);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(209, 22);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(130, 150);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(34, 22);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(130, 150);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 193);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // Ss_Price
            // 
            Ss_Price.AutoSize = true;
            Ss_Price.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Ss_Price.Location = new Point(131, 218);
            Ss_Price.Name = "Ss_Price";
            Ss_Price.Size = new Size(0, 25);
            Ss_Price.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.logo1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 519);
            Controls.Add(Ss_Price);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(pn_copy);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel4);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpage_burger.ResumeLayout(false);
            tpage_burger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tpage_Ck.ResumeLayout(false);
            tpage_Ck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_Sum_Price;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btn_Clear;
        private Button btn_Confirm;
        private Label label3;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel pn_copy;
        private Label label5;
        private Label label4;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tpage_burger;
        private PictureBox pictureBox1;
        private TabPage tpage_Ck;
        private Label label1;
        private Label Ss_Price;
        private Label lb_burger1;
        private Label lb_bName1;
        private Label lb_burger5;
        private Label lb_burger4;
        private Label lb_burger3;
        private Label lb_burger2;
        private Label lb_bName5;
        private Label lb_bName4;
        private Label lb_bName3;
        private Label lb_bName2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Button btn_Back;
        private Button btn_Next;
        private Label lb_Ck_Price4;
        private Label lb_Ck_Price3;
        private Label lb_Ck_Price2;
        private Label lb_Ck_Price1;
        private Label lb_ckName4;
        private Label lb_ckName3;
        private Label lb_ckName2;
        private Label lb_ckName1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Button btn_ck_Next;
        private Button btn_ck_Back;
    }
}
