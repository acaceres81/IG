namespace Ariketa2Array
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
            tbEmaitza = new TextBox();
            btnHurrengoa = new Button();
            btnGarbitu = new Button();
            btnIrten = new Button();
            SuspendLayout();
            // 
            // lblZenbakiak
            // 
            lblZenbakiak.AutoSize = true;
            lblZenbakiak.Location = new Point(98, 92);
            lblZenbakiak.Name = "lblZenbakiak";
            lblZenbakiak.Size = new Size(82, 20);
            lblZenbakiak.TabIndex = 0;
            lblZenbakiak.Text = "Zenbakia 1";
            lblZenbakiak.Click += lblZenbakiak_Click;
            // 
            // tbEmaitza
            // 
            tbEmaitza.Location = new Point(209, 89);
            tbEmaitza.Name = "tbEmaitza";
            tbEmaitza.Size = new Size(469, 27);
            tbEmaitza.TabIndex = 1;
            tbEmaitza.TextChanged += tbEmaitza_TextChanged;
            // 
            // btnHurrengoa
            // 
            btnHurrengoa.Location = new Point(127, 192);
            btnHurrengoa.Name = "btnHurrengoa";
            btnHurrengoa.Size = new Size(94, 29);
            btnHurrengoa.TabIndex = 2;
            btnHurrengoa.Text = "Hurrengoa";
            btnHurrengoa.UseVisualStyleBackColor = true;
            btnHurrengoa.Click += btnHurrengoa_Click;
            // 
            // btnGarbitu
            // 
            btnGarbitu.Location = new Point(347, 192);
            btnGarbitu.Name = "btnGarbitu";
            btnGarbitu.Size = new Size(94, 29);
            btnGarbitu.TabIndex = 3;
            btnGarbitu.Text = "Garbitu";
            btnGarbitu.UseVisualStyleBackColor = true;
            btnGarbitu.Click += btnGarbitu_Click;
            // 
            // btnIrten
            // 
            btnIrten.Location = new Point(585, 196);
            btnIrten.Name = "btnIrten";
            btnIrten.Size = new Size(94, 29);
            btnIrten.TabIndex = 4;
            btnIrten.Text = "Irten";
            btnIrten.UseVisualStyleBackColor = true;
            btnIrten.Click += btnIrten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 302);
            Controls.Add(btnIrten);
            Controls.Add(btnGarbitu);
            Controls.Add(btnHurrengoa);
            Controls.Add(tbEmaitza);
            Controls.Add(lblZenbakiak);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZenbakiak;
        private TextBox tbEmaitza;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}