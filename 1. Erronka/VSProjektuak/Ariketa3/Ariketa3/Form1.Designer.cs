namespace Ariketa3
{
    partial class Form1
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
            btnGorde = new Button();
            btnIrten = new Button();
            lblNAN = new Label();
            lblIzena = new Label();
            lblAbizena = new Label();
            lblEmaila = new Label();
            tbNAN = new TextBox();
            tbEmaila = new TextBox();
            tbAbizena = new TextBox();
            tbIzena = new TextBox();
            gbMota = new GroupBox();
            rbLangilea = new RadioButton();
            rbBezeroa = new RadioButton();
            rbKotaktua = new RadioButton();
            gbBezeroa = new GroupBox();
            lblKategoria = new Label();
            comboBox1 = new ComboBox();
            gbLangilea = new GroupBox();
            tbSS = new TextBox();
            lblSS = new Label();
            tbSoldata = new TextBox();
            lblSoldata = new Label();
            gbMota.SuspendLayout();
            gbBezeroa.SuspendLayout();
            gbLangilea.SuspendLayout();
            SuspendLayout();
            // 
            // btnGorde
            // 
            btnGorde.Location = new Point(181, 352);
            btnGorde.Margin = new Padding(3, 2, 3, 2);
            btnGorde.Name = "btnGorde";
            btnGorde.Size = new Size(82, 22);
            btnGorde.TabIndex = 0;
            btnGorde.Text = "Gorde";
            btnGorde.UseVisualStyleBackColor = true;
            btnGorde.Click += btnGorde_Click;
            // 
            // btnIrten
            // 
            btnIrten.Location = new Point(409, 352);
            btnIrten.Margin = new Padding(3, 2, 3, 2);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(82, 22);
            btnIrten.TabIndex = 1;
            btnIrten.Text = "btnIrten";
            btnIrten.UseVisualStyleBackColor = true;
            btnIrten.Click += btnIrten_Click;
            // 
            // lblNAN
            // 
            lblNAN.AutoSize = true;
            lblNAN.Location = new Point(68, 57);
            lblNAN.Name = "lblNAN";
            lblNAN.Size = new Size(33, 15);
            lblNAN.TabIndex = 2;
            lblNAN.Text = "NAN";
            lblNAN.Click += lblNAN_Click;
            // 
            // lblIzena
            // 
            lblIzena.AutoSize = true;
            lblIzena.Location = new Point(68, 85);
            lblIzena.Name = "lblIzena";
            lblIzena.Size = new Size(34, 15);
            lblIzena.TabIndex = 3;
            lblIzena.Text = "Izena";
            lblIzena.Click += lblIzena_Click;
            // 
            // lblAbizena
            // 
            lblAbizena.AutoSize = true;
            lblAbizena.Location = new Point(68, 110);
            lblAbizena.Name = "lblAbizena";
            lblAbizena.Size = new Size(49, 15);
            lblAbizena.TabIndex = 4;
            lblAbizena.Text = "Abizena";
            lblAbizena.Click += lblAbizena_Click;
            // 
            // lblEmaila
            // 
            lblEmaila.AutoSize = true;
            lblEmaila.Location = new Point(68, 137);
            lblEmaila.Name = "lblEmaila";
            lblEmaila.Size = new Size(42, 15);
            lblEmaila.TabIndex = 5;
            lblEmaila.Text = "Emaila";
            lblEmaila.Click += lblEmaila_Click;
            // 
            // tbNAN
            // 
            tbNAN.Location = new Point(154, 56);
            tbNAN.Margin = new Padding(3, 2, 3, 2);
            tbNAN.Name = "tbNAN";
            tbNAN.Size = new Size(110, 23);
            tbNAN.TabIndex = 6;
            tbNAN.TextChanged += tbNAN_TextChanged;
            // 
            // tbEmaila
            // 
            tbEmaila.Location = new Point(154, 137);
            tbEmaila.Margin = new Padding(3, 2, 3, 2);
            tbEmaila.Name = "tbEmaila";
            tbEmaila.Size = new Size(232, 23);
            tbEmaila.TabIndex = 7;
            tbEmaila.TextChanged += tbEmaila_TextChanged;
            // 
            // tbAbizena
            // 
            tbAbizena.Location = new Point(154, 110);
            tbAbizena.Margin = new Padding(3, 2, 3, 2);
            tbAbizena.Name = "tbAbizena";
            tbAbizena.Size = new Size(232, 23);
            tbAbizena.TabIndex = 8;
            tbAbizena.TextChanged += tbAbizena_TextChanged;
            // 
            // tbIzena
            // 
            tbIzena.Location = new Point(154, 85);
            tbIzena.Margin = new Padding(3, 2, 3, 2);
            tbIzena.Name = "tbIzena";
            tbIzena.Size = new Size(232, 23);
            tbIzena.TabIndex = 9;
            tbIzena.TextChanged += tbIzena_TextChanged;
            // 
            // gbMota
            // 
            gbMota.Controls.Add(rbLangilea);
            gbMota.Controls.Add(rbBezeroa);
            gbMota.Controls.Add(rbKotaktua);
            gbMota.Location = new Point(409, 56);
            gbMota.Margin = new Padding(3, 2, 3, 2);
            gbMota.Name = "gbMota";
            gbMota.Padding = new Padding(3, 2, 3, 2);
            gbMota.Size = new Size(256, 142);
            gbMota.TabIndex = 10;
            gbMota.TabStop = false;
            gbMota.Text = "Mota";
            gbMota.Enter += gbMota_Enter;
            // 
            // rbLangilea
            // 
            rbLangilea.AutoSize = true;
            rbLangilea.Location = new Point(53, 96);
            rbLangilea.Margin = new Padding(3, 2, 3, 2);
            rbLangilea.Name = "rbLangilea";
            rbLangilea.Size = new Size(69, 19);
            rbLangilea.TabIndex = 2;
            rbLangilea.TabStop = true;
            rbLangilea.Text = "Langilea";
            rbLangilea.UseVisualStyleBackColor = true;
            rbLangilea.CheckedChanged += rbLangilea_CheckedChanged;
            // 
            // rbBezeroa
            // 
            rbBezeroa.AutoSize = true;
            rbBezeroa.Location = new Point(53, 65);
            rbBezeroa.Margin = new Padding(3, 2, 3, 2);
            rbBezeroa.Name = "rbBezeroa";
            rbBezeroa.Size = new Size(66, 19);
            rbBezeroa.TabIndex = 1;
            rbBezeroa.TabStop = true;
            rbBezeroa.Text = "Bezeroa";
            rbBezeroa.UseVisualStyleBackColor = true;
            rbBezeroa.CheckedChanged += rbBezeroa_CheckedChanged;
            // 
            // rbKotaktua
            // 
            rbKotaktua.AutoSize = true;
            rbKotaktua.Location = new Point(53, 34);
            rbKotaktua.Margin = new Padding(3, 2, 3, 2);
            rbKotaktua.Name = "rbKotaktua";
            rbKotaktua.Size = new Size(79, 19);
            rbKotaktua.TabIndex = 0;
            rbKotaktua.TabStop = true;
            rbKotaktua.Text = "Kontaktua";
            rbKotaktua.UseVisualStyleBackColor = true;
            rbKotaktua.CheckedChanged += rbKotaktua_CheckedChanged;
            // 
            // gbBezeroa
            // 
            gbBezeroa.Controls.Add(lblKategoria);
            gbBezeroa.Controls.Add(comboBox1);
            gbBezeroa.Location = new Point(91, 216);
            gbBezeroa.Margin = new Padding(3, 2, 3, 2);
            gbBezeroa.Name = "gbBezeroa";
            gbBezeroa.Padding = new Padding(3, 2, 3, 2);
            gbBezeroa.Size = new Size(219, 94);
            gbBezeroa.TabIndex = 11;
            gbBezeroa.TabStop = false;
            gbBezeroa.Text = "Bezeroa";
            // 
            // lblKategoria
            // 
            lblKategoria.AutoSize = true;
            lblKategoria.Location = new Point(16, 25);
            lblKategoria.Name = "lblKategoria";
            lblKategoria.Size = new Size(57, 15);
            lblKategoria.TabIndex = 1;
            lblKategoria.Text = "Kategoria";
            lblKategoria.Click += lblKategoria_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mayorista", "Minorista" });
            comboBox1.Location = new Point(16, 45);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // gbLangilea
            // 
            gbLangilea.Controls.Add(tbSS);
            gbLangilea.Controls.Add(lblSS);
            gbLangilea.Controls.Add(tbSoldata);
            gbLangilea.Controls.Add(lblSoldata);
            gbLangilea.Location = new Point(324, 216);
            gbLangilea.Margin = new Padding(3, 2, 3, 2);
            gbLangilea.Name = "gbLangilea";
            gbLangilea.Padding = new Padding(3, 2, 3, 2);
            gbLangilea.Size = new Size(341, 94);
            gbLangilea.TabIndex = 12;
            gbLangilea.TabStop = false;
            gbLangilea.Text = "Langilea";
            // 
            // tbSS
            // 
            tbSS.Location = new Point(5, 62);
            tbSS.Margin = new Padding(3, 2, 3, 2);
            tbSS.Name = "tbSS";
            tbSS.Size = new Size(331, 23);
            tbSS.TabIndex = 14;
            tbSS.TextChanged += textBox1_TextChanged;
            // 
            // lblSS
            // 
            lblSS.AutoSize = true;
            lblSS.Location = new Point(3, 45);
            lblSS.Name = "lblSS";
            lblSS.Size = new Size(97, 15);
            lblSS.TabIndex = 13;
            lblSS.Text = "Segurtasu soziala";
            // 
            // tbSoldata
            // 
            tbSoldata.Location = new Point(88, 20);
            tbSoldata.Margin = new Padding(3, 2, 3, 2);
            tbSoldata.Name = "tbSoldata";
            tbSoldata.Size = new Size(248, 23);
            tbSoldata.TabIndex = 16;
            tbSoldata.TextChanged += textBox2_TextChanged;
            // 
            // lblSoldata
            // 
            lblSoldata.AutoSize = true;
            lblSoldata.Location = new Point(3, 20);
            lblSoldata.Name = "lblSoldata";
            lblSoldata.Size = new Size(46, 15);
            lblSoldata.TabIndex = 15;
            lblSoldata.Text = "Soldata";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(gbLangilea);
            Controls.Add(gbBezeroa);
            Controls.Add(gbMota);
            Controls.Add(tbIzena);
            Controls.Add(tbAbizena);
            Controls.Add(tbEmaila);
            Controls.Add(tbNAN);
            Controls.Add(lblEmaila);
            Controls.Add(lblAbizena);
            Controls.Add(lblIzena);
            Controls.Add(lblNAN);
            Controls.Add(btnIrten);
            Controls.Add(btnGorde);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            gbMota.ResumeLayout(false);
            gbMota.PerformLayout();
            gbBezeroa.ResumeLayout(false);
            gbBezeroa.PerformLayout();
            gbLangilea.ResumeLayout(false);
            gbLangilea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGorde;
        private Button btnIrten;
        private Label lblNAN;
        private Label lblIzena;
        private Label lblAbizena;
        private Label lblEmaila;
        private TextBox tbNAN;
        private TextBox tbEmaila;
        private TextBox tbAbizena;
        private TextBox tbIzena;
        private GroupBox gbMota;
        private RadioButton rbLangilea;
        private RadioButton rbBezeroa;
        private RadioButton rbKotaktua;
        private GroupBox gbBezeroa;
        private GroupBox gbLangilea;
        private TextBox tbSS;
        private Label lblSS;
        private TextBox tbSoldata;
        private Label lblSoldata;
        private Label lblKategoria;
        private ComboBox comboBox1;
    }
}