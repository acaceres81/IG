namespace Ariketa2Zerrenda
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
            lblZenbakiak = new Label();
            btnHurrengoa = new Button();
            btnGarbitu = new Button();
            btnIrten = new Button();
            tbEmaitza = new TextBox();
            SuspendLayout();
            // 
            // lblZenbakiak
            // 
            lblZenbakiak.AutoSize = true;
            lblZenbakiak.Location = new Point(123, 91);
            lblZenbakiak.Name = "lblZenbakiak";
            lblZenbakiak.Size = new Size(82, 20);
            lblZenbakiak.TabIndex = 0;
            lblZenbakiak.Text = "Zenbakia 1";
            lblZenbakiak.Click += lblZenbakiak_Click;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(157, 216);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(94, 29);
            btnHurrengoa.TabIndex = 1;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(353, 216);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(94, 29);
            btnGarbitu.TabIndex = 2;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btnIrten
            // 
            btnIrten.Location = new Point(554, 216);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 3;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = true;
            btnIrten.Click += btnIrten_Click;
            // 
            // tbEmaitza
            // 
            tbEmaitza.Location = new Point(247, 88);
            tbEmaitza.Name = "tbEmaitza";
            tbEmaitza.Size = new Size(481, 27);
            tbEmaitza.TabIndex = 4;
            tbEmaitza.TextChanged += tbEmaitza_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbEmaitza);
            Controls.Add(btnIrten);
            Controls.Add(btnGarbitu);
            Controls.Add(btnHurrengoa);
            Controls.Add(lblZenbakiak);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZenbakiak;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
        private TextBox tbEmaitza;
    }
}