namespace flagGuesser
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEurope = new System.Windows.Forms.Button();
            this.btnWorld = new System.Windows.Forms.Button();
            this.btnAsia = new System.Windows.Forms.Button();
            this.btnOceania = new System.Windows.Forms.Button();
            this.btnAmerica = new System.Windows.Forms.Button();
            this.btnAfrica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flag Guesser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(494, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Continent";
            // 
            // btnEurope
            // 
            this.btnEurope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEurope.ForeColor = System.Drawing.Color.White;
            this.btnEurope.Location = new System.Drawing.Point(55, 345);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(250, 69);
            this.btnEurope.TabIndex = 2;
            this.btnEurope.Text = "Europe";
            this.btnEurope.UseVisualStyleBackColor = false;
            this.btnEurope.Click += new System.EventHandler(this.btnEurope_Click);
            // 
            // btnWorld
            // 
            this.btnWorld.BackColor = System.Drawing.Color.White;
            this.btnWorld.ForeColor = System.Drawing.Color.Black;
            this.btnWorld.Location = new System.Drawing.Point(55, 232);
            this.btnWorld.Name = "btnWorld";
            this.btnWorld.Size = new System.Drawing.Size(250, 69);
            this.btnWorld.TabIndex = 2;
            this.btnWorld.Text = "World";
            this.btnWorld.UseVisualStyleBackColor = false;
            this.btnWorld.Click += new System.EventHandler(this.btnWorld_Click);
            // 
            // btnAsia
            // 
            this.btnAsia.BackColor = System.Drawing.Color.Yellow;
            this.btnAsia.ForeColor = System.Drawing.Color.Black;
            this.btnAsia.Location = new System.Drawing.Point(55, 458);
            this.btnAsia.Name = "btnAsia";
            this.btnAsia.Size = new System.Drawing.Size(250, 69);
            this.btnAsia.TabIndex = 2;
            this.btnAsia.Text = "Asia";
            this.btnAsia.UseVisualStyleBackColor = false;
            this.btnAsia.Click += new System.EventHandler(this.btnAsia_Click);
            // 
            // btnOceania
            // 
            this.btnOceania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOceania.ForeColor = System.Drawing.Color.Black;
            this.btnOceania.Location = new System.Drawing.Point(902, 458);
            this.btnOceania.Name = "btnOceania";
            this.btnOceania.Size = new System.Drawing.Size(250, 69);
            this.btnOceania.TabIndex = 2;
            this.btnOceania.Text = "Oceania";
            this.btnOceania.UseVisualStyleBackColor = false;
            this.btnOceania.Click += new System.EventHandler(this.btnOceania_Click);
            // 
            // btnAmerica
            // 
            this.btnAmerica.BackColor = System.Drawing.Color.Red;
            this.btnAmerica.ForeColor = System.Drawing.Color.Black;
            this.btnAmerica.Location = new System.Drawing.Point(902, 232);
            this.btnAmerica.Name = "btnAmerica";
            this.btnAmerica.Size = new System.Drawing.Size(250, 69);
            this.btnAmerica.TabIndex = 2;
            this.btnAmerica.Text = "America";
            this.btnAmerica.UseVisualStyleBackColor = false;
            this.btnAmerica.Click += new System.EventHandler(this.btnAmerica_Click);
            // 
            // btnAfrica
            // 
            this.btnAfrica.BackColor = System.Drawing.Color.Black;
            this.btnAfrica.ForeColor = System.Drawing.Color.White;
            this.btnAfrica.Location = new System.Drawing.Point(902, 345);
            this.btnAfrica.Name = "btnAfrica";
            this.btnAfrica.Size = new System.Drawing.Size(250, 69);
            this.btnAfrica.TabIndex = 2;
            this.btnAfrica.Text = "Africa";
            this.btnAfrica.UseVisualStyleBackColor = false;
            this.btnAfrica.Click += new System.EventHandler(this.btnAfrica_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 732);
            this.Controls.Add(this.btnAfrica);
            this.Controls.Add(this.btnAsia);
            this.Controls.Add(this.btnAmerica);
            this.Controls.Add(this.btnWorld);
            this.Controls.Add(this.btnOceania);
            this.Controls.Add(this.btnEurope);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnWorld;
        private System.Windows.Forms.Button btnAsia;
        private System.Windows.Forms.Button btnOceania;
        private System.Windows.Forms.Button btnAmerica;
        private System.Windows.Forms.Button btnAfrica;
    }
}

