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
    public partial class FormTampilanData : Form
    {
        public static int urutanBaris = 0;
        public static int totalBaris = 0;

        public FormTampilanData(int urutanBaris)
        {
            InitializeComponent();
            totalBaris = urutanBaris;
        }
        public void FormTampilanData_Load(object sender, EventArgs e)
        {
            if (FormPenambahanData.kumpulanData[0, 0] == "" && FormPenambahanData.kumpulanData[0, 1] == "" && FormPenambahanData.kumpulanData[0, 2] == "")
            {
                textBoxNama2.Text = "<data kosong>";
                textBoxAlamat2.Text = "<data kosong>";
                textBoxTelp2.Text = "<data kosong>";
            }
            else
            {
                textBoxNama2.Text = FormPenambahanData.kumpulanData[urutanBaris, 0];
                textBoxAlamat2.Text = FormPenambahanData.kumpulanData[urutanBaris, 1];
                textBoxTelp2.Text = FormPenambahanData.kumpulanData[urutanBaris, 2];
            }
        }
        public void buttonPrev_Click(object sender, EventArgs e)
        {
            if (urutanBaris > 0)
            {
                urutanBaris--;
                textBoxNama2.Text = FormPenambahanData.kumpulanData[urutanBaris, 0];
                textBoxAlamat2.Text = FormPenambahanData.kumpulanData[urutanBaris, 1];
                textBoxTelp2.Text = FormPenambahanData.kumpulanData[urutanBaris, 2];
            }
            else if (urutanBaris == 0)
            {
                MessageBox.Show("Data sudah data pertama");
            }
        }

        public void buttonNext_Click(object sender, EventArgs e)
        {
            if (urutanBaris < totalBaris - 1)
            {
                urutanBaris++;
                textBoxNama2.Text = FormPenambahanData.kumpulanData[urutanBaris, 0];
                textBoxAlamat2.Text = FormPenambahanData.kumpulanData[urutanBaris, 1];
                textBoxTelp2.Text = FormPenambahanData.kumpulanData[urutanBaris, 2];
            }
            else if (urutanBaris == totalBaris - 1)
            {
                MessageBox.Show("Data sudah data terakhir");
            }
        }

        public void buttonKembali_Click(object sender, EventArgs e)
        {
            FormPenambahanData formPenambahanData = new FormPenambahanData();
            formPenambahanData.Show();
            this.Hide();
        }
    }
}
