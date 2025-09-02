using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TopUpGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Isi combobox default
            cmbnamgame.Items.Clear();
            cmbnamgame.Items.Add("Mobile Legends");
            cmbnamgame.Items.Add("Free Fire");
            cmbnamgame.Items.Add("PUBG Mobile");
            cmbnamgame.Items.Add("Roblox");
            cmbnamgame.Items.Add("Honor Of Kings");


            cmbnom.Items.Clear();
            cmbnom.Items.Add("5 diamond = Rp 750");
            cmbnom.Items.Add("10 diamond = Rp 1.500");
            cmbnom.Items.Add("50 diamond = Rp 6.000");
            cmbnom.Items.Add("100 diamond = Rp 12.000");
            cmbnom.Items.Add("1.000 diamond = Rp 115.000");
            cmbnom.Items.Add("5.000 diamond = Rp 550.000");

            cmbmet.Items.Clear();
            cmbmet.Items.Add("DANA");
            cmbmet.Items.Add("Gopay");
            cmbmet.Items.Add("OVO");
            cmbmet.Items.Add("Shopeepay");

            // Default kosong
            cmbnamgame.SelectedIndex = -1;
            cmbnom.SelectedIndex = -1;
            cmbmet.SelectedIndex = -1;
        }

        private void btnbay_Click(object sender, EventArgs e)
        {
            // Validasi semua input
            if (string.IsNullOrWhiteSpace(cmbnamgame.Text) ||
                string.IsNullOrWhiteSpace(txtus.Text) ||
                string.IsNullOrWhiteSpace(cmbnom.Text) ||
                string.IsNullOrWhiteSpace(cmbmet.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Mohon lengkapi semua data terlebih dahulu!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi email
            if (!IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Format email tidak valid!\nContoh: nama@gmail.com",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }

            // Jika sukses
            MessageBox.Show(
                $"Pembayaran sukses!\n\n" +
                $"Game: {cmbnamgame.Text}\n" +
                $"User ID: {txtus.Text}\n" +
                $"Nominal: {cmbnom.Text}\n" +
                $"Metode: {cmbmet.Text}\n" +
                $"Email: {txtemail.Text}",
                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntalkan_Click(object sender, EventArgs e)
        {
            // Kosongkan semua input
            cmbnamgame.SelectedIndex = -1;
            txtus.Clear();
            cmbnom.SelectedIndex = -1;
            cmbmet.SelectedIndex = -1;
            txtemail.Clear();
        }

        // Fungsi validasi email
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }

        private void btnbay_Click_1(object sender, EventArgs e)
        {
          MessageBox.Show("Pembayaran Berhasil, diamond sedang diproses ke akun anda.");
        }
    }
}
