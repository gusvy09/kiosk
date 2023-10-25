namespace ham
{
    partial class Drink_Sheet
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
            button1 = new System.Windows.Forms.Button();
            pb_Coke = new System.Windows.Forms.PictureBox();
            rdio_Coke = new System.Windows.Forms.RadioButton();
            button2 = new System.Windows.Forms.Button();
            pb_Cider = new System.Windows.Forms.PictureBox();
            rdio_Cider = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)pb_Coke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Cider).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(39, 356);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 42);
            button1.TabIndex = 0;
            button1.Text = "취소";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pb_Coke
            // 
            pb_Coke.Image = Properties.Resources.Coke;
            pb_Coke.Location = new System.Drawing.Point(22, 50);
            pb_Coke.Name = "pb_Coke";
            pb_Coke.Size = new System.Drawing.Size(130, 140);
            pb_Coke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_Coke.TabIndex = 1;
            pb_Coke.TabStop = false;
            // 
            // rdio_Coke
            // 
            rdio_Coke.AutoSize = true;
            rdio_Coke.Location = new System.Drawing.Point(63, 214);
            rdio_Coke.Name = "rdio_Coke";
            rdio_Coke.Size = new System.Drawing.Size(49, 19);
            rdio_Coke.TabIndex = 2;
            rdio_Coke.TabStop = true;
            rdio_Coke.Text = "콜라";
            rdio_Coke.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(187, 356);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(113, 42);
            button2.TabIndex = 3;
            button2.Text = "확인";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pb_Cider
            // 
            pb_Cider.Image = Properties.Resources.Cider;
            pb_Cider.Location = new System.Drawing.Point(187, 50);
            pb_Cider.Name = "pb_Cider";
            pb_Cider.Size = new System.Drawing.Size(130, 140);
            pb_Cider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_Cider.TabIndex = 4;
            pb_Cider.TabStop = false;
            // 
            // rdio_Cider
            // 
            rdio_Cider.AutoSize = true;
            rdio_Cider.Location = new System.Drawing.Point(224, 214);
            rdio_Cider.Name = "rdio_Cider";
            rdio_Cider.Size = new System.Drawing.Size(61, 19);
            rdio_Cider.TabIndex = 5;
            rdio_Cider.TabStop = true;
            rdio_Cider.Text = "사이다";
            rdio_Cider.UseVisualStyleBackColor = true;
            // 
            // Drink_Sheet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(344, 426);
            Controls.Add(rdio_Cider);
            Controls.Add(pb_Cider);
            Controls.Add(button2);
            Controls.Add(rdio_Coke);
            Controls.Add(pb_Coke);
            Controls.Add(button1);
            Name = "Drink_Sheet";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Drink_Sheet";
            ((System.ComponentModel.ISupportInitialize)pb_Coke).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Cider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_Coke;
        private System.Windows.Forms.RadioButton rdio_Coke;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pb_Cider;
        private System.Windows.Forms.RadioButton rdio_Cider;
    }
}