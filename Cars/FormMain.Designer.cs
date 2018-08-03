namespace Cars
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.dGVMaker = new System.Windows.Forms.DataGridView();
            this.iDProizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobilsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dGVModel = new System.Windows.Forms.DataGridView();
            this.iDAutomobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snagaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pogonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapremninaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProizvodacDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteMaker = new System.Windows.Forms.Button();
            this.btnEditMaker = new System.Windows.Forms.Button();
            this.btnAddMaker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMaker
            // 
            this.dGVMaker.AutoGenerateColumns = false;
            this.dGVMaker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMaker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProizvodacDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.oznakaDataGridViewTextBoxColumn,
            this.automobilsDataGridViewTextBoxColumn});
            this.dGVMaker.DataSource = this.proizvodacBindingSource;
            this.dGVMaker.Location = new System.Drawing.Point(25, 12);
            this.dGVMaker.Name = "dGVMaker";
            this.dGVMaker.Size = new System.Drawing.Size(865, 161);
            this.dGVMaker.TabIndex = 0;
            this.dGVMaker.SelectionChanged += new System.EventHandler(this.dGVMaker_SelectionChanged);
            // 
            // iDProizvodacDataGridViewTextBoxColumn
            // 
            this.iDProizvodacDataGridViewTextBoxColumn.DataPropertyName = "ID_Proizvodac";
            this.iDProizvodacDataGridViewTextBoxColumn.HeaderText = "ID_Proizvodac";
            this.iDProizvodacDataGridViewTextBoxColumn.Name = "iDProizvodacDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            // 
            // oznakaDataGridViewTextBoxColumn
            // 
            this.oznakaDataGridViewTextBoxColumn.DataPropertyName = "Oznaka";
            this.oznakaDataGridViewTextBoxColumn.HeaderText = "Oznaka";
            this.oznakaDataGridViewTextBoxColumn.Name = "oznakaDataGridViewTextBoxColumn";
            // 
            // automobilsDataGridViewTextBoxColumn
            // 
            this.automobilsDataGridViewTextBoxColumn.DataPropertyName = "Automobils";
            this.automobilsDataGridViewTextBoxColumn.HeaderText = "Automobils";
            this.automobilsDataGridViewTextBoxColumn.Name = "automobilsDataGridViewTextBoxColumn";
            this.automobilsDataGridViewTextBoxColumn.Visible = false;
            // 
            // proizvodacBindingSource
            // 
            this.proizvodacBindingSource.DataSource = typeof(Cars.Proizvodac);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(792, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(688, 411);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 27);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Izmjeni";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(584, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dGVModel
            // 
            this.dGVModel.AutoGenerateColumns = false;
            this.dGVModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVModel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAutomobilDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1,
            this.snagaDataGridViewTextBoxColumn,
            this.godinaDataGridViewTextBoxColumn,
            this.gorivoDataGridViewTextBoxColumn,
            this.pogonDataGridViewTextBoxColumn,
            this.zapremninaDataGridViewTextBoxColumn,
            this.iDProizvodacDataGridViewTextBoxColumn1,
            this.cijenaDataGridViewTextBoxColumn,
            this.proizvodacDataGridViewTextBoxColumn});
            this.dGVModel.DataSource = this.automobilBindingSource;
            this.dGVModel.Location = new System.Drawing.Point(25, 241);
            this.dGVModel.Name = "dGVModel";
            this.dGVModel.Size = new System.Drawing.Size(865, 164);
            this.dGVModel.TabIndex = 4;
            // 
            // iDAutomobilDataGridViewTextBoxColumn
            // 
            this.iDAutomobilDataGridViewTextBoxColumn.DataPropertyName = "ID_Automobil";
            this.iDAutomobilDataGridViewTextBoxColumn.HeaderText = "ID_Automobil";
            this.iDAutomobilDataGridViewTextBoxColumn.Name = "iDAutomobilDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            // 
            // snagaDataGridViewTextBoxColumn
            // 
            this.snagaDataGridViewTextBoxColumn.DataPropertyName = "Snaga";
            this.snagaDataGridViewTextBoxColumn.HeaderText = "Snaga";
            this.snagaDataGridViewTextBoxColumn.Name = "snagaDataGridViewTextBoxColumn";
            // 
            // godinaDataGridViewTextBoxColumn
            // 
            this.godinaDataGridViewTextBoxColumn.DataPropertyName = "Godina";
            this.godinaDataGridViewTextBoxColumn.HeaderText = "Godina";
            this.godinaDataGridViewTextBoxColumn.Name = "godinaDataGridViewTextBoxColumn";
            // 
            // gorivoDataGridViewTextBoxColumn
            // 
            this.gorivoDataGridViewTextBoxColumn.DataPropertyName = "Gorivo";
            this.gorivoDataGridViewTextBoxColumn.HeaderText = "Gorivo";
            this.gorivoDataGridViewTextBoxColumn.Name = "gorivoDataGridViewTextBoxColumn";
            // 
            // pogonDataGridViewTextBoxColumn
            // 
            this.pogonDataGridViewTextBoxColumn.DataPropertyName = "Pogon";
            this.pogonDataGridViewTextBoxColumn.HeaderText = "Pogon";
            this.pogonDataGridViewTextBoxColumn.Name = "pogonDataGridViewTextBoxColumn";
            // 
            // zapremninaDataGridViewTextBoxColumn
            // 
            this.zapremninaDataGridViewTextBoxColumn.DataPropertyName = "Zapremnina";
            this.zapremninaDataGridViewTextBoxColumn.HeaderText = "Zapremnina";
            this.zapremninaDataGridViewTextBoxColumn.Name = "zapremninaDataGridViewTextBoxColumn";
            // 
            // iDProizvodacDataGridViewTextBoxColumn1
            // 
            this.iDProizvodacDataGridViewTextBoxColumn1.DataPropertyName = "ID_Proizvodac";
            this.iDProizvodacDataGridViewTextBoxColumn1.HeaderText = "ID_Proizvodac";
            this.iDProizvodacDataGridViewTextBoxColumn1.Name = "iDProizvodacDataGridViewTextBoxColumn1";
            this.iDProizvodacDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // proizvodacDataGridViewTextBoxColumn
            // 
            this.proizvodacDataGridViewTextBoxColumn.DataPropertyName = "Proizvodac";
            this.proizvodacDataGridViewTextBoxColumn.HeaderText = "Proizvodac";
            this.proizvodacDataGridViewTextBoxColumn.Name = "proizvodacDataGridViewTextBoxColumn";
            this.proizvodacDataGridViewTextBoxColumn.Visible = false;
            // 
            // automobilBindingSource
            // 
            this.automobilBindingSource.DataSource = typeof(Cars.Automobil);
            // 
            // btnDeleteMaker
            // 
            this.btnDeleteMaker.Location = new System.Drawing.Point(792, 179);
            this.btnDeleteMaker.Name = "btnDeleteMaker";
            this.btnDeleteMaker.Size = new System.Drawing.Size(98, 27);
            this.btnDeleteMaker.TabIndex = 5;
            this.btnDeleteMaker.Text = "Obriši";
            this.btnDeleteMaker.UseVisualStyleBackColor = true;
            this.btnDeleteMaker.Click += new System.EventHandler(this.btnDeleteMaker_Click);
            // 
            // btnEditMaker
            // 
            this.btnEditMaker.Location = new System.Drawing.Point(688, 179);
            this.btnEditMaker.Name = "btnEditMaker";
            this.btnEditMaker.Size = new System.Drawing.Size(98, 27);
            this.btnEditMaker.TabIndex = 6;
            this.btnEditMaker.Text = "Izmjeni";
            this.btnEditMaker.UseVisualStyleBackColor = true;
            this.btnEditMaker.Click += new System.EventHandler(this.btnEditMaker_Click);
            // 
            // btnAddMaker
            // 
            this.btnAddMaker.Location = new System.Drawing.Point(584, 180);
            this.btnAddMaker.Name = "btnAddMaker";
            this.btnAddMaker.Size = new System.Drawing.Size(98, 26);
            this.btnAddMaker.TabIndex = 7;
            this.btnAddMaker.Text = "Dodaj";
            this.btnAddMaker.UseVisualStyleBackColor = true;
            this.btnAddMaker.Click += new System.EventHandler(this.btnAddMaker_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 476);
            this.Controls.Add(this.btnAddMaker);
            this.Controls.Add(this.btnEditMaker);
            this.Controls.Add(this.btnDeleteMaker);
            this.Controls.Add(this.dGVModel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dGVMaker);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMaker;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dGVModel;
        private System.Windows.Forms.BindingSource proizvodacBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn automobilsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource automobilBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAutomobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snagaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pogonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapremninaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProizvodacDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodacDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteMaker;
        private System.Windows.Forms.Button btnEditMaker;
        private System.Windows.Forms.Button btnAddMaker;
    }
}

