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
    public partial class Side_Form : Form
    {
        public delegate void PriceSendEventHandler(int price); // 데이터 전송 델리게이트 선언(Order_Sheet에 전송)
        public event PriceSendEventHandler PriceSend2; // 이벤트 생성

        //감자튀김 이름 데이터 전달
        public delegate void PttSendEventHandler(string ptt);
        public event PttSendEventHandler PttSend;
        public int Iburger;
        public int Iczball = 1200;
        public int Iczptt = 1000;
        public int Iprice = 0; // 넘겨야할 값
        public Side_Form()
        {
            InitializeComponent();
            rd_basic.Checked = true; // 생성자에서 기본메뉴 자동선택
            Order_Sheet form1 = new Order_Sheet(); //델리게이트에 함수 더해주기
            PriceSend2 += form1.Set;
            PttSend += form1.Set_Ptt;
            form1.Close();
        }
        public Side_Form(int _price)
        {
            Iburger = _price;
            Iprice = _price;
            InitializeComponent();
            rd_basic.Checked = true; // 생성자에서 기본메뉴 자동선택
            Order_Sheet form1 = new Order_Sheet(); //델리게이트에 함수 더해주기
            PriceSend2 += form1.Set;
            PttSend += form1.Set_Ptt;
            form1.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Complete_Click(object sender, EventArgs e)
        {
            if(rd_czball.Checked) 
            {
                Iprice = Iburger + Iczball;
                PriceSend2(Iczball);
                PttSend("바삭크림 치즈볼");
            }
            else if(rd_czptt.Checked)
            {
                
                Iprice = Iburger + Iczptt;
                PriceSend2(Iczptt);
                PttSend("치즈뿌치 감자");
            }            
            else
            {
                Iprice = Iburger;
                PriceSend2(0);
                PttSend("케이준 양념감자");
            }
            this.Close();
        }
    }
}
