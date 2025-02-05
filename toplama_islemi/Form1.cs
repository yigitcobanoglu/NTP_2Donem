namespace toplama_islemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            int sonuc;

            sayi1 = Convert.ToInt32(txt1.Text);
            sayi2 = Convert.ToInt32(txt2.Text);

            sonuc = sayi1 + sayi2;
            txtsonuc.Text = sonuc.ToString();

        }
    }
}
