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
            foreach (Pharmacies pharmSet in Program.PhBD.Pharmacies)
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
            Program.PhBD.Pharmacies.Add(pharmSet);
            Program.PhBD.SaveChanges();
            ShowPharm();
        }

        private void ListViewPharm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPharm.SelectedItems.Count == 1)
                {
                    Pharmacies readerSet = listViewPharm.SelectedItems[0].Tag as Pharmacies;
                    Program.PhBD.Pharmacies.Remove(readerSet);
                    Program.PhBD.SaveChanges();
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
    }
}
