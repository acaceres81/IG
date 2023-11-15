namespace cookpad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cookpadDll1 = new CookpadDll.UserControl1();
            this.cbUrteak = new System.Windows.Forms.ComboBox();
            this.lbEmanBotoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNan = new System.Windows.Forms.TextBox();
            this.tbEmaila = new System.Windows.Forms.TextBox();
            this.tbEzizena = new System.Windows.Forms.TextBox();
            this.TbErrezeta = new System.Windows.Forms.TextBox();
            this.tbIzena = new System.Windows.Forms.TextBox();
            this.btnBozkatu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookpadDll1
            // 
            this.cookpadDll1.Location = new System.Drawing.Point(12, 90);
            this.cookpadDll1.Name = "cookpadDll1";
            this.cookpadDll1.Size = new System.Drawing.Size(443, 309);
            this.cookpadDll1.TabIndex = 0;
            this.cookpadDll1.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // cbUrteak
            // 
            this.cbUrteak.FormattingEnabled = true;
            this.cbUrteak.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cbUrteak.Location = new System.Drawing.Point(98, 23);
            this.cbUrteak.Name = "cbUrteak";
            this.cbUrteak.Size = new System.Drawing.Size(613, 24);
            this.cbUrteak.TabIndex = 1;
            this.cbUrteak.Text = "2022";
            this.cbUrteak.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbEmanBotoa
            // 
            this.lbEmanBotoa.AutoSize = true;
            this.lbEmanBotoa.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmanBotoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbEmanBotoa.Location = new System.Drawing.Point(487, 119);
            this.lbEmanBotoa.Name = "lbEmanBotoa";
            this.lbEmanBotoa.Size = new System.Drawing.Size(199, 26);
            this.lbEmanBotoa.TabIndex = 2;
            this.lbEmanBotoa.Text = "Eman zure botoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(475, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAN: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(475, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izena: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(475, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emaila: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(475, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ezizena: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(475, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Errezeta Id:";
            // 
            // tbNan
            // 
            this.tbNan.Location = new System.Drawing.Point(639, 168);
            this.tbNan.Name = "tbNan";
            this.tbNan.Size = new System.Drawing.Size(181, 22);
            this.tbNan.TabIndex = 8;
            // 
            // tbEmaila
            // 
            this.tbEmaila.Location = new System.Drawing.Point(639, 274);
            this.tbEmaila.Name = "tbEmaila";
            this.tbEmaila.Size = new System.Drawing.Size(181, 22);
            this.tbEmaila.TabIndex = 9;
            // 
            // tbEzizena
            // 
            this.tbEzizena.Location = new System.Drawing.Point(639, 320);
            this.tbEzizena.Name = "tbEzizena";
            this.tbEzizena.Size = new System.Drawing.Size(181, 22);
            this.tbEzizena.TabIndex = 10;
            // 
            // TbErrezeta
            // 
            this.TbErrezeta.Location = new System.Drawing.Point(639, 377);
            this.TbErrezeta.Name = "TbErrezeta";
            this.TbErrezeta.Size = new System.Drawing.Size(181, 22);
            this.TbErrezeta.TabIndex = 11;
            // 
            // tbIzena
            // 
            this.tbIzena.Location = new System.Drawing.Point(639, 217);
            this.tbIzena.Name = "tbIzena";
            this.tbIzena.Size = new System.Drawing.Size(181, 22);
            this.tbIzena.TabIndex = 12;
            // 
            // btnBozkatu
            // 
            this.btnBozkatu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBozkatu.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBozkatu.ForeColor = System.Drawing.Color.White;
            this.btnBozkatu.Location = new System.Drawing.Point(551, 430);
            this.btnBozkatu.Name = "btnBozkatu";
            this.btnBozkatu.Size = new System.Drawing.Size(210, 41);
            this.btnBozkatu.TabIndex = 13;
            this.btnBozkatu.Text = "Botoa bidali";
            this.btnBozkatu.UseVisualStyleBackColor = false;
            this.btnBozkatu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 483);
            this.Controls.Add(this.btnBozkatu);
            this.Controls.Add(this.tbIzena);
            this.Controls.Add(this.TbErrezeta);
            this.Controls.Add(this.tbEzizena);
            this.Controls.Add(this.tbEmaila);
            this.Controls.Add(this.tbNan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmanBotoa);
            this.Controls.Add(this.cbUrteak);
            this.Controls.Add(this.cookpadDll1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookpadDll.UserControl1 cookpadDll1;
        private System.Windows.Forms.ComboBox cbUrteak;
        private System.Windows.Forms.Label lbEmanBotoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNan;
        private System.Windows.Forms.TextBox tbEmaila;
        private System.Windows.Forms.TextBox tbEzizena;
        private System.Windows.Forms.TextBox TbErrezeta;
        private System.Windows.Forms.TextBox tbIzena;
        private System.Windows.Forms.Button btnBozkatu;
    }
}

