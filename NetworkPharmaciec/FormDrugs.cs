using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkPharmaciec
{
    public partial class FormDrugs : Form
    {
        public FormDrugs()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Pharmacies pharmSet = new Pharmacies();
            pharmSet.TitleDrug = textBoxTitleDrug.Text;
            pharmSet.Dosage = textBoxDosage.Text;
            pharmSet.Maker = textBoxMaker.Text;
            pharmSet.Hours = textBoxHours.Text;
            Program.frDb.Pharmacies.Add(pharmSet);
            Program.frDb.SaveChanges();
            ShowPharm();
        }
    }
}
