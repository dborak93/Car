namespace Cars
{
    partial class FormAddEditMaker
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
            this.lblMaker = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.tBxMaker = new System.Windows.Forms.TextBox();
            this.tBxCountry = new System.Windows.Forms.TextBox();
            this.tBxShort = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaker.Location = new System.Drawing.Point(82, 53);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(76, 16);
            this.lblMaker.TabIndex = 0;
            this.lblMaker.Text = "Proizvođač";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(82, 98);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(51, 16);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Država";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShort.Location = new System.Drawing.Point(82, 145);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(54, 16);
            this.lblShort.TabIndex = 2;
            this.lblShort.Text = "Oznaka";
            // 
            // tBxMaker
            // 
            this.tBxMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxMaker.Location = new System.Drawing.Point(231, 50);
            this.tBxMaker.Name = "tBxMaker";
            this.tBxMaker.Size = new System.Drawing.Size(157, 22);
            this.tBxMaker.TabIndex = 3;
            // 
            // tBxCountry
            // 
            this.tBxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxCountry.Location = new System.Drawing.Point(231, 95);
            this.tBxCountry.Name = "tBxCountry";
            this.tBxCountry.Size = new System.Drawing.Size(157, 22);
            this.tBxCountry.TabIndex = 4;
            // 
            // tBxShort
            // 
            this.tBxShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxShort.Location = new System.Drawing.Point(231, 142);
            this.tBxShort.Name = "tBxShort";
            this.tBxShort.Size = new System.Drawing.Size(157, 22);
            this.tBxShort.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(186, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAddEditMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 367);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBxShort);
            this.Controls.Add(this.tBxCountry);
            this.Controls.Add(this.tBxMaker);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblMaker);
            this.Name = "FormAddEditMaker";
            this.Text = "FormAddEditMaker";
            this.Load += new System.EventHandler(this.FormAddEditMaker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.TextBox tBxMaker;
        private System.Windows.Forms.TextBox tBxCountry;
        private System.Windows.Forms.TextBox tBxShort;
        private System.Windows.Forms.Button btnSave;
    }
}