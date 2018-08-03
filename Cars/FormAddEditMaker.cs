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
    public partial class FormAddEditMaker : Form
    {
        private Proizvodac MakerEdit;
        public FormAddEditMaker()
        {
            InitializeComponent();
        }
        
        public FormAddEditMaker(Proizvodac p)
        {
            InitializeComponent();
            MakerEdit = p;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new CarSaleEntities())
            {
                if (MakerEdit == null)
                {
                    Proizvodac novi = new Proizvodac
                    {
                        Naziv = tBxMaker.Text,
                        Drzava = tBxCountry.Text,
                        Oznaka = tBxShort.Text,
                    };
                    db.Proizvodacs.Add(novi);
                    db.SaveChanges();
                }
                else
                {
                    db.Proizvodacs.Attach(MakerEdit);
                    MakerEdit.Naziv = tBxMaker.Text;
                    MakerEdit.Drzava = tBxCountry.Text;
                    MakerEdit.Oznaka = tBxShort.Text;
                    db.SaveChanges();
                }
            }
            Close();
        }

        private void FormAddEditMaker_Load(object sender, EventArgs e)
        {
            tBxMaker.Focus();
            if(MakerEdit != null)
            {
                tBxMaker.Text = MakerEdit.Naziv.ToString();
                tBxCountry.Text = MakerEdit.Drzava.ToString();
                tBxShort.Text = MakerEdit.Oznaka.ToString();
            }
        }
    }
}
