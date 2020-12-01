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

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var connections = transport.GetConnections(txtDeparture.Text, txtArrival.Text, 16);

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
              txtArrival.BackColor = Color.Red;
              txtDeparture.BackColor = Color.Red;
            }
            
        }

        private void TxtDeparture_Enter(object sender, EventArgs e)
        {
            if (txtDeparture.Text == "Abfahrtsort") {
                txtDeparture.Text = "";
            }
        }

        private void TxtDeparture_Leave(object sender, EventArgs e)
        {
            if (txtDeparture.Text == "")
            {
                txtDeparture.Text = "Abfahrtsort";
            }
        }

        private void TxtArrival_Enter(object sender, EventArgs e)
        {
            if (txtArrival.Text == "Ankunftsort")
            {
                txtArrival.Text = "";
            }
        }

        private void TxtArrival_Leave(object sender, EventArgs e)
        {
            if (txtArrival.Text == "")
            {
                txtArrival.Text = "Ankunftsort";
            }
        }

        private void EnableSearch() {
            if ((txtArrival.Text == "" || txtArrival.Text == "Ankunftsort") || (txtDeparture.Text == "Abfahrtsort" || txtDeparture.Text == ""))
            {
                btnSearch.Enabled = false;
            }
            else {
                btnSearch.Enabled = true;
            }
        }

        private void TxtDeparture_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void TxtArrival_TextChanged(object sender, EventArgs e)
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
