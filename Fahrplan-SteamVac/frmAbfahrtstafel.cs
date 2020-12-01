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
        public frmAbfahrtstafel()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Transport _Transport = new Transport();
            var Stationboard = _Transport.GetStationBoard(txtSearch.Text, "");
        }
    }
}
