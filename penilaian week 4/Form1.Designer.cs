
namespace penilaian_week_4
{
    partial class FormPenambahanData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNama = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTelp = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(47, 45);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(63, 25);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama:";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(47, 114);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(72, 25);
            this.labelAlamat.TabIndex = 1;
            this.labelAlamat.Text = "Alamat:";
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(47, 182);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(47, 25);
            this.labelTelp.TabIndex = 2;
            this.labelTelp.Text = "Telp:";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(132, 42);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(348, 31);
            this.textBoxNama.TabIndex = 3;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(132, 111);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(504, 31);
            this.textBoxAlamat.TabIndex = 4;
            // 
            // textBoxTelp
            // 
            this.textBoxTelp.Location = new System.Drawing.Point(132, 179);
            this.textBoxTelp.Name = "textBoxTelp";
            this.textBoxTelp.Size = new System.Drawing.Size(228, 31);
            this.textBoxTelp.TabIndex = 5;
            this.textBoxTelp.TextChanged += new System.EventHandler(this.textBoxTelp_TextChanged);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(47, 257);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(112, 34);
            this.buttonSimpan.TabIndex = 6;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonLihatData
            // 
            this.buttonLihatData.Location = new System.Drawing.Point(225, 257);
            this.buttonLihatData.Name = "buttonLihatData";
            this.buttonLihatData.Size = new System.Drawing.Size(112, 34);
            this.buttonLihatData.TabIndex = 7;
            this.buttonLihatData.Text = "Lihat Data";
            this.buttonLihatData.UseVisualStyleBackColor = true;
            this.buttonLihatData.Click += new System.EventHandler(this.buttonLihatData_Click);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 329);
            this.Controls.Add(this.buttonLihatData);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxTelp);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "FormPenambahanData";
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxTelp;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonLihatData;
    }
}

