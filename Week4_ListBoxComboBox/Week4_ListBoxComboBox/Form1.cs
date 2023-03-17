using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_ListBoxComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxCountry.Text) == false)
            {
                listCountry.Items.Add(txtboxCountry.Text);
                listCountry.Sorted = true;
                listCountry.Sorted = false;
                int index = listCountry.FindString(txtboxCountry.Text);
                listCountry.SetSelected(index, true);
                txtboxCountry.Clear();
                txtboxCountry.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listCountry.Sorted = true;
            listCountry.Sorted = false;
            cmbGames1.Sorted = true;
            cmbGames1.Sorted = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listCountry.SelectedIndex >= 0)
            {
                listCountry.Items.RemoveAt(listCountry.SelectedIndex);
            }

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = listCountry.Items.Count;
            string msg = "Jumlah item di dalam list: " + count;
            MessageBox.Show(msg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string msgClear = "Yakin mau hapus?";
            if(MessageBox.Show(msgClear, "CLEAR", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                listCountry.Items.Clear();
                lblSelection.Text = "?";
            } else
            {
                string msg = "TIDAK JADI DI HAPUS";
                MessageBox.Show(msg, "GA JADI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void listCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelection.Text = listCountry.Text;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = listCountry.SelectedIndex;
            string listBoxNameValue = listCountry.SelectedItem.ToString();
            if(index > 0)
            {
                listCountry.Items.RemoveAt(index);
                listCountry.Items.Insert(index - 1, listBoxNameValue);
                listCountry.SetSelected(index - 1, true);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int index = listCountry.SelectedIndex;
            string listBoxNameValue = listCountry.SelectedItem.ToString();
            if(index < listCountry.Items.Count - 1)
            {
                listCountry.Items.RemoveAt(index);
                listCountry.Items.Insert(index + 1, listBoxNameValue);
                listCountry.SetSelected(index + 1, true);
            }
        }

        private void cmbGames1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGame.Text = cmbGames1.Text;
        }

        private void cmbHP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblHP.Text = cmbHP.Text;
        }
    }
}
