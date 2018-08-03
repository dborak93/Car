namespace Cars
{
    partial class FormAddEditCar
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProizvodac = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblSnaga = new System.Windows.Forms.Label();
            this.lblZapremnina = new System.Windows.Forms.Label();
            this.lblPogon = new System.Windows.Forms.Label();
            this.lblGorivo = new System.Windows.Forms.Label();
            this.tBxAutomobil = new System.Windows.Forms.TextBox();
            this.cBGodina = new System.Windows.Forms.ComboBox();
            this.tBxSnaga = new System.Windows.Forms.TextBox();
            this.tBxZapremnina = new System.Windows.Forms.TextBox();
            this.cBPogon = new System.Windows.Forms.ComboBox();
            this.cBGorivo = new System.Windows.Forms.ComboBox();
            this.cBProizvodac = new System.Windows.Forms.ComboBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.tBxCijena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(216, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(60, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naziv automobila";
            // 
            // lblProizvodac
            // 
            this.lblProizvodac.AutoSize = true;
            this.lblProizvodac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProizvodac.Location = new System.Drawing.Point(60, 76);
            this.lblProizvodac.Name = "lblProizvodac";
            this.lblProizvodac.Size = new System.Drawing.Size(76, 16);
            this.lblProizvodac.TabIndex = 2;
            this.lblProizvodac.Text = "Proizvodač";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodina.Location = new System.Drawing.Point(60, 113);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(52, 16);
            this.lblGodina.TabIndex = 3;
            this.lblGodina.Text = "Godina";
            // 
            // lblSnaga
            // 
            this.lblSnaga.AutoSize = true;
            this.lblSnaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnaga.Location = new System.Drawing.Point(60, 151);
            this.lblSnaga.Name = "lblSnaga";
            this.lblSnaga.Size = new System.Drawing.Size(48, 16);
            this.lblSnaga.TabIndex = 4;
            this.lblSnaga.Text = "Snaga";
            // 
            // lblZapremnina
            // 
            this.lblZapremnina.AutoSize = true;
            this.lblZapremnina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZapremnina.Location = new System.Drawing.Point(60, 190);
            this.lblZapremnina.Name = "lblZapremnina";
            this.lblZapremnina.Size = new System.Drawing.Size(80, 16);
            this.lblZapremnina.TabIndex = 5;
            this.lblZapremnina.Text = "Zapremnina";
            // 
            // lblPogon
            // 
            this.lblPogon.AutoSize = true;
            this.lblPogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPogon.Location = new System.Drawing.Point(60, 228);
            this.lblPogon.Name = "lblPogon";
            this.lblPogon.Size = new System.Drawing.Size(48, 16);
            this.lblPogon.TabIndex = 6;
            this.lblPogon.Text = "Pogon";
            // 
            // lblGorivo
            // 
            this.lblGorivo.AutoSize = true;
            this.lblGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGorivo.Location = new System.Drawing.Point(60, 270);
            this.lblGorivo.Name = "lblGorivo";
            this.lblGorivo.Size = new System.Drawing.Size(48, 16);
            this.lblGorivo.TabIndex = 7;
            this.lblGorivo.Text = "Gorivo";
            // 
            // tBxAutomobil
            // 
            this.tBxAutomobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxAutomobil.Location = new System.Drawing.Point(245, 38);
            this.tBxAutomobil.Name = "tBxAutomobil";
            this.tBxAutomobil.Size = new System.Drawing.Size(194, 22);
            this.tBxAutomobil.TabIndex = 8;
            // 
            // cBGodina
            // 
            this.cBGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGodina.FormattingEnabled = true;
            this.cBGodina.Location = new System.Drawing.Point(245, 110);
            this.cBGodina.Name = "cBGodina";
            this.cBGodina.Size = new System.Drawing.Size(194, 24);
            this.cBGodina.TabIndex = 9;
            // 
            // tBxSnaga
            // 
            this.tBxSnaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxSnaga.Location = new System.Drawing.Point(245, 148);
            this.tBxSnaga.Name = "tBxSnaga";
            this.tBxSnaga.Size = new System.Drawing.Size(194, 22);
            this.tBxSnaga.TabIndex = 10;
            // 
            // tBxZapremnina
            // 
            this.tBxZapremnina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxZapremnina.Location = new System.Drawing.Point(245, 187);
            this.tBxZapremnina.Name = "tBxZapremnina";
            this.tBxZapremnina.Size = new System.Drawing.Size(194, 22);
            this.tBxZapremnina.TabIndex = 11;
            // 
            // cBPogon
            // 
            this.cBPogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPogon.FormattingEnabled = true;
            this.cBPogon.Location = new System.Drawing.Point(245, 225);
            this.cBPogon.Name = "cBPogon";
            this.cBPogon.Size = new System.Drawing.Size(194, 24);
            this.cBPogon.TabIndex = 12;
            // 
            // cBGorivo
            // 
            this.cBGorivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGorivo.FormattingEnabled = true;
            this.cBGorivo.Location = new System.Drawing.Point(245, 267);
            this.cBGorivo.Name = "cBGorivo";
            this.cBGorivo.Size = new System.Drawing.Size(194, 24);
            this.cBGorivo.TabIndex = 13;
            // 
            // cBProizvodac
            // 
            this.cBProizvodac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBProizvodac.FormattingEnabled = true;
            this.cBProizvodac.Location = new System.Drawing.Point(245, 73);
            this.cBProizvodac.Name = "cBProizvodac";
            this.cBProizvodac.Size = new System.Drawing.Size(194, 24);
            this.cBProizvodac.TabIndex = 14;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.Location = new System.Drawing.Point(60, 316);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(46, 16);
            this.lblCijena.TabIndex = 15;
            this.lblCijena.Text = "Cijena";
            // 
            // tBxCijena
            // 
            this.tBxCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxCijena.Location = new System.Drawing.Point(245, 313);
            this.tBxCijena.Name = "tBxCijena";
            this.tBxCijena.Size = new System.Drawing.Size(191, 22);
            this.tBxCijena.TabIndex = 16;
            // 
            // FormAddEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 442);
            this.Controls.Add(this.tBxCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.cBProizvodac);
            this.Controls.Add(this.cBGorivo);
            this.Controls.Add(this.cBPogon);
            this.Controls.Add(this.tBxZapremnina);
            this.Controls.Add(this.tBxSnaga);
            this.Controls.Add(this.cBGodina);
            this.Controls.Add(this.tBxAutomobil);
            this.Controls.Add(this.lblGorivo);
            this.Controls.Add(this.lblPogon);
            this.Controls.Add(this.lblZapremnina);
            this.Controls.Add(this.lblSnaga);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblProizvodac);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Name = "FormAddEditCar";
            this.Text = "Dodaj/Izmjeni automobil";
            this.Load += new System.EventHandler(this.FormAddEditCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProizvodac;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblSnaga;
        private System.Windows.Forms.Label lblZapremnina;
        private System.Windows.Forms.Label lblPogon;
        private System.Windows.Forms.Label lblGorivo;
        private System.Windows.Forms.TextBox tBxAutomobil;
        private System.Windows.Forms.ComboBox cBGodina;
        private System.Windows.Forms.TextBox tBxSnaga;
        private System.Windows.Forms.TextBox tBxZapremnina;
        private System.Windows.Forms.ComboBox cBPogon;
        private System.Windows.Forms.ComboBox cBGorivo;
        private System.Windows.Forms.ComboBox cBProizvodac;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox tBxCijena;
    }
}