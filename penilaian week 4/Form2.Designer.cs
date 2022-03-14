
namespace penilaian_week_4
{
    partial class FormTampilanData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTelp2 = new System.Windows.Forms.TextBox();
            this.textBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.textBoxNama2 = new System.Windows.Forms.TextBox();
            this.labelTelp = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTelp2
            // 
            this.textBoxTelp2.Location = new System.Drawing.Point(130, 180);
            this.textBoxTelp2.Name = "textBoxTelp2";
            this.textBoxTelp2.ReadOnly = true;
            this.textBoxTelp2.Size = new System.Drawing.Size(228, 31);
            this.textBoxTelp2.TabIndex = 11;
            // 
            // textBoxAlamat2
            // 
            this.textBoxAlamat2.Location = new System.Drawing.Point(130, 112);
            this.textBoxAlamat2.Name = "textBoxAlamat2";
            this.textBoxAlamat2.ReadOnly = true;
            this.textBoxAlamat2.Size = new System.Drawing.Size(504, 31);
            this.textBoxAlamat2.TabIndex = 10;
            // 
            // textBoxNama2
            // 
            this.textBoxNama2.Location = new System.Drawing.Point(130, 43);
            this.textBoxNama2.Name = "textBoxNama2";
            this.textBoxNama2.ReadOnly = true;
            this.textBoxNama2.Size = new System.Drawing.Size(348, 31);
            this.textBoxNama2.TabIndex = 9;
            // 
            // labelTelp
            // 
            this.labelTelp.AutoSize = true;
            this.labelTelp.Location = new System.Drawing.Point(45, 183);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(47, 25);
            this.labelTelp.TabIndex = 8;
            this.labelTelp.Text = "Telp:";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(45, 115);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(72, 25);
            this.labelAlamat.TabIndex = 7;
            this.labelAlamat.Text = "Alamat:";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(45, 46);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(63, 25);
            this.labelNama.TabIndex = 6;
            this.labelNama.Text = "Nama:";
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(45, 247);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(112, 34);
            this.buttonKembali.TabIndex = 12;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(219, 247);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(112, 34);
            this.buttonPrev.TabIndex = 13;
            this.buttonPrev.Text = "Prev Data";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(395, 247);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 34);
            this.buttonNext.TabIndex = 14;
            this.buttonNext.Text = "Next Data";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 331);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.textBoxTelp2);
            this.Controls.Add(this.textBoxAlamat2);
            this.Controls.Add(this.textBoxNama2);
            this.Controls.Add(this.labelTelp);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNama);
            this.Name = "FormTampilanData";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTelp2;
        private System.Windows.Forms.TextBox textBoxAlamat2;
        private System.Windows.Forms.TextBox textBoxNama2;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
    }
}