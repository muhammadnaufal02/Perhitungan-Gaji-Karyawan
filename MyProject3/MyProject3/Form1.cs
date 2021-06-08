using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject3
{
    public partial class Form1 : Form
    {
        double[,] ArrayGajiPokok =
        {
            {1000000,1250000,1500000,1750000},
            {2000000,2250000,2500000,2750000},
            {3000000,3250000,3500000,3750000}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void hitung_Click(object sender, EventArgs e)
        {
            double GajiPokok, TunjanganIstri = 0, TunjanganAnak, TotalGaji = 0;
            GajiPokok = ArrayGajiPokok[cbDepartemen.SelectedIndex, cbGolongan.SelectedIndex];

            if (rbpria.Checked && rbMenikah.Checked)
                TunjanganIstri = (GajiPokok * 10) / 100;
            TunjanganAnak = (nmJmAnak.Value <= 2) ? ((double)nmJmAnak.Value * GajiPokok * 5) / 100 : (2 * GajiPokok * 5 / 100);


            TotalGaji = GajiPokok + TunjanganIstri + TunjanganAnak;

            txGjPokok.Text = GajiPokok.ToString();
            txTnjIstri.Text = TunjanganIstri.ToString();
            txTnjAnak.Text = TunjanganAnak.ToString();
            txTotalGaji.Text = TotalGaji.ToString();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txNama.Clear();
            txGjPokok.Clear();
            txTotalGaji.Clear();
            txTnjIstri.Clear();
            cbDepartemen.SelectedIndex = cbGolongan.SelectedIndex = -1;
            rbpria.Checked = rbWanita.Checked = rbMenikah.Checked = rbBelumMenikah.Checked = false;
            nmJmAnak.Value = 0;
        }
    }
}
