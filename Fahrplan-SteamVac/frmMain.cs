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
                //Get Text
                string arrival = cboArrival.Text;
                string departure = cboDeparture.Text;
                
                //Set new Text
                cboArrival.Text = departure;
                cboDeparture.Text = arrival;

                //Refresh DataGridView
                SetDataGridViewData();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Fill/Refresh DataGridView
            SetDataGridViewData();            
        }

        private void SetDataGridViewData() {
            try
            {
                //Get connections from API
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
                MessageBox.Show("Keine Verbindung gefunden.");
            }
        }

        private void EnableSearch() {

            //check wheater or not the comboboxes are empty
            if (cboArrival.Text == "" || cboDeparture.Text == "")
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
            //Open StationBoard
            frmA.Show();
        }

        private List<string> GetSuggestions(string query)
        {
            List<string> stationsList = new List<string>();
            //get all stations with matching string
            var stations = transport.GetStations(query);

            foreach (Station station in stations.StationList) {
                //adding stations to combobox
                stationsList.Add(station.Name);
            }
            if (stationsList.Count == 0) {
                //if Input not valid
                stationsList.Add("Kein Resultat");
            }
            //return stationlist 
            return stationsList;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var dataGridViewlist = new List<string>();
                foreach (DataGridViewRow row in dgvConnections.SelectedRows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataGridViewlist.Add(cell.Value.ToString());
                    }
                }
                if (dataGridViewlist != null) System.Diagnostics.Process.Start("mailto:" + "?subject=Verbindung" + "&body=Von: " + dataGridViewlist[0] + " Nach: " + dataGridViewlist[1] + ", Abfahrt: "+ dataGridViewlist[2] + " Ankunft: " + dataGridViewlist[3] + ", Gleis: " + dataGridViewlist[4]);
            }
            catch {
                MessageBox.Show("Wählen Sie eine Reihe aus.\n" +
                    "(In die Spalte ganz links klicken)");
            }
        }

        private void Combobox_KeyUp(object sender, KeyEventArgs e) {
            if (((ComboBox)sender).Text.Length >= 3) {
                if (e.KeyCode != Keys.Escape)
                {
                    if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
                    {
                        AutoCompletion((ComboBox)sender);
                    }
                }
                else {
                    ((ComboBox)sender).DroppedDown = false;
                }
            }
        }

        private void AutoCompletion(ComboBox sender)
        {
            while (sender.Items.Count > 0)
            {
                sender.Items.RemoveAt(0);
            }

            //set Cursor Wait
            Cursor.Current = Cursors.WaitCursor;

            List<string> stations = GetSuggestions(sender.Text);

            //reset Cursor
            Cursor.Current = Cursors.WaitCursor;

            foreach (String station in stations)
            {
                if (station != null)
                {
                    sender.Items.Add(station);
                }
            }
            sender.DroppedDown = true;
        }
    }
}
