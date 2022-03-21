using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeriIslemleri veriIslemleri = new VeriIslemleri();
        Personel seciliPersonel = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnPersonelGetir.Click += new EventHandler(btnPersonelGetir_Click);

            btnPersonelKaydet.Click += new EventHandler(btnPersoneliKaydet_Click);

        }

        private void btnPersoneliKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliPersonel != null)
                {
                    string nereyeKaydoldu = string.Empty;
                    bool kontrol =
                    veriIslemleri.PersoneliKaydet("C:\\Birkan", out nereyeKaydoldu, seciliPersonel);
                    if (kontrol)
                    {
                        MessageBox.Show($"{seciliPersonel.ToString()} bilgisayara kayıt oldu... \n yol: {nereyeKaydoldu}");
                    }
                }
                else
                {
                    throw new Exception($"HATA: {seciliPersonel.ToString()} bilgisayara kayıt olamadı.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            listBoxPersoneller.DataSource = veriIslemleri.PersonelleriGetir();
            listBoxPersoneller.DoubleClick += new EventHandler(listBoxPersoneller_DoubleClick);
        }

        private void listBoxPersoneller_DoubleClick(object sender, EventArgs e)
        {
             seciliPersonel = (Personel)listBoxPersoneller.SelectedItem;

            txtIsim.Text = seciliPersonel.Isım;
            txtSoyisim.Text = seciliPersonel.Soyisim;
            txtEmail.Text = seciliPersonel.Email;
            txtFirma.Text = seciliPersonel.Firma;
            txtUlke.Text = seciliPersonel.Ulke;


        }
    }
}
