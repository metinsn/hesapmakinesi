using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {

        double deger1 = 0, deger2 = 0, Sonuc = 0;
        String islem = "";
        List<double> liste = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            EkranTxtBox.Text = EkranTxtBox.Text + buton.Text;
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            EkranTxtBox.Clear();
        }
        private void dortislem(object sender, EventArgs e)
        {
            if (EkranTxtBox.Text != "")
            {
                deger1 = Convert.ToDouble(EkranTxtBox.Text);
            }
            liste.Add(deger1);
            Button buton = (Button)sender;
            islem = buton.Text;
            listBox1.Items.Add(deger1);
            EkranTxtBox.ResetText();

            switch (islem)
            {
                case "-":
                    BtnBol.Enabled = false;
                    BtncCarp.Enabled = false;
                    BtnTopla.Enabled = false;
                    BtnYuzde.Enabled = false;
                    break;
                case "*":
                    BtnBol.Enabled = false;
                    Btncikar.Enabled = false;
                    BtnTopla.Enabled = false;
                    BtnYuzde.Enabled = false;
                    break;
                case "/":
                    Btncikar.Enabled = false;
                    BtncCarp.Enabled = false;
                    BtnTopla.Enabled = false;
                    BtnYuzde.Enabled = false;
                    break;
                case "+":
                    BtnBol.Enabled = false;
                    BtncCarp.Enabled = false;
                    Btncikar.Enabled = false;
                    BtnYuzde.Enabled = false;
                    break;
                case "%":

                    break;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void BtnYuzde_Click(object sender, EventArgs e)
        {
            if (EkranTxtBox.Text != "" || islem == "%")
            {
                Sonuc = (Convert.ToDouble(EkranTxtBox.Text) / Convert.ToDouble(100));
                EkranTxtBox.Text = Convert.ToString(Sonuc);
                liste.Clear();
                Sonuc = 0;
            }
        }

        private void BtnHafizasil_Click(object sender, EventArgs e)
        {
            EkranTxtBox.Clear();
            double deger1 = 0, deger2 = 0, Sonuc = 0;
            String islem = "";
            listBox1.Items.Clear();
            liste.Clear();
            BtnTopla.Enabled = true;
            BtncCarp.Enabled = true;
            Btncikar.Enabled = true;
            BtnBol.Enabled = true;
            BtnYuzde.Enabled = true;
        }
        private void BtnEşittir_Click(object sender, EventArgs e)
        {
            if (EkranTxtBox.Text != "")
            {
                deger2 = Convert.ToDouble(EkranTxtBox.Text);
                liste.Add(deger2); ;
                listBox1.Items.Add(deger2);
            }
            foreach (var item in liste)
            {
                switch (islem)
                {
                    case "-":
                        Sonuc -= item;
                        break;

                    case "/":
                        if (Sonuc == 0)
                        {
                            Sonuc = item;
                        }
                        else
                        {
                            Sonuc /= item;
                        }
                        break;
                    case "*":
                        if (Sonuc == 0)
                        {
                            Sonuc = 1;
                            Sonuc *= item;
                        }
                        else
                        {
                            Sonuc *= item;
                        }
                        break;
                    case "+":
                        Sonuc += item;
                        break;

                    default:
                        MessageBox.Show("işlem seçiniz !");
                        break;

                }
                               
            }

            EkranTxtBox.Text = Convert.ToString(Sonuc);
            liste.Clear();
            BtnTopla.Enabled = true;
            BtncCarp.Enabled = true;
            Btncikar.Enabled = true;
            BtnBol.Enabled = true;
            BtnYuzde.Enabled = true;
            Sonuc = 0;
            {
            }
        }

    }

}