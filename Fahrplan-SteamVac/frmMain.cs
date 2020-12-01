using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrplan_SteamVac
{
    public partial class frmMain : Form
    {
        Transport transport = new Transport();
        public frmMain()
        {
            InitializeComponent();
            EnableSearch();
        }

        private void BtnChangeAD_Click(object sender, EventArgs e)
        {
            if(cboDeparture.Text != "Abfahrtsort" && cboArrival.Text != "Ankunftsort")
            {
                string arrival = cboArrival.Text;
                string departure = cboDeparture.Text;

                cboArrival.Text = departure;
                cboDeparture.Text = arrival;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var connections = transport.GetConnections(cboDeparture.Text, cboArrival.Text, 16, dtpTime.Value, dtpDate.Value);

                if (connections.ConnectionList.Count != 0)
                {
                    //clear List
                    dgvConnections.Rows.Clear();

                    //fill List
                    foreach (Connection connection in connections.ConnectionList)
                    {
                        DateTime departureTime = DateTime.Parse(connection.From.Departure);
                        DateTime arrivalTime = DateTime.Parse(connection.To.Arrival);
                        TimeSpan duration = TimeSpan.Parse(connection.Duration.Replace("d", ":"));

                        dgvConnections.Rows.Add(new[] { connection.From.Station.Name, connection.To.Station.Name, departureTime.ToString("HH:mm"), arrivalTime.ToString("HH:mm"), duration.ToString(@"hh\:mm"), connection.From.Platform });
                    }
                }
            }
            catch
            {
              cboArrival.BackColor = Color.Red;
              cboDeparture.BackColor = Color.Red;
            }
            
        }

        private void cboDeparture_Enter(object sender, EventArgs e)
        {
            if (cboDeparture.Text == "Abfahrtsort") {
                cboDeparture.Text = "";
            }
        }

        private void cboDeparture_Leave(object sender, EventArgs e)
        {
            if (cboDeparture.Text == "")
            {
                cboDeparture.Text = "Abfahrtsort";
            }
        }

        private void cboArrival_Enter(object sender, EventArgs e)
        {
            if (cboArrival.Text == "Ankunftsort")
            {
                cboArrival.Text = "";
            }
        }

        private void cboArrival_Leave(object sender, EventArgs e)
        {
            if (cboArrival.Text == "")
            {
                cboArrival.Text = "Ankunftsort";
            }
        }

        private void EnableSearch() {
            if ((cboArrival.Text == "" || cboArrival.Text == "Ankunftsort") || (cboDeparture.Text == "Abfahrtsort" || cboDeparture.Text == ""))
            {
                btnSearch.Enabled = false;
            }
            else {
                btnSearch.Enabled = true;
            }
        }

        private void cboDeparture_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void cboArrival_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void BtnDpTable_Click(object sender, EventArgs e)
        {
            frmAbfahrtstafel frmA = new frmAbfahrtstafel();

            frmA.Show();
        }
    }
}
