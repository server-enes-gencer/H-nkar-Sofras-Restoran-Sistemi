namespace Hunkar_Sofrasi
{
    partial class GirisForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.PersonelCB = new System.Windows.Forms.ComboBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.LblKullanici = new System.Windows.Forms.Label();
            this.LblSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonelCB
            // 
            this.PersonelCB.BackColor = System.Drawing.Color.White;
            this.PersonelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonelCB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PersonelCB.FormattingEnabled = true;
            this.PersonelCB.Location = new System.Drawing.Point(556, 72);
            this.PersonelCB.Name = "PersonelCB";
            this.PersonelCB.Size = new System.Drawing.Size(202, 27);
            this.PersonelCB.TabIndex = 0;
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.White;
            this.TxtSifre.Location = new System.Drawing.Point(556, 125);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(202, 26);
            this.TxtSifre.TabIndex = 1;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.Black;
            this.GirisBtn.BackgroundImage = global::Hunkar_Sofrasi.Properties.Resources.doors_5238885;
            this.GirisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisBtn.Location = new System.Drawing.Point(556, 173);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(90, 63);
            this.GirisBtn.TabIndex = 2;
            this.GirisBtn.UseVisualStyleBackColor = false;
            // 
            // CikisBtn
            // 
            this.CikisBtn.BackColor = System.Drawing.Color.Transparent;
            this.CikisBtn.BackgroundImage = global::Hunkar_Sofrasi.Properties.Resources.power_on_3694386;
            this.CikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CikisBtn.Location = new System.Drawing.Point(668, 174);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(90, 62);
            this.CikisBtn.TabIndex = 3;
            this.CikisBtn.UseVisualStyleBackColor = false;
            // 
            // LblKullanici
            // 
            this.LblKullanici.AutoSize = true;
            this.LblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.LblKullanici.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKullanici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblKullanici.Location = new System.Drawing.Point(391, 72);
            this.LblKullanici.Name = "LblKullanici";
            this.LblKullanici.Size = new System.Drawing.Size(150, 26);
            this.LblKullanici.TabIndex = 4;
            this.LblKullanici.Text = "Kullanıcı Adı";
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.BackColor = System.Drawing.Color.Transparent;
            this.LblSifre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.ForeColor = System.Drawing.SystemColors.Control;
            this.LblSifre.Location = new System.Drawing.Point(467, 125);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(65, 26);
            this.LblSifre.TabIndex = 5;
            this.LblSifre.Text = "Şifre";
            // 
            // GirisForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblKullanici);
            this.Controls.Add(this.CikisBtn);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.PersonelCB);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sisteme Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PersonelCB;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Button CikisBtn;
        private System.Windows.Forms.Label LblKullanici;
        private System.Windows.Forms.Label LblSifre;
    }
}

