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
        Transport _Transport = new Transport();
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnChangeAD_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String sOuput;
            var connections = _Transport.GetConnections(txtDeparture.Text, txtArrival.Text, 16);

            //clear List
            lstConnections.Items.Clear();

            //fill List
            foreach (Connection connection in connections.ConnectionList) {
                DateTime departureTime = DateTime.Parse(connection.From.Departure);
                DateTime arrivalTime = DateTime.Parse(connection.To.Arrival);
                TimeSpan duration = TimeSpan.Parse(connection.Duration.Replace("d", ":"));

                sOuput = "Von " + connection.From.Station.Name + " nach " + connection.To.Station.Name + "\tAbfahrt: " + departureTime.ToString("HH:mm") + " Ankunft: " + arrivalTime.ToString("HH:mm") + "\tDauer: " + duration.ToString(@"hh\:mm") + "\tAbfahrts Gleis: " + connection.From.Platform;
                lstConnections.Items.Add(sOuput);
            }
        }
    }
}
