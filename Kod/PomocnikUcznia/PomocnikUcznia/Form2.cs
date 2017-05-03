using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PomocnikUcznia
{
    public partial class Form2 : Form
    {
        private string dayOfWeek;
        private string[] tableData = new string[9];
        private FileOperator fileOperator = new FileOperator();

        public Form2()
        {
            InitializeComponent();
        }


        private void clearForm()
        {
            this.textBox1.ResetText();
            this.textBox2.ResetText();
            this.textBox3.ResetText();
            this.textBox4.ResetText();
            this.textBox5.ResetText();
            this.textBox6.ResetText();
            this.textBox7.ResetText();
            this.textBox8.ResetText();
            this.maskedTextBox1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.radioButton1.Checked = true;
            clearForm();
        }

        // Sprawdzenie jaki wybrano dzień
        private string checkDayOfWeek()
        {
            string _dayOfWeek = null;
            foreach (Control c in this.groupBox1.Controls)
            {
                RadioButton checkbox = c as RadioButton;
                if (checkbox != null && checkbox.Checked)
                {
                    _dayOfWeek = checkbox.Text;
                    break;
                }
            }
            return _dayOfWeek;
        }

        //Obsługa klawisza Zapisz
        private void button2_Click(object sender, EventArgs e)
        {
            if (czyzapisac())
            {
                bool flag = true;
                string text = null;

                text = checkDayOfWeek();

                if (flag)
                {
                    // Pierwsza wartość - godzina
                    dayOfWeek = text;
                    tableData[1] = this.textBox1.Text;
                    tableData[2] = this.textBox2.Text;
                    tableData[3] = this.textBox3.Text;
                    tableData[4] = this.textBox4.Text;
                    tableData[5] = this.textBox5.Text;
                    tableData[6] = this.textBox6.Text;
                    tableData[7] = this.textBox7.Text;
                    tableData[8] = this.textBox8.Text;
                    tableData[0] = this.maskedTextBox1.Text;

                    fileOperator.saveData(dayOfWeek, tableData);
                }
            }        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            string text = null;
            text = checkDayOfWeek();
            tableData = fileOperator.getDataFromFile(text);
            fillInTheForm(tableData);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string text = null;
            text = checkDayOfWeek();
            tableData = fileOperator.getDataFromFile(text);
            fillInTheForm(tableData);
        }

        // Uzupełnienie elementów formularza na podstawie tablicy
        private void fillInTheForm(string[] tableData)
        {
            this.textBox1.Text = tableData[1];
            this.textBox2.Text = tableData[2];
            this.textBox3.Text = tableData[3];
            this.textBox4.Text = tableData[4];
            this.textBox5.Text = tableData[5];
            this.textBox6.Text = tableData[6];
            this.textBox7.Text = tableData[7];
            this.textBox8.Text = tableData[8];
            this.maskedTextBox1.Text = tableData[0];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            string text = null;
            text = checkDayOfWeek();
            tableData = fileOperator.getDataFromFile(text);
            fillInTheForm(tableData);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            string text = null;
            text = checkDayOfWeek();
            tableData = fileOperator.getDataFromFile(text);
            fillInTheForm(tableData);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            string text = null;
            text = checkDayOfWeek();
            tableData = fileOperator.getDataFromFile(text);
            fillInTheForm(tableData);

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            string text = null;
            text = checkDayOfWeek();
            tableData = fileOperator.getDataFromFile(text);
            fillInTheForm(tableData);

        }

        private Boolean czyzapisac()
        {
            DialogResult odp = MessageBox.Show("Chcesz zapisać zmiany?", "Notatnik",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (odp == DialogResult.Yes)
                return true;
            else
                return false;
        }

    }
}
