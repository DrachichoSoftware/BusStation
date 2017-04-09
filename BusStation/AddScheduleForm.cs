using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusStation
{
    public partial class AddScheduleForm : Form
    {
        public AddScheduleForm()
        {
            InitializeComponent();
        }

        private void addScheduleButton_Click(object sender, EventArgs e)
        {
           
            
        }

        private void timeMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void AddScheduleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeSpan time;
            if (!TimeSpan.TryParse(timeMaskedTextBox.Text, out time))
            {
                MessageBox.Show("Введите корректное время!");
                e.Cancel = true;
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void routeСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
