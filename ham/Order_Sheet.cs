using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ham
{
    public partial class Order_Sheet : Form
    {
        public delegate void WriteEventHnadler(string ptt, string drink, string plz); //라벨 추가이벤트 핸들러
        public event WriteEventHnadler WriteEvent;
        public delegate void PriceSendEventHandler(int _price, int cnt); //데이터 전송 델리게이트(폼1에 보냄)
        public event PriceSendEventHandler PriceSend; //이벤트 생성
        public int Iprice; // 폼1에 전달할 가격
        public int Iresult = 0; // 가격오류있어서 선언해둠 -> (감자튀김 추가 후 수량 변동시) 수정해야함 나중에 필요없으면 삭제가능(쓰는곳 없음)        
        public int Iprice_burger;
        public string Sptt = "케이준 양념감자"; //기본 감자튀김 이름
        public string Sdrink = "콜라"; //기본 음료
        public string Splz = string.Empty; //기본 요청사항
        public void Set(int price)
        {
            Iresult = Iprice + price;
            lb_Price.Text = Iresult.ToString();
        }
        public void Set_Ptt(string ptt) // 감자튀김 이름 받기
        {
            Sptt = ptt;
        }
        public void Set_Drink(string drink) //음료수 이름 받기
        {
            Sdrink = drink;
        }
        public Order_Sheet() // 생성자
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            PriceSend += form1.Set_Price;
            WriteEvent += form1.Write;
            form1.Close();
        }
        public Order_Sheet(string x, string _price, string _name) // 매개변수 받아오는 생성자
        {
            InitializeComponent();
            Iprice_burger = int.Parse(_price); //버거 가격
            Form1 form1 = new Form1();
            PriceSend += form1.Set_Price;
            WriteEvent += form1.Write;
            form1.Close();
            Image_Sheet.Load(x); //이미지 로드(선택된 버거)
            Image_Sheet.SizeMode = PictureBoxSizeMode.StretchImage; // 이미지 크기에 맞게 맞춰주기
            lb_Name.Text = _name; // 버거이름 초기화
            Iprice = int.Parse(_price); // 가격 초기화
            lb_Price.Text = _price; // text에 가격 넣기
        }

        private void bnt_Plus_Click(object sender, EventArgs e)
        {
            int x = int.Parse(lb_Cnt.Text);  //수량변환
            x += 1;                          //수량변환
            lb_Cnt.Text = x.ToString();     //변환된 수량 Text로 수정
            if(Sptt.Equals("치즈뿌치 감자"))
            {
                Iprice +=1000;
            }
            else if(Sptt.Equals("바삭크림 치즈볼"))
            {
                Iprice += 1200; 
            }
            lb_Price.Text = (x * Iprice).ToString(); //총 가격 변경
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            int x = int.Parse(lb_Cnt.Text); //수량
            if (x > 1) //1보다 클 경우만 -가능
            {
                x -= 1;
            }
            lb_Cnt.Text = x.ToString(); // 수량변경
            lb_Price.Text = (x * Iprice).ToString(); //총 가격 변경
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Complete_Click(object sender, EventArgs e) // 완료 누르면 폼1에 있는 버튼 누르는식
        {
            if (tb_plz.Text == string.Empty) // 요청 사항이 비어있을시, 없음으로 초기화
            {
                Splz = "없음";
            }
            else
            {
                Splz = tb_plz.Text;
            }
            PriceSend(int.Parse(lb_Price.Text), int.Parse(lb_Cnt.Text)); // 폼1에 가격전달
            WriteEvent(Sptt, Sdrink, Splz); // 라벨생성
            this.Close();
        }

        private void btn_Drink_Click(object sender, EventArgs e)
        {
            Drink_Sheet drink_ = new Drink_Sheet();
            drink_.DrinkSend += new Drink_Sheet.DrinkSendEventHandler(Set_Drink);
            drink_.ShowDialog();
        }

        private void btn_Side_Click(object sender, EventArgs e)
        {
            Side_Form form = new Side_Form(int.Parse(lb_Price.Text));
            form.PriceSend2 += new Side_Form.PriceSendEventHandler(Set);
            form.PttSend += new Side_Form.PttSendEventHandler(Set_Ptt);
            form.ShowDialog();
        }
    }
}
