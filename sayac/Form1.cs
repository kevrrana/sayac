using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = "0";
        }
        int sayac;
        private void btnAzalt_Click(object sender, EventArgs e)
        {
            if (sayac > -10)
            {
                sayac--;//değeri 1 azalır
            }
            lblSayac.Text=sayac.ToString();
        }

        private void btnArtir_Click(object sender, EventArgs e)
        {
            if (sayac < 10)
            {
                sayac++;//değeri 1 artırır
            }
            lblSayac.Text = sayac.ToString();
        }
    }
}
