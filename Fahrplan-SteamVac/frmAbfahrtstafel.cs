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
            try
            {
                dgvAbfahrtstafel.Rows.Clear();
                var listStationBoardEntries = new List<string[]>();
                DateTime stationBoardTime = DateTime.Now;
                Boolean stationBoardBool = true;

                //Get StationBoard from API
                var stationboards = transport.GetStationBoard(txtSearch.Text, "", stationBoardTime);

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
                    stationboards = transport.GetStationBoard(txtSearch.Text, "", stationBoardTime);
                }

                //resetcursor
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Geben Sie einen gülitigen Ort ein.");
            }
        }
    }
}
