using Ical.Net;
using Ical.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icsToMilk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void icsParse(object sender, EventArgs e)
        {
            textBox1.Clear();
            OpenFileDialog icsReader = new OpenFileDialog();
            icsReader.InitialDirectory = Environment.CurrentDirectory;
            if (icsReader.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IICalendarCollection calendarCollection = Calendar.LoadFromFile(icsReader.FileName);
                    foreach (Calendar c in calendarCollection)
                    {
                        foreach (Event eve in c.Events)
                        {
                            //As far as I can tell, the first category is always the class name. This is what we want.
                            textBox1.AppendText(eve.Categories[0] + ": " + eve.Summary + " by " + eve.DtEnd + Environment.NewLine);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
