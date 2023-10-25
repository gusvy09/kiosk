namespace ham
{
    partial class Order_Sheet
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
            Image_Sheet = new System.Windows.Forms.PictureBox();
            lb_Cnt = new System.Windows.Forms.Label();
            btn_Minus = new System.Windows.Forms.Button();
            bnt_Plus = new System.Windows.Forms.Button();
            lb_Name = new System.Windows.Forms.Label();
            btn_Side = new System.Windows.Forms.Button();
            btn_Drink = new System.Windows.Forms.Button();
            Btn_Cancel = new System.Windows.Forms.Button();
            btn_Complete = new System.Windows.Forms.Button();
            lb_Price = new System.Windows.Forms.Label();
            lb_plz = new System.Windows.Forms.Label();
            tb_plz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)Image_Sheet).BeginInit();
            SuspendLayout();
            // 
            // Image_Sheet
            // 
            Image_Sheet.Location = new System.Drawing.Point(123, 40);
            Image_Sheet.Name = "Image_Sheet";
            Image_Sheet.Size = new System.Drawing.Size(201, 172);
            Image_Sheet.TabIndex = 0;
            Image_Sheet.TabStop = false;
            // 
            // lb_Cnt
            // 
            lb_Cnt.AutoSize = true;
            lb_Cnt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Cnt.Location = new System.Drawing.Point(218, 244);
            lb_Cnt.Name = "lb_Cnt";
            lb_Cnt.Size = new System.Drawing.Size(19, 21);
            lb_Cnt.TabIndex = 1;
            lb_Cnt.Text = "1";
            // 
            // btn_Minus
            // 
            btn_Minus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Minus.Location = new System.Drawing.Point(123, 232);
            btn_Minus.Name = "btn_Minus";
            btn_Minus.Size = new System.Drawing.Size(75, 34);
            btn_Minus.TabIndex = 2;
            btn_Minus.Text = "-";
            btn_Minus.UseVisualStyleBackColor = true;
            btn_Minus.Click += btn_Minus_Click;
            // 
            // bnt_Plus
            // 
            bnt_Plus.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bnt_Plus.Location = new System.Drawing.Point(249, 231);
            bnt_Plus.Name = "bnt_Plus";
            bnt_Plus.Size = new System.Drawing.Size(75, 34);
            bnt_Plus.TabIndex = 3;
            bnt_Plus.Text = "+";
            bnt_Plus.UseVisualStyleBackColor = true;
            bnt_Plus.Click += bnt_Plus_Click;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Name.Location = new System.Drawing.Point(157, 269);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new System.Drawing.Size(140, 30);
            lb_Name.TabIndex = 4;
            lb_Name.Text = "Burger_Name";
            // 
            // btn_Side
            // 
            btn_Side.Location = new System.Drawing.Point(123, 339);
            btn_Side.Name = "btn_Side";
            btn_Side.Size = new System.Drawing.Size(201, 36);
            btn_Side.TabIndex = 5;
            btn_Side.Text = "사이드 옵션";
            btn_Side.UseVisualStyleBackColor = true;
            btn_Side.Click += btn_Side_Click;
            // 
            // btn_Drink
            // 
            btn_Drink.Location = new System.Drawing.Point(123, 381);
            btn_Drink.Name = "btn_Drink";
            btn_Drink.Size = new System.Drawing.Size(201, 36);
            btn_Drink.TabIndex = 6;
            btn_Drink.Text = "음료옵션";
            btn_Drink.UseVisualStyleBackColor = true;
            btn_Drink.Click += btn_Drink_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new System.Drawing.Point(12, 544);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new System.Drawing.Size(201, 36);
            Btn_Cancel.TabIndex = 8;
            Btn_Cancel.Text = "취소";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // btn_Complete
            // 
            btn_Complete.Location = new System.Drawing.Point(218, 544);
            btn_Complete.Name = "btn_Complete";
            btn_Complete.Size = new System.Drawing.Size(201, 36);
            btn_Complete.TabIndex = 9;
            btn_Complete.Text = "완료";
            btn_Complete.UseVisualStyleBackColor = true;
            btn_Complete.Click += btn_Complete_Click;
            // 
            // lb_Price
            // 
            lb_Price.AutoSize = true;
            lb_Price.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Price.Location = new System.Drawing.Point(193, 311);
            lb_Price.Name = "lb_Price";
            lb_Price.Size = new System.Drawing.Size(54, 25);
            lb_Price.TabIndex = 10;
            lb_Price.Text = "Price";
            // 
            // lb_plz
            // 
            lb_plz.AutoSize = true;
            lb_plz.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_plz.Location = new System.Drawing.Point(123, 420);
            lb_plz.Name = "lb_plz";
            lb_plz.Size = new System.Drawing.Size(156, 21);
            lb_plz.TabIndex = 11;
            lb_plz.Text = "요청사항(최대 14자)";
            // 
            // tb_plz
            // 
            tb_plz.Location = new System.Drawing.Point(123, 444);
            tb_plz.MaxLength = 14;
            tb_plz.Multiline = true;
            tb_plz.Name = "tb_plz";
            tb_plz.Size = new System.Drawing.Size(201, 73);
            tb_plz.TabIndex = 12;
            // 
            // Order_Sheet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(429, 596);
            Controls.Add(tb_plz);
            Controls.Add(lb_plz);
            Controls.Add(lb_Price);
            Controls.Add(btn_Complete);
            Controls.Add(Btn_Cancel);
            Controls.Add(btn_Drink);
            Controls.Add(btn_Side);
            Controls.Add(lb_Name);
            Controls.Add(bnt_Plus);
            Controls.Add(btn_Minus);
            Controls.Add(lb_Cnt);
            Controls.Add(Image_Sheet);
            Name = "Order_Sheet";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Order_Sheet";
            ((System.ComponentModel.ISupportInitialize)Image_Sheet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Image_Sheet;
        private System.Windows.Forms.Label lb_Cnt;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button bnt_Plus;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Side;
        private System.Windows.Forms.Button btn_Drink;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button btn_Complete;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_plz;
        private System.Windows.Forms.TextBox tb_plz;
    }
}