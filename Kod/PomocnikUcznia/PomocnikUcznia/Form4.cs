using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PomocnikUcznia
{
    public partial class Form4 : Form
    {
        string plik = "";
        
        public Form4()
        {
            InitializeComponent();
        }

        private DialogResult czyzapisac()
        {
            DialogResult odp = MessageBox.Show("Chcesz zapisać zmiany?", "Notatnik",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (odp == DialogResult.Yes)
                zapiszToolStripMenuItem_Click(null, null);
            return odp;
        }

        // Obsługa opcji Zapisz
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (plik != "")
            {
                StreamWriter f = new StreamWriter(plik);
                f.Write(txtTresc.Text);
                f.Close();
            }
            else zapiszJakoToolStripMenuItem_Click(sender, e);
        }

        // Obsługa opcji Nowy
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTresc.Text != "")
            {
                DialogResult odp = czyzapisac();
                if (odp == DialogResult.Cancel)
                    return;
                plik = "";
                txtTresc.Clear();
            }
        }

        // Obsługa opcji Otwórz
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTresc.Text != "")
            {
                DialogResult odp = czyzapisac();
                if (odp == DialogResult.Cancel)
                    return;
                plik = "";
                txtTresc.Clear();
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Plik tekstowy (*.txt)|*.txt";
            dialog.Multiselect = false;
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                plik = dialog.FileName;
                StreamReader f = new StreamReader(plik);
                txtTresc.Text = f.ReadToEnd();
                f.Close();
            }
        }

        // Obsługa opcji Zapisz jako
        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Plik tekstowy (*.txt)|*.txt";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                plik = dialog.FileName;
                StreamWriter f = new StreamWriter(plik);
                f.Write(txtTresc.Text);
                f.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        // Obsługa zdarzenia FormClosing
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTresc.Text != "")
            {
                DialogResult odp = czyzapisac();
                if (odp == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
