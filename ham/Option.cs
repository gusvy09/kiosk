using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ham
{
    public partial class Option : Form
    {
        public string Sptt = "케이준 양념감자"; //기본 감자튀김 이름
        public string Sdrink = "콜라"; //기본 음료
        public string Splz = string.Empty; //기본 요청사항
        public delegate void WriteEventHnadler(string ptt, string drink, string plz); //라벨 추가이벤트 핸들러
        public event WriteEventHnadler WriteEvent;
        public delegate void PriceSendEventHandler(int _price, int cnt); //데이터 전송 델리게이트(폼1에 보냄)
        public event PriceSendEventHandler PriceSend; //이벤트 생성
        public int Side_Price = 0; // 사이드 추가비용
        int Price; // 버거 가격

        public Option()
        {
            InitializeComponent();
        }
        public Option(string image_name, string Product_Price, string Product_Name) // 생성자 매개변수 이용, 이미지 로드 및 가격, 개수 초기화
        {
            InitializeComponent();
            pb_Product.Load(image_name);
            pb_Product.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_PrName.Text = Product_Name;
            lb_Price.Text = Product_Price;
            tb_Cnt.Text = "1";
            Price = int.Parse(lb_Price.Text); // 버거가격 고정
            rdio_Coke.Checked = true;

        }
        public Option(PictureBox picture, string Product_Price, string Product_Name)
        {
            InitializeComponent();
            pb_Product.Image = picture.Image;
            pb_Product.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_PrName.Text = Product_Name;
            lb_Price.Text = Product_Price;
            tb_Cnt.Text = "1";
            Price = int.Parse(lb_Price.Text); // 버거가격 고정
            rdio_Coke.Checked = true;
            rdio_ptt.Checked = true;





            //Group Box 테두리
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (tb_plz.Text == string.Empty) // 요청 사항이 비어있을시, 없음으로 초기화
            {
                Splz = "없음";
            }
            else
            {
                Splz = tb_plz.Text;
            }
            PriceSend(int.Parse(lb_Price.Text), int.Parse(tb_Cnt.Text)); // 폼1에 가격전달
            WriteEvent(Sptt, Sdrink, Splz); // 라벨생성
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            int Cnt = int.Parse(tb_Cnt.Text);

            if (Cnt > 1)
            {
                Cnt -= 1;
                tb_Cnt.Text = Cnt.ToString();
                lb_Price.Text = (Price * Cnt + Side_Price).ToString();
            }


        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            int Cnt = int.Parse(tb_Cnt.Text);

            Cnt += 1;

            tb_Cnt.Text = Cnt.ToString();
            lb_Price.Text = (Price * Cnt + Side_Price).ToString();
        }

        private void rdio_czptt_CheckedChanged(object sender, EventArgs e) //선택시 +1000
        {
            if (rdio_czptt.Checked)
            {
                Sptt = "치즈뿌치 감자";
                Side_Price += 1000;
                lb_Price.Text = (Price * int.Parse(tb_Cnt.Text) + Side_Price).ToString();
            }
            else
            {
                Side_Price = 0;
                lb_Price.Text = (Price * int.Parse(tb_Cnt.Text) + Side_Price).ToString();
            }
        }

        private void rdio_czball_CheckedChanged(object sender, EventArgs e) //치즈볼 선택시 +1500
        {
            if (rdio_czball.Checked)
            {
                Side_Price += 1500;
                Sptt = "바삭크림 치즈볼";
                lb_Price.Text = (Price * int.Parse(tb_Cnt.Text) + Side_Price).ToString();
            }
            else
            {
                Side_Price = 0;
                lb_Price.Text = (Price * int.Parse(tb_Cnt.Text) + Side_Price).ToString();
            }
        }

        private void rdio_ptt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_ptt.Checked)
            {
                Sptt = "케이준 양념감자";
            }
        }

        private void rdio_Cider_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_Cider.Checked)
            {
                Sdrink = "사이다";
            }
        }

        private void rdio_Coke_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_Coke.Checked)
            {
                Sdrink = "콜라";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rdio_Coke.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rdio_Cider.Checked = true;
        }

        private void pb_ptt_Click(object sender, EventArgs e)
        {
            rdio_ptt.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rdio_czptt.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rdio_czball.Checked = true;
        }

        private void rdio_fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_fanta.Checked)
            {
                Sdrink = "환타";
            }
        }

        private void rdio_Zero_CheckedChanged(object sender, EventArgs e)
        {
            if (rdio_Zero.Checked)
            {
                Sdrink = "제로콜라";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rdio_fanta.Checked = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            rdio_Zero.Checked = true;
        }

        private void rdio_stick_2_CheckedChanged(object sender, EventArgs e) // 체크되면 문자열 전달 바뀜
        {
            if (rdio_stick_2.Checked)
            {
                Sptt = "치즈스틱(2조각)";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e) //치즈스틱 이미지 누르면 체크
        {
            rdio_stick_2.Checked = true;
        }


    }
}
