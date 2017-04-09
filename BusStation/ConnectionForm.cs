using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.Data;
using Microsoft.Data.ConnectionUI;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity;

namespace BusStation
{
    public partial class ConnectionForm : Form
    {
        private string _con_string;
        public Bus_Station_Context _context;

        private bool bClosed = false;

        public string Con_string { get => _con_string; set => _con_string = value; }

        public ConnectionForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnection = new SqlConnectionStringBuilder
                {
                    DataSource = serverTextBox.Text,
                    InitialCatalog = dbTextBox.Text,
                    UserID = userTextBox.Text,
                    Password = passwordTextBox.Text,
                    MultipleActiveResultSets = true,
                    ConnectTimeout = 1
                };

                var entityFrameworkConnection = new EntityConnectionStringBuilder
                {
                    Provider = "System.Data.SqlClient",
                    Metadata = @"res://*/Bus_Station_Model.csdl|res://*/Bus_Station_Model.ssdl|res://*/Bus_Station_Model.msl",
                    ProviderConnectionString = sqlConnection.ToString()
                };

                _con_string = entityFrameworkConnection.ConnectionString;

                

                _context = new Bus_Station_Context(_con_string);
                _context.Buses.Load();
                _context.Cities.Load();
                _context.Drivers.Load();
                _context.Passangers.Load();
                _context.Routes.Load();
                _context.Schedules.Load();
                _context.Passages.Load();
                _context.Tickets.Load();
                _context.Waybills.Load();
                bClosed = true;
                

            }
            catch (Exception ex)
            {
                bClosed = false;
                MessageBox.Show(ex.InnerException.Message);  
                
            }
}

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                bClosed = true;
                Application.Exit();
            }
                
            if (bClosed == false)
                e.Cancel = true;

        }
    }
}
