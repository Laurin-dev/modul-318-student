using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Windows.Forms;

namespace Fahrplan_SteamVac
{
    public partial class frmMap : Form
    {
        double LatInicial;
        double LngInicial;

        public frmMap(double xCoordiante, double yCoordiante)
        {
            InitializeComponent();
            LatInicial = xCoordiante;
            LngInicial = yCoordiante;
        }

        private void FrmMap_Load(object sender, EventArgs e)
        {
            gMapMyMap.DragButton = MouseButtons.Left;
            gMapMyMap.CanDragMap = true;
            gMapMyMap.MapProvider = GMapProviders.GoogleMap;
            gMapMyMap.Position = new PointLatLng(LatInicial, LngInicial);
            gMapMyMap.MinZoom = 10;
            gMapMyMap.MaxZoom = 24;
            gMapMyMap.Zoom = 15;
            gMapMyMap.AutoScroll = true;

            GMapOverlay markersOverlay = new GMapOverlay("marker1");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.red);
            markersOverlay.Markers.Add(marker);
            gMapMyMap.Overlays.Add(markersOverlay);
        }
    }
}
