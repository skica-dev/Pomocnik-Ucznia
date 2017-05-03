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
    public partial class Form1 : Form
    {

        private string[] tableData = new string[9];
        private FileOperator fileOperator = new FileOperator();
        bool visible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutClick(object sender, EventArgs e)
        {
            /* MessageBox.Show("Kliknięte!!!");
             * */
            (new AboutBox2()).ShowDialog();
            
        }

//        private void InsertMonday(object sender, EventArgs e)
//        {
//            (new Form2()).ShowDialog();
//        }

        private void wprowadźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uruchomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }


        private void uruchomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!visible)
            {
                string _dayOfWeek = "Monday";
                string dayOfWeek = "Poniedziałek";
                DateTime d = DateTime.Today.AddDays(1);
                _dayOfWeek = "" + d.DayOfWeek;
                switch (_dayOfWeek)
                {
                    case "Monday":
                        dayOfWeek = "Poniedziałek";
                        break;
                    case "Tuesday":
                        dayOfWeek = "Wtorek";
                        break;
                    case "Wednesday":
                        dayOfWeek = "Środa";
                        break;
                    case "Thursday":
                        dayOfWeek = "Czwartek";
                        break;
                    case "Friday":
                        dayOfWeek = "Piątek";
                        break;
                    case "Saturday":
                        dayOfWeek = "Poniedziałek";
                        break;
                    case "Sunday":
                        dayOfWeek = "Poniedziałek";
                        break;
                }
                tableData = fileOperator.getDataFromFile(dayOfWeek);
                labelPlan.Text += dayOfWeek;
                labelPlan.Visible = true;
                labelLekcje.Visible = true;
                button1.Visible = true;
                labelGodzina.Text += "" + tableData[0];
                labelGodzina.Visible = true;
                label1.Text += "" + tableData[1];
                label1.Visible = true;
                label2.Text += "" + tableData[2];
                label2.Visible = true;
                label3.Text += "" + tableData[3];
                label3.Visible = true;
                label4.Text += "" + tableData[4];
                label4.Visible = true;
                label5.Text += "" + tableData[5];
                label5.Visible = true;
                label6.Text += "" + tableData[6];
                label6.Visible = true;
                label7.Text += "" + tableData[7];
                label7.Visible = true;
                label8.Text += "" + tableData[8];
                label8.Visible = true;
            } 
            if (visible)
            {
                visible = false;
                button1_Click(null, null);
            }
            else
            {
                visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelPlan.Text = "Plan Lekcji na najbliższy ";
            labelPlan.Visible = false;
            labelLekcje.Visible = false;
            button1.Visible = false;
            labelGodzina.Text = "Godzina rozpoczęcia: ";
            labelGodzina.Visible = false;
            label1.Text = "1. ";
            label1.Visible = false;
            label2.Text = "2. ";
            label2.Visible = false;
            label3.Text = "3. ";
            label3.Visible = false;
            label4.Text = "4. ";
            label4.Visible = false;
            label5.Text = "5. ";
            label5.Visible = false;
            label6.Text = "6. ";
            label6.Visible = false;
            label7.Text = "7. ";
            label7.Visible = false;
            label8.Text = "8. ";
            label8.Visible = false;
            
            visible = false;
        }
    }
}
