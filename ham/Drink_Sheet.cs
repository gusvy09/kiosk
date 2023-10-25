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
    public partial class Drink_Sheet : Form
    {
        // 델리게이트 선언 및 이벤트 생성
        public delegate void DrinkSendEventHandler(string _drink);
        public DrinkSendEventHandler DrinkSend;
        public Drink_Sheet()
        {
            InitializeComponent();
            rdio_Coke.Checked = true; //음료 기본 콜라선택
            Order_Sheet order_ = new Order_Sheet();
            DrinkSend += order_.Set_Drink;
        }

        private void button1_Click(object sender, EventArgs e) //취소버튼
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //확인버튼
        {
            if(rdio_Cider.Checked)
            {
                DrinkSend("사이다");
            }
            else if(rdio_Cider.Checked)
            {
                DrinkSend("콜라");
            }
            this.Close();
        }
    }
}
