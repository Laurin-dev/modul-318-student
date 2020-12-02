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
    public partial class frmAbfahrtstafel : Form
    {
        Transport transport = new Transport();
        public frmAbfahrtstafel()
        {
            InitializeComponent();
        }

        private void BtnAnzeigen_Click(object sender, EventArgs e)
        {
            SetDataGridViewInformations();
        }

        private void SetDataGridViewInformations() {
            try
            {
                dgvAbfahrtstafel.Rows.Clear();
                var listStationBoardEntries = new List<string[]>();
                DateTime stationBoardTime = DateTime.Now;
                Boolean stationBoardBool = true;

                //Get StationBoard from API
                var stationboards = transport.GetStationBoard(cboSearch.Text, "", stationBoardTime);

                //set cursor to waitcursor
                Cursor.Current = Cursors.WaitCursor;

                //Fill StationBoard
                while (stationBoardBool)
                {
                    foreach (StationBoard stationBoard in stationboards.Entries)
                    {
                        string[] stationBoardEntry = new string[] { stationBoard.Stop.Departure.ToString("dd.MM.yyyy HH:mm"), stationBoard.Name, stationBoard.To };
                        if (listStationBoardEntries.Count == 0 || DateTime.Parse(listStationBoardEntries[listStationBoardEntries.Count - 1][0]) < DateTime.Parse(listStationBoardEntries.First()[0]).AddHours(24.0))
                        {
                            dgvAbfahrtstafel.Rows.Add(stationBoardEntry);
                            listStationBoardEntries.Add(stationBoardEntry);
                            stationBoardTime = stationBoard.Stop.Departure;
                        }
                        else
                        {
                            stationBoardBool = false;
                            break;
                        }
                    }
                    stationboards = transport.GetStationBoard(cboSearch.Text, "", stationBoardTime);
                }

                //resetcursor
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Geben Sie einen gülitigen Ort ein.");
            }
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            var location = transport.GetStations(cboSearch.Text);
            frmMap mapForm = new frmMap(location.StationList[0].Coordinate.XCoordinate, location.StationList[0].Coordinate.YCoordinate);

            SetDataGridViewInformations();
            mapForm.Show();
        }

        private void CboSearch_Enter(object sender, EventArgs e)
        {
            if(cboSearch.Text == "Suchen") cboSearch.Text = "";
        }

        private void CboSearch_Leave(object sender, EventArgs e)
        {
            if (cboSearch.Text == "") cboSearch.Text = "Suchen";
        }

        private void CboSearch_KeyUp(object sender, KeyEventArgs e)
        {
            frmMain mainForm = new frmMain();

            mainForm.Combobox_KeyUp(sender, e);
        }
    }
}
