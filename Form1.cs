namespace Baithicau1_NguyenMinhKhang_02PM16B1D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<ElectricCar> danhsach1 = new List<ElectricCar>();
        private void button1_Click(object sender, EventArgs e)
        {
            double giaban;

            if (double.TryParse(txt_giaban.Text, out giaban))
            {
                ElectricCar electricCar = new ElectricCar(txt_hangxe.Text, txt_bienso.Text, txt_namsanxuat.Text, giaban, txt_BTC.Text);

                danhsach1.Add(electricCar);
                dt1.DataSource = null;
                dt1.DataSource = danhsach1;
            }
            else
            {
                MessageBox.Show("Điền Thông Tin Đầy Đủ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ElectricCar i in danhsach1)
            {
                if (i.Hangxe == txt_hangxe.Text)
                {
                    danhsach1.Remove(i);
                    break;
                }

            }
            dt1.DataSource = null;
            dt1.DataSource = danhsach1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ElectricCar i in danhsach1)
            {
                if (i.Hangxe == txt_hangxe.Text)
                {
                    i.Bienso = txt_bienso.Text;
                    i.Namsanxuat = txt_namsanxuat.Text;
                    i.BatteryCapacity1 = txt_BTC.Text;


                    i.Giaban = double.Parse(txt_giaban.Text);

                }
            }
            dt1.DataSource = null;
            dt1.DataSource = danhsach1;
        }
    }
}
