using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOrn_Click(object sender, EventArgs e)
        {
            //içeriğine sizin karar verebileceğiniz bir sayısal dizi oluşturun ve bu dizinin en küçük - en büyük elemanını messagebox ile gösterin

            int[] sayilar = { 98, 96, 99, 17, 92, 94 };

            //MessageBox.Show("Dizideki en büyük sayı: " + sayilar.Max() + "\nDizideki en küçük sayı: " + sayilar.Min());

            Array.Sort(sayilar);
            MessageBox.Show($"Dizideki en büyük sayı: {sayilar[0]}\nDizideki en küçük sayı: {sayilar[sayilar.Length - 1]}");
        }

        string[] kayitlar = new string[0];
        //int adet = 1;
        //int index = 0;

        private void BtnEleman_Click(object sender, EventArgs e)
        {
            //textboxtan girilen veri "kayıtlar" adlı diziye eklensin. her yeni kayıtta dizinin boyutu bir arttırılsın. eleman eklendikten sonra ise aşağıdaki formatta kayıt listboxta gösterilsin 
            //FORMAT -- eleman - elemaninIndex
            // Dim value As Integer = CInt(Int((6 * Rnd()) + 1))

            //string veri = textBox1.Text;
            //Array.Resize(ref kayitlar, adet);
            //kayitlar[index] = veri;
            //adet++;
            //index++;
            //lbElemanlar.Items.Add($"{veri} - {index}");


            Array.Resize(ref kayitlar, kayitlar.Length + 1);
            kayitlar[kayitlar.Length - 1] = textBox1.Text;
            lbElemanlar.Items.Add($"{kayitlar[kayitlar.Length - 1]} - {kayitlar.Length - 1}");
        }
    }
}
