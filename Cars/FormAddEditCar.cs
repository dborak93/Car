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
    public partial class FormAddEditCar : Form
    {
        
        public FormAddEditCar()
        {
            InitializeComponent();
        }

        private void FillCombobox()
        {
            using (var db = new CarSaleEntities())
            {

                cBProizvodac.DataSource = db.Proizvodacs.ToList();
                cBProizvodac.ValueMember = "ID_Proizvodac";
                cBProizvodac.DisplayMember = "Naziv";
            }

            cBGodina.DataSource = Enumerable.Range(1930, 100).ToList();
            cBGodina.SelectedIndex = -1;

            cBGorivo.DisplayMember = "Text";
            cBGorivo.ValueMember = "Value";
            var gorivo = new[]
            {
                new{Text = "Benzin", Value = "Benzin"},
                new{Text = "Diesel", Value = "Diesel"},
                new{Text = "LPG", Value = "LPG"},
                new{Text = "Electric", Value = "Electric"}
            };
            cBGorivo.DataSource = gorivo;

            cBPogon.DisplayMember = "Text";
            cBPogon.ValueMember = "Value";
            var Pogon = new[]
            {
                new{Text = "FWD", Value = "FWD"},
                new{Text = "RWD", Value = "RWD"},
                new{Text = "AWD", Value = "AWD"}
            };
            cBPogon.DataSource = Pogon;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idP;
            bool res = int.TryParse(cBProizvodac.SelectedValue.ToString(), out idP);
            int god;
            bool result = int.TryParse(cBGodina.SelectedValue.ToString(), out god);
            int pow;
            bool respow = int.TryParse(tBxSnaga.Text, out pow);
            int zap;
            bool reszap = int.TryParse(tBxZapremnina.Text, out zap);
            int price;
            bool resprice = int.TryParse(tBxCijena.Text, out price);
            
            using (var db = new CarSaleEntities())
            {
                Automobil novi = new Automobil
                {
                    Naziv = tBxAutomobil.Text,
                    ID_Proizvodac = idP,
                    Godina = god,
                    Snaga = pow,
                    Zapremnina = zap,
                    Pogon = cBPogon.SelectedValue.ToString(),
                    Gorivo = cBGorivo.SelectedValue.ToString(),
                    Cijena = price,
                };
                db.Automobils.Add(novi);
                db.SaveChanges();
            }
            Close();
        }

        private void FormAddEditCar_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }
    }
}
