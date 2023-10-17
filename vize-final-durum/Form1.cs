using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_final_durum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float vize, final, ortalama, durum;
            vize = Convert.ToSingle(txtVize.Text);
            final = Convert.ToSingle(txtFinal.Text);
            ortalama = (vize * 40 / 100) + (final * 60 / 100);

            if (ortalama >=50 && final>=50)
                
            {
                lblDurum.Text = "Durum : Geçti";
                lblDurum.ForeColor = Color.Green;
            }
            else
            {
                lblDurum.Text = "Durum :  Kaldı";
                lblDurum.ForeColor= Color.Red;
            }
            lblOrtalama.Text = "Ortalama :" + ortalama.ToString();
        }
    }
}
