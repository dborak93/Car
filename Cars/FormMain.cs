using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class FormMain : Form
    {
        private void PrikaziProizvodace()
        {
            BindingList<Proizvodac> listaProizvodaca = null;
            using (var db = new CarSaleEntities())
            {
                listaProizvodaca  = new BindingList<Proizvodac>(db.Proizvodacs.ToList());
            }
            proizvodacBindingSource.DataSource = listaProizvodaca;
        }

        private void PrikaziAutomobile(Proizvodac proizvodac)
        {
            BindingList<Automobil> listaAutomobila = null;
            using (var db = new CarSaleEntities())
            {
                db.Proizvodacs.Attach(proizvodac);
                listaAutomobila = new BindingList<Automobil>(proizvodac.Automobils.ToList<Automobil>());
            }
            automobilBindingSource.DataSource = listaAutomobila;
        }

        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PrikaziProizvodace();
            PrikaziAutomobile(proizvodacBindingSource.Current as Proizvodac);
            
        }

        private void dGVMaker_SelectionChanged(object sender, EventArgs e)
        {
            Proizvodac odabraniProizvodac = proizvodacBindingSource.Current as Proizvodac;
            if(odabraniProizvodac!= null)
            {
                PrikaziAutomobile(odabraniProizvodac);
            }
        }

        private void btnAddMaker_Click(object sender, EventArgs e)
        {
            FormAddEditMaker forma = new FormAddEditMaker();
            forma.ShowDialog();
            PrikaziProizvodace();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditCar forma = new FormAddEditCar();
            forma.ShowDialog();
            PrikaziAutomobile(proizvodacBindingSource.Current as Proizvodac);
        }

        private void btnEditMaker_Click(object sender, EventArgs e)
        {
            Proizvodac odabraniProizvodac = proizvodacBindingSource.Current as Proizvodac;
            if (odabraniProizvodac != null)
            {
                FormAddEditMaker forma = new FormAddEditMaker(odabraniProizvodac);
                forma.ShowDialog();
                PrikaziProizvodace();
            }
        }

        private void btnDeleteMaker_Click(object sender, EventArgs e)
        {
            Proizvodac odabraniProizvodac = proizvodacBindingSource.Current as Proizvodac;
            if(odabraniProizvodac != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite obrisati podatak", "Upozorenje", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new CarSaleEntities())
                    {
                        db.Proizvodacs.Attach(odabraniProizvodac);
                        if (odabraniProizvodac.Automobils.Count == 0)
                        {
                            db.Proizvodacs.Remove(odabraniProizvodac);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati proizvođača koji ima automobile");
                        }
                    }
                    PrikaziProizvodace();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Automobil odabraniAutomobil = automobilBindingSource.Current as Automobil;
            if (automobilBindingSource.Current != null)
            {
                if (MessageBox.Show("Da li ste sigurni da želite obrisati podatak", "Upozorenje", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new CarSaleEntities())
                    {
                        db.Entry(odabraniAutomobil).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                    }

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
