using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_sinema_bilet_satis_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         


        private void label12_Click(object sender, EventArgs e)
        {

        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int misir, su, cay, bilet, toplam, msrfyt, sufyt, cayfyt, bltfyt;
            msrfyt = 4;
            cayfyt = 2;
            sufyt = 1;
            bltfyt = 8;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            bilet = Convert.ToInt16(TxtBlt.Text);
            toplam = (msrfyt * misir) + (cay * cayfyt) + (su * sufyt) + (bilet * bltfyt);
            LblToplam.Text = toplam.ToString() + " TL";
            kasa = kasa + toplam;
            LblKasa.Text = kasa.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtCay.Text = "";
            TxtSu.Text = "";
            TxtBlt.Text = "";
            TxtMisir.Focus();
        }
    }
}
