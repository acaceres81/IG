namespace Ariketa1
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
            btnEsaldi1 = new Button();
            btnEsaldi2 = new Button();
            btnLotu = new Button();
            btnEsaldi5 = new Button();
            btnEsaldi4 = new Button();
            btnEsaldi3 = new Button();
            tbIdatzi = new TextBox();
            SuspendLayout();
            // 
            // btnEsaldi1
            // 
            btnEsaldi1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsaldi1.Location = new Point(92, 210);
            btnEsaldi1.Name = "btnEsaldi1";
            btnEsaldi1.Size = new Size(136, 42);
            btnEsaldi1.TabIndex = 0;
            btnEsaldi1.Text = "Esaldi 1";
            btnEsaldi1.UseVisualStyleBackColor = true;
            btnEsaldi1.Click += esaldi1_Click;
            // 
            // btnEsaldi2
            // 
            btnEsaldi2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsaldi2.Location = new Point(332, 210);
            btnEsaldi2.Name = "btnEsaldi2";
            btnEsaldi2.Size = new Size(136, 42);
            btnEsaldi2.TabIndex = 1;
            btnEsaldi2.Text = "Esaldi 2";
            btnEsaldi2.UseVisualStyleBackColor = true;
            btnEsaldi2.Click += btnEsaldi2_Click;
            // 
            // btnLotu
            // 
            btnLotu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLotu.Location = new Point(571, 272);
            btnLotu.Name = "btnLotu";
            btnLotu.Size = new Size(136, 42);
            btnLotu.TabIndex = 2;
            btnLotu.Text = "Lotu";
            btnLotu.UseVisualStyleBackColor = true;
            btnLotu.Click += btnLotu_Click;
            // 
            // btnEsaldi5
            // 
            btnEsaldi5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsaldi5.Location = new Point(332, 272);
            btnEsaldi5.Name = "btnEsaldi5";
            btnEsaldi5.Size = new Size(136, 42);
            btnEsaldi5.TabIndex = 3;
            btnEsaldi5.Text = "Esaldi 5";
            btnEsaldi5.UseVisualStyleBackColor = true;
            btnEsaldi5.Click += btnEsaldi5_Click;
            // 
            // btnEsaldi4
            // 
            btnEsaldi4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsaldi4.Location = new Point(92, 272);
            btnEsaldi4.Name = "btnEsaldi4";
            btnEsaldi4.Size = new Size(136, 42);
            btnEsaldi4.TabIndex = 4;
            btnEsaldi4.Text = "Esaldi 4";
            btnEsaldi4.UseVisualStyleBackColor = true;
            btnEsaldi4.Click += btnEsaldi4_Click;
            // 
            // btnEsaldi3
            // 
            btnEsaldi3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsaldi3.Location = new Point(571, 210);
            btnEsaldi3.Name = "btnEsaldi3";
            btnEsaldi3.Size = new Size(136, 42);
            btnEsaldi3.TabIndex = 5;
            btnEsaldi3.Text = "Esaldi 3";
            btnEsaldi3.UseVisualStyleBackColor = true;
            btnEsaldi3.Click += btnEsaldi3_Click;
            // 
            // tbIdatzi
            // 
            tbIdatzi.Location = new Point(109, 30);
            tbIdatzi.Name = "tbIdatzi";
            tbIdatzi.Size = new Size(582, 27);
            tbIdatzi.TabIndex = 6;
            tbIdatzi.TextChanged += tbIdatzi_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbIdatzi);
            Controls.Add(btnEsaldi3);
            Controls.Add(btnEsaldi4);
            Controls.Add(btnEsaldi5);
            Controls.Add(btnLotu);
            Controls.Add(btnEsaldi2);
            Controls.Add(btnEsaldi1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEsaldi1;
        private Button btnEsaldi2;
        private Button btnLotu;
        private Button btnEsaldi5;
        private Button btnEsaldi4;
        private Button btnEsaldi3;
        private TextBox tbIdatzi;
    }
}