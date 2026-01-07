namespace obsah_kruhu
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPocitej = new System.Windows.Forms.Button();
            this.textInPolomer = new System.Windows.Forms.TextBox();
            this.textInJednotky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPocitej
            // 
            this.buttonPocitej.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPocitej.Location = new System.Drawing.Point(361, 78);
            this.buttonPocitej.Name = "buttonPocitej";
            this.buttonPocitej.Size = new System.Drawing.Size(151, 228);
            this.buttonPocitej.TabIndex = 0;
            this.buttonPocitej.Text = "POCITEJ!";
            this.buttonPocitej.UseVisualStyleBackColor = true;
            this.buttonPocitej.Click += new System.EventHandler(this.buttonPocitej_Click);
            // 
            // textInPolomer
            // 
            this.textInPolomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInPolomer.Location = new System.Drawing.Point(215, 78);
            this.textInPolomer.Name = "textInPolomer";
            this.textInPolomer.Size = new System.Drawing.Size(100, 38);
            this.textInPolomer.TabIndex = 1;
            this.textInPolomer.TextChanged += new System.EventHandler(this.textInPolomer_TextChanged);
            // 
            // textInJednotky
            // 
            this.textInJednotky.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textInJednotky.Location = new System.Drawing.Point(215, 173);
            this.textInJednotky.Name = "textInJednotky";
            this.textInJednotky.Size = new System.Drawing.Size(100, 38);
            this.textInJednotky.TabIndex = 2;
            this.textInJednotky.TextChanged += new System.EventHandler(this.textInJednotky_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poloměr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(52, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jednotka";
            // 
            // textOut
            // 
            this.textOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textOut.Location = new System.Drawing.Point(58, 254);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(252, 52);
            this.textOut.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 337);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInJednotky);
            this.Controls.Add(this.textInPolomer);
            this.Controls.Add(this.buttonPocitej);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPocitej;
        private System.Windows.Forms.TextBox textInPolomer;
        private System.Windows.Forms.TextBox textInJednotky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOut;
    }
}

