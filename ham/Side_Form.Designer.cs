namespace ham
{
    partial class Side_Form
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            rd_basic = new System.Windows.Forms.RadioButton();
            rd_czptt = new System.Windows.Forms.RadioButton();
            rd_czball = new System.Windows.Forms.RadioButton();
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Complete = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(44, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.8181839F));
            tableLayoutPanel1.Size = new System.Drawing.Size(535, 213);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.czball;
            pictureBox3.Location = new System.Drawing.Point(359, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(170, 206);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.basic_ptt;
            pictureBox2.Location = new System.Drawing.Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(170, 206);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ptt;
            pictureBox1.Location = new System.Drawing.Point(181, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(170, 206);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // rd_basic
            // 
            rd_basic.AutoSize = true;
            rd_basic.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rd_basic.Location = new System.Drawing.Point(79, 267);
            rd_basic.Name = "rd_basic";
            rd_basic.Size = new System.Drawing.Size(60, 25);
            rd_basic.TabIndex = 1;
            rd_basic.TabStop = true;
            rd_basic.Text = "기본";
            rd_basic.UseVisualStyleBackColor = true;
            // 
            // rd_czptt
            // 
            rd_czptt.AutoSize = true;
            rd_czptt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rd_czptt.Location = new System.Drawing.Point(266, 271);
            rd_czptt.Name = "rd_czptt";
            rd_czptt.Size = new System.Drawing.Size(75, 25);
            rd_czptt.TabIndex = 2;
            rd_czptt.TabStop = true;
            rd_czptt.Text = "+1000";
            rd_czptt.UseVisualStyleBackColor = true;
            // 
            // rd_czball
            // 
            rd_czball.AutoSize = true;
            rd_czball.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rd_czball.Location = new System.Drawing.Point(450, 267);
            rd_czball.Name = "rd_czball";
            rd_czball.Size = new System.Drawing.Size(75, 25);
            rd_czball.TabIndex = 3;
            rd_czball.TabStop = true;
            rd_czball.Text = "+1200";
            rd_czball.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new System.Drawing.Point(88, 484);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(201, 36);
            btn_Cancel.TabIndex = 4;
            btn_Cancel.Text = "취소";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Complete
            // 
            btn_Complete.Location = new System.Drawing.Point(340, 484);
            btn_Complete.Name = "btn_Complete";
            btn_Complete.Size = new System.Drawing.Size(201, 36);
            btn_Complete.TabIndex = 5;
            btn_Complete.Text = "확인";
            btn_Complete.UseVisualStyleBackColor = true;
            btn_Complete.Click += btn_Complete_Click;
            // 
            // Side_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(644, 585);
            Controls.Add(btn_Complete);
            Controls.Add(btn_Cancel);
            Controls.Add(rd_czball);
            Controls.Add(rd_czptt);
            Controls.Add(rd_basic);
            Controls.Add(tableLayoutPanel1);
            Name = "Side_Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Side_Form";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rd_basic;
        private System.Windows.Forms.RadioButton rd_czptt;
        private System.Windows.Forms.RadioButton rd_czball;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Complete;
    }
}