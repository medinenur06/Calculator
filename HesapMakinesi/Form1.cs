using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _temizlenecekMi;
        int _birinciSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi=false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "1"; 
        }

        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "2";   
        }

        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "3";
        }

        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "4";

        }

        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "5";

        }

        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "6";
        }

        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "7";
        }

        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "8";
        }

        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "9";
        }

        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_temizlenecekMi)
            {
                label1.Text = "";
                _temizlenecekMi = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _temizlenecekMi = true;
            _birinciSayi = Convert.ToInt32(label1.Text);

        }

        private void sonuc_Click(object sender, EventArgs e)
        {
            int ikinciSayi=Convert.ToInt32(label1.Text);
            int islemSonuc=0;

            switch (_islem)
            {
                case '+':
                    islemSonuc = _birinciSayi + ikinciSayi;
                    break;
                case '-':
                    islemSonuc = _birinciSayi - ikinciSayi;
                    break;
                case '*':
                    islemSonuc = _birinciSayi * ikinciSayi;
                    break;
                case '/':
                    islemSonuc = _birinciSayi / ikinciSayi;
                    break;
            }
            label1.Text=Convert.ToString(islemSonuc);
        }

        private void cıkarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _temizlenecekMi = true;
            _birinciSayi = Convert.ToInt32(label1.Text);
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _temizlenecekMi = true;
            _birinciSayi = Convert.ToInt32(label1.Text);
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _temizlenecekMi = true;
            _birinciSayi = Convert.ToInt32(label1.Text);
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
