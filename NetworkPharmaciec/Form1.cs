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
    public partial class FormPharm : Form
    {
        public FormPharm()
        {
            InitializeComponent();
            ShowPharm();
        }
        void ShowPharm()
        {
            listViewPharm.Items.Clear();
            foreach (Pharmacies pharmSet in Program.frDb.Pharmacies)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    pharmSet.ID.ToString(), pharmSet.TitlePharm, pharmSet.Address, pharmSet.Phone, pharmSet.Hours
                });
                item.Tag = pharmSet;
                listViewPharm.Items.Add(item);
            }
            listViewPharm.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormPharm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Pharmacies pharmSet = new Pharmacies();
            pharmSet.TitlePharm = textBoxTitlePharm.Text;
            pharmSet.Address = textBoxAddress.Text;
            pharmSet.Phone = textBoxPhone.Text;
            pharmSet.Hours = textBoxHours.Text;
            Program.frDb.Pharmacies.Add(pharmSet);
            Program.frDb.SaveChanges();
            ShowPharm();
        }

        private void ListViewPharm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPharm.SelectedItems.Count == 1)
            {
                Pharmacies pharmSet = listViewPharm.SelectedItems[0].Tag as Pharmacies;
                pharmSet.TitlePharm = textBoxTitlePharm.Text;
                pharmSet.Address = textBoxAddress.Text;
                pharmSet.Phone = textBoxPhone.Text;
                pharmSet.Hours = textBoxHours.Text;
            }
            else
            {
                textBoxTitlePharm.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxHours.Text = "";
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPharm.SelectedItems.Count == 1)
                {
                    Pharmacies readerSet = listViewPharm.SelectedItems[0].Tag as Pharmacies;
                    Program.frDb.Pharmacies.Remove(readerSet);
                    Program.frDb.SaveChanges();
                    ShowPharm();
                }
                textBoxTitlePharm.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxHours.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxTitlePharm_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form formDrugs = new FormDrugs();
            formDrugs.Show();
        }

        private void ButtonRes_Click(object sender, EventArgs e)
        {
            if (listViewPharm.SelectedItems.Count == 1)
            {
                Pharmacies readerSet = new Pharmacies();
                readerSet.TitlePharm = textBoxTitlePharm.Text;
                readerSet.Address = textBoxAddress.Text;
                readerSet.Phone = textBoxPhone.Text;
                readerSet.Hours = textBoxHours.Text;
                Program.frDb.SaveChanges();
                ShowPharm();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPharm.SelectedItems.Count == 1)
            {
                Pharmacies readerSet = new Pharmacies();
                readerSet.TitlePharm = textBoxTitlePharm.Text;
                readerSet.Address = textBoxAddress.Text;
                readerSet.Phone = textBoxPhone.Text;
                readerSet.Hours = textBoxHours.Text;
                Program.frDb.SaveChanges();
                ShowPharm();
            }
        }
    }
}
