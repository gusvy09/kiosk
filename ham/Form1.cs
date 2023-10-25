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

    public partial class Form1 : Form
    {
        public int Price = 0; // 총 가격
        public string SName = "";
        public string SPrice = "";
        public int i = 0;
        public int j = 0;
        public int k = 0;
        int Iburger_page; // 햄버거 페이지
        int ICk_page;
        int _height = 50; // 결제창 간격 

        // Order폼에서 전달받은 햄버거 개수, 가격 및 요청사항
        string burger_cnt = string.Empty;
        string burger_price = string.Empty;
        string plz = string.Empty;
        public void Clear()
        {
            i = 0;
            j = 0;
            k = 0;
            Price = 0;
            lb_Sum_Price.Text = Price.ToString();
            pn_copy.Controls.Clear();
        }
        public void Set_Price(int _price, int cnt) //델리게이트 가격 및 개수 전달받음
        {
            if (lb_Sum_Price.Text.Contains("원")) //한글이 포함되어 있으면 문자열을 잘라서 변환
            {
                Price = int.Parse(lb_Sum_Price.Text.Substring(0, lb_Sum_Price.Text.Length - 1)); // 총가격 + 전달받은 가격
            }
            else
            {
                Price = int.Parse(lb_Sum_Price.Text);
            }

            lb_Sum_Price.Text = string.Format($"{Price + _price}원"); //(Price + _price).ToString();
            burger_price = _price.ToString();
            burger_cnt = cnt.ToString();
        }
        public void Write(string ptt, string drink, string plz) // 오더창에서 확인버튼 눌리면 라벨생성
        {
            int btn_left = 0;
            int btn_right = 0;
            //상품명

            Label _lb = new System.Windows.Forms.Label();
            _lb.Location = new System.Drawing.Point(0, 0 + i * _height);
            _lb.Name = "_lb" + i.ToString();
            _lb.Size = new System.Drawing.Size(480, 35);
            _lb.TabIndex = i;
            _lb.Text = $"{SName}({ptt}, 음료 : {drink}, 요청사항 : {plz})";
            pn_copy.Controls.Add(_lb);
            i += 1;

            //버튼
            /*Button btn_minus = new System.Windows.Forms.Button();
            btn_minus.Location = new System.Drawing.Point(480, 0 + btn_left * 30);
            btn_minus.Width = 20;
            btn_minus.Height = 20;
            btn_minus.Name = "btn_left" + btn_left.ToString();
            btn_left += 1;
            pn_copy.Controls.Add(btn_minus);*/


            //수량 (버튼생성해야됨) 앞뒤로
            Label _lb_num = new System.Windows.Forms.Label();
            _lb_num.Location = new System.Drawing.Point(500, 0 + j * _height);
            _lb_num.Name = "_lb_num" + j.ToString();
            _lb_num.Size = new System.Drawing.Size(100, 35);
            _lb_num.TabIndex = j;
            _lb_num.Text = burger_cnt;
            pn_copy.Controls.Add(_lb_num);
            j += 1;

            //가격

            Label _lb_price = new System.Windows.Forms.Label();
            _lb_price.Location = new System.Drawing.Point(601, 0 + k * _height);
            _lb_price.Name = "_lb_price" + k.ToString();
            _lb_price.Size = new System.Drawing.Size(100, 35);
            _lb_price.TabIndex = k;
            _lb_price.Text = burger_price;
            pn_copy.Controls.Add(_lb_price);
            k += 1;

            //마지막 삭제버튼 추가해야됨
        }
        public Form1()
        {
            InitializeComponent();

            Iburger_page = 0;
            ICk_page = 0;
            lb_Sum_Price.Text = Price.ToString(); //총 가격 초기화

            //햄버거 PictureBox 초기화
            pictureBox1.Image = Properties.Resources.싸이버거;
            lb_bName1.Text = "싸이버거세트";
            lb_burger1.Text = "6600";

            pictureBox2.Image = Properties.Resources.간장마늘싸이버거;
            lb_bName2.Text = "간장마늘싸이\n버거세트";
            lb_burger2.Text = "6700";

            pictureBox3.Image = Properties.Resources.불싸이버거;
            lb_bName3.Text = "불싸이버거세트";
            lb_burger3.Text = "6700";

            pictureBox4.Image = Properties.Resources.인크레더블버거;
            lb_bName4.Text = "인크레더블\n버거세트";
            lb_burger4.Text = "7700";

            pictureBox5.Image = Properties.Resources.양념치킨싸이버거;
            lb_bName5.Text = "양념치킨싸이\n버거세트";
            lb_burger5.Text = "6700";

            //치킨 PictureBox 초기화
            pictureBox6.Image = Properties.Resources.후라이드치킨;
            lb_ckName1.Text = "후라이드치킨";
            lb_Ck_Price1.Text = "16900";

            pictureBox7.Image = Properties.Resources.맘스양념치킨;
            lb_ckName2.Text = "맘스양념치킨";
            lb_Ck_Price2.Text = "18900";

            pictureBox8.Image = Properties.Resources.반반치킨;
            lb_ckName3.Text = "반반치킨";
            lb_Ck_Price3.Text = "17900";

            pictureBox9.Image = Properties.Resources.간장마늘치킨;
            lb_ckName4.Text = "간장마늘치킨";
            lb_Ck_Price4.Text = "18900";




        }


        private void pictureBox1_Click(object sender, EventArgs e) // 햄버거 1번이미지
        {
            SName = lb_bName1.Text; // 첫번째 이미지 박스 
            SPrice = lb_burger1.Text;
            Option order_Sheet = new Option(pictureBox1, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 상품명

            /*Label _lb = new System.Windows.Forms.Label();
            _lb.Location = new System.Drawing.Point(0, 0 + i * 30);
            _lb.Name = "_lb" + i.ToString();
            _lb.Size = new System.Drawing.Size(100, 23);
            _lb.TabIndex = i;
            _lb.Text = SName;
            pn_copy.Controls.Add(_lb);
            i += 1;

            //수량

            Label _lb_num = new System.Windows.Forms.Label();
            _lb_num.Location = new System.Drawing.Point(479, 0 + j * 30);
            _lb_num.Name = "_lb_num" + j.ToString();
            _lb_num.Size = new System.Drawing.Size(100, 23);
            _lb_num.TabIndex = j;
            _lb_num.Text = burger_cnt;
            pn_copy.Controls.Add(_lb_num);
            j += 1;

            //가격

            Label _lb_price = new System.Windows.Forms.Label();
            _lb_price.Location = new System.Drawing.Point(601, 0 + k * 30);
            _lb_price.Name = "_lb_price" + k.ToString();
            _lb_price.Size = new System.Drawing.Size(100, 23);
            _lb_price.TabIndex = k;
            _lb_price.Text = burger_price;
            pn_copy.Controls.Add(_lb_price);
            k += 1;*/



        }

        private void button4_Click(object sender, EventArgs e) //전체 초기화(판넬 초기화)
        {
            Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //
        {
            SName = lb_bName2.Text;
            SPrice = lb_burger2.Text;
            Option order_Sheet = new Option(pictureBox2, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SName = lb_bName3.Text;
            SPrice = lb_burger3.Text;
            Option order_Sheet = new Option(pictureBox3, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SName = lb_bName4.Text;
            SPrice = lb_burger4.Text;
            Option order_Sheet = new Option(pictureBox4, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SName = lb_bName5.Text;
            SPrice = lb_burger5.Text;
            Option order_Sheet = new Option(pictureBox5, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e) //이전 페이지 이동
        {
            if (Iburger_page > 0)
            {
                Iburger_page -= 1;
            }

            /*if (Iburger_page <= 0)
            {
                btn_Back.Visible = false;
            }
            else
                btn_Back.Visible = true;*/

            Hamburger_Page();
        }

        private void btn_Next_Click(object sender, EventArgs e) //다음 페이지
        {
            Iburger_page += 1;
            /*if (Iburger_page <= 0)
            {
                btn_Back.Visible = false;
            }
            else
                btn_Back.Visible = true;*/
            Hamburger_Page();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) // tabpage 바뀔때 발생하는 이벤트
        {

        }

        private void btn_ck_Back_Click(object sender, EventArgs e) // 치킨탭 이전
        {
            if (ICk_page > 0)
            {
                ICk_page -= 1;
            }

            Chicken_Page();
        }

        private void btn_ck_Next_Click(object sender, EventArgs e) //치킨탭 다음
        {
            ICk_page += 1;
            Chicken_Page();
        }


        private void pictureBox6_Click(object sender, EventArgs e) //치킨탭 1번이미지
        {
            SName = lb_ckName1.Text;
            SPrice = lb_Ck_Price1.Text;
            Option order_Sheet = new Option(pictureBox6, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)//치킨탭 2번이미지
        {
            SName = lb_ckName2.Text;
            SPrice = lb_Ck_Price2.Text;
            Option order_Sheet = new Option(pictureBox7, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)//치킨탭 3번이미지
        {
            SName = lb_ckName3.Text;
            SPrice = lb_Ck_Price3.Text;
            Option order_Sheet = new Option(pictureBox8, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)//치킨탭 4번이미지
        {
            SName = lb_ckName4.Text;
            SPrice = lb_Ck_Price4.Text;
            Option order_Sheet = new Option(pictureBox9, SPrice, SName);
            order_Sheet.PriceSend += new Option.PriceSendEventHandler(Set_Price);
            order_Sheet.WriteEvent += new Option.WriteEventHnadler(Write);
            order_Sheet.ShowDialog();
        }

        private void Chicken_Page() //치킨 탭 페이지 
        {
            if (ICk_page % 2 == 1)
            {
                pictureBox6.Image = Properties.Resources.군옥수수뿌치;
                lb_ckName1.Text = "군옥수수뿌치";
                lb_Ck_Price1.Text = "18900";

                pictureBox7.Image = Properties.Resources.꿀간장누룽지치킨;
                lb_ckName2.Text = "꿀간장누룽지치킨";
                lb_Ck_Price2.Text = "19500";

                pictureBox8.Image = Properties.Resources.허니버터뿌치;
                lb_ckName3.Text = "허니버터뿌치";
                lb_Ck_Price3.Text = "18900";

                pictureBox9.Image = Properties.Resources.치즈뿌치;
                lb_ckName4.Text = "치즈뿌치(체다)";
                lb_Ck_Price4.Text = "18900";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.후라이드치킨;
                lb_ckName1.Text = "후라이드치킨";
                lb_Ck_Price1.Text = "16900";

                pictureBox7.Image = Properties.Resources.맘스양념치킨;
                lb_ckName2.Text = "맘스양념치킨";
                lb_Ck_Price2.Text = "18900";

                pictureBox8.Image = Properties.Resources.반반치킨;
                lb_ckName3.Text = "반반치킨";
                lb_Ck_Price3.Text = "17900";

                pictureBox9.Image = Properties.Resources.간장마늘치킨;
                lb_ckName4.Text = "간장마늘치킨";
                lb_Ck_Price4.Text = "18900";
            }
        }
        private void Hamburger_Page() //햄버거 탭 페이지
        {
            if (Iburger_page % 2 == 1)
            {
                pictureBox1.Image = Properties.Resources.갈릭바베큐치킨버거;
                lb_bName1.Text = "갈릭바베큐치킨\n버거세트";
                lb_burger1.Text = "7900";

                pictureBox2.Image = Properties.Resources.쉬림프싸이플렉스버거;
                lb_bName2.Text = "쉬림프싸이플렉스\n버거세트";
                lb_burger2.Text = "8800";

                pictureBox3.Image = Properties.Resources.트리플딥치즈싸이버거;
                lb_bName3.Text = "트리플딥치즈\n버거세트";
                lb_burger3.Text = "7400";

                pictureBox4.Image = Properties.Resources.화이트갈릭싸이버거;
                lb_bName4.Text = "화이트갈릭싸이\n버거세트";
                lb_burger4.Text = "7200";

                pictureBox5.Image = Properties.Resources.딥치즈싸이버거;
                lb_bName5.Text = "딥치즈싸이버거\n세트";
                lb_burger5.Text = "7100";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.싸이버거;
                lb_bName1.Text = "싸이버거세트";
                lb_burger1.Text = "6600";

                pictureBox2.Image = Properties.Resources.간장마늘싸이버거;
                lb_bName2.Text = "간장마늘싸이\n버거세트";
                lb_burger2.Text = "6700";

                pictureBox3.Image = Properties.Resources.불싸이버거;
                lb_bName3.Text = "불싸이버거세트";
                lb_burger3.Text = "6700";

                pictureBox4.Image = Properties.Resources.인크레더블버거;
                lb_bName4.Text = "인크레더블\n버거세트";
                lb_burger4.Text = "7700";

                pictureBox5.Image = Properties.Resources.양념치킨싸이버거;
                lb_bName5.Text = "양념치킨싸이\n버거세트";
                lb_burger5.Text = "6700";
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e) //결제확인 버튼
        {
            int result;
            if (lb_Sum_Price.Text.Contains("원")) //한글이 포함되어 있으면 문자열을 잘라서 변환
            {
                result = int.Parse(lb_Sum_Price.Text.Substring(0, lb_Sum_Price.Text.Length - 1)); // 총가격 + 전달받은 가격
            }
            else
            {
                result = int.Parse(lb_Sum_Price.Text);
            }
            //
            if (result > 0)
            {
                Pay Payment = new Pay(result);
                Payment.PayCompleted += new Pay.PayEventHandler(Clear);
                Payment.ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 상품이 없습니다.");
            }

        }
    }
}
