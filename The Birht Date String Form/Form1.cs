using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Birht_Date_String_Form
{
    public partial class birthDateString : Form
    {
        private object monthTextBox;
        private object dayOfWeekTextBox;
        private object dayOfMonthTextBox;
        private object yearTextBox;
        private object dayOfTheWeekTextBox;

        public birthDateString()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
          string output;
          output = dayOftheWeekTextBox.Text + " " + monthTextBox1.Text + " " + dayOfTheMonthTextBox.Text + " " + theYearTextBox.Text;
          dateOutputLabel.Text = output;
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closr the form.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            monthTextBox1.Text = " ";
            theYearTextBox.Text = " ";
            dayOfTheMonthTextBox.Text = " ";

        }
    }
}
