using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Akhir_Semester_M_David_X_PPLG2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbjenis.Text == "Tiket Reguler")
            {
                tbxharga.Text = "90000"; // Rp90.000
            }
            else if (cmbjenis.Text == "Tiket Vip")
            {
                tbxharga.Text = "150000"; // Rp150.000
            }
            else if (cmbjenis.Text == "Tiket Mitos")
            {
                tbxharga.Text = "250000"; // Rp250.000
            }
        }

        private void tbxjumlah_TextChanged(object sender, EventArgs e)
        {
            // Jika user mengisi menggunaka huruf maka program akan memperingatkan
            if (tbxharga.Text != "" && tbxjumlah.Text != "")
            {
                if (int.TryParse(tbxjumlah.Text, out int jumlahh))
                {

                    int harga = int.Parse(tbxharga.Text);

                    int total = harga * jumlahh;

                    tbxtotal.Text = $"{total}";
                }

                else
                {
                    MessageBox.Show("Di isi pakai angka ya");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Jika user sudah bertransaksi maaka akan muncul peringatan
            double total = double.Parse(tbxtotal.Text);
            double bayar = double.Parse(tbxbayar.Text);

            if (bayar < total)
            {
                MessageBox.Show("Uang anda kurang");
                return;
            }

            else
            {
                MessageBox.Show("Transaksi Berhasil");
            }

            double kembalian = bayar - total;
            tbxkembalian.Text = kembalian.ToString();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbjenis.Items.Add("Tiket Reguler");
            cmbjenis.Items.Add("Tiket Vip");
            cmbjenis.Items.Add("Tiket Mitos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxbayar.Clear();
            tbxharga.Clear();
            tbxjumlah.Clear();
            tbxtotal.Clear();
            tbxkembalian.Clear();
            cmbjenis.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda ingin menutup program?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Tutup semua fom dan hentikan aplikasi
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxkembalian_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
