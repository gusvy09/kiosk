using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ham
{
    public partial class Pay : Form
    {
        public delegate void PayEventHandler();
        public event PayEventHandler PayCompleted;

        int Price_Pay = 0;
        int type = -1;
        double time = 5;
        public Pay()
        {
            InitializeComponent();
        }
        public Pay(int Price)
        {

            InitializeComponent();
            Price_Pay = Price;
        }

        private void btn_Cash_Click(object sender, EventArgs e) //현금 버튼 누를시 버튼 색 바꾸기 및 결제방식 type교체
        {
            btn_Card.BackColor = Color.Transparent;
            btn_Kakao.BackColor = Color.Transparent;
            btn_Cash.BackColor = Color.White;
            type = 0;

        }

        private void btn_Card_Click(object sender, EventArgs e) //카드
        {
            btn_Cash.BackColor = Color.Transparent;
            btn_Kakao.BackColor = Color.Transparent;
            btn_Card.BackColor = Color.White;
            type = 1;
        }

        private void btn_Kakao_Click(object sender, EventArgs e) //페이
        {
            btn_Card.BackColor = Color.Transparent;
            btn_Cash.BackColor = Color.Transparent;
            btn_Kakao.BackColor = Color.White;
            type = 2;
        }

        private void button1_Click(object sender, EventArgs e) //취소
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //확인
        {
            switch (type)
            {
                case -1:
                    MessageBox.Show("결제방식을 선택해주세요");
                    break;
                case 0:
                    MessageBox.Show($"현금 결제를 선택하셨습니다.\n가격은 {Price_Pay}원 입니다.");
                    PayCompleted();
                    this.Close();
                    break;
                case 1:
                    MessageBox.Show("카드를 투입해주세요");
                    timer_Card.Start();
                    break;
                case 2:
                    break;
            }
        }

        private void timer_Card_Tick(object sender, EventArgs e)
        {
            if(time<=0)
            {
                timer_Card.Stop();
                MessageBox.Show("결제가 끝났습니다");
                lb_Time.Text = string.Empty;
                PayCompleted();
                this.Close();
                return;
            }
            lb_Time.Text = string.Format($"{time:0.0}");
            time -= 0.1;
        }
    }
}
