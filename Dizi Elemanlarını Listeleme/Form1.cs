namespace Dizi_Elemanlarını_Listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] sehirler = { "Ankara", "İstanbul", "Eskişehir", "Adana", "Bursa" };
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}

            int[] sayilar = { 2, 5, 7, 10, 12, 24, 15, 0 };

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]%2==0)
            //    {
            //        listBox1.Items.Add(sayilar[i]);
            //    }
            //}

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2==0 & sayilar[i]>10)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
