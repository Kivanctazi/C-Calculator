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
        public Form1()
        {
            InitializeComponent();
        }

        // https://www.youtube.com/watch?v=R5tKFrXf_D0 15.11.2023 Hesap makinesi
        // Tasarım için guna ui kullandım

        private int islem;
        private bool ekrantemizle;
        private double ilksayi;
        private double sonsayi;

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = "0"; 
            ekrantemizle = false;
            ilksayi = 0;
            sonsayi = 0;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = "0";
            ekrantemizle = false;
            ilksayi = 0;
            sonsayi = 0;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(guna2HtmlLabel1.Text);
            ekrantemizle = true;
            islem = 2;

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(guna2HtmlLabel1.Text);
            ekrantemizle = true;
            islem = 1;

        }

        private void butonhesapla_Click(object sender, EventArgs e)
        {
            sonsayi = Convert.ToDouble(guna2HtmlLabel1.Text);
            
            switch (islem) // kodu uzatmak istemedim, isteğe bağlı olarak sonuçta kullanılabilir.
            {
                case 1:
                    guna2HtmlLabel1.Text = Convert.ToString(ilksayi + sonsayi);
                break;
                case 2:
                    guna2HtmlLabel1.Text = Convert.ToString(ilksayi * sonsayi);
                break;
                case 3:
                    guna2HtmlLabel1.Text = Convert.ToString(ilksayi - sonsayi);
                break;
                case 4:
                    guna2HtmlLabel1.Text = Convert.ToString(ilksayi / sonsayi);
                break;
                case 5:
                    guna2HtmlLabel1.Text = Convert.ToString(ilksayi % sonsayi);
                break;
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (ekrantemizle)  guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buton1_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "1";
        }

        private void buton2_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "2";
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "3";
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "4";
        }

        private void buton5_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "5";
        }

        private void buton6_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "6";
        }

        private void buton7_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "7";
        }

        private void buton8_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "8";
        }

        private void buton9_Click(object sender, EventArgs e)
        {
            if (ekrantemizle) guna2HtmlLabel1.Text = ""; ekrantemizle = false;
            if (guna2HtmlLabel1.Text == "0") guna2HtmlLabel1.Text = "";
            guna2HtmlLabel1.Text += "9";
        }

        private void butoncikar_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(guna2HtmlLabel1.Text);
            ekrantemizle = true;
            islem = 3;

        }

        private void butonbol_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(guna2HtmlLabel1.Text);
            ekrantemizle = true;
            islem = 4;

        }

        private void butonyuzde_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(guna2HtmlLabel1.Text);
            ekrantemizle = true;
            islem = 5;

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
