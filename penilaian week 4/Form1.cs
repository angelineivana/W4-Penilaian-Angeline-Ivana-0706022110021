using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace penilaian_week_4
{
    public partial class FormPenambahanData : Form
    {
        public static string[,] kumpulanData = new string[11,3];
        public FormPenambahanData()
        {
            InitializeComponent();
        }
        public void textBoxTelp_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxTelp.Text, "[^0-9]"))
            {
                MessageBox.Show("Masukkan Nomor Berupa Angka!");
                textBoxTelp.Text = textBoxTelp.Text.Remove(textBoxTelp.Text.Length - 1);
            }
        }
        public int urutanBaris = 0;
        public void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (urutanBaris < 10)
            {
                kumpulanData[urutanBaris, 0] = textBoxNama.Text;
                kumpulanData[urutanBaris, 1] = textBoxAlamat.Text;
                kumpulanData[urutanBaris, 2] = textBoxTelp.Text;
                urutanBaris++;

                textBoxNama.Text = "";
                textBoxAlamat.Text = "";
                textBoxTelp.Text = "";
            }
            else
            {
                MessageBox.Show("Data telah penuh!");
            }
        }
        public void buttonLihatData_Click(object sender, EventArgs e)
        {
            FormTampilanData formTampilanData = new FormTampilanData(urutanBaris);
            formTampilanData.Show();
            this.Hide();
        }
    }
}
