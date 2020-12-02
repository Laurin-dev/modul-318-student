namespace Fahrplan_SteamVac
{
    partial class frmMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapMyMap = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gMapMyMap
            // 
            this.gMapMyMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapMyMap.Bearing = 0F;
            this.gMapMyMap.CanDragMap = true;
            this.gMapMyMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapMyMap.GrayScaleMode = false;
            this.gMapMyMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapMyMap.LevelsKeepInMemmory = 5;
            this.gMapMyMap.Location = new System.Drawing.Point(1, 0);
            this.gMapMyMap.MarkersEnabled = true;
            this.gMapMyMap.MaxZoom = 2;
            this.gMapMyMap.MinZoom = 2;
            this.gMapMyMap.MouseWheelZoomEnabled = true;
            this.gMapMyMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMyMap.Name = "gMapMyMap";
            this.gMapMyMap.NegativeMode = false;
            this.gMapMyMap.PolygonsEnabled = true;
            this.gMapMyMap.RetryLoadTile = 0;
            this.gMapMyMap.RoutesEnabled = true;
            this.gMapMyMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapMyMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapMyMap.ShowTileGridLines = false;
            this.gMapMyMap.Size = new System.Drawing.Size(799, 450);
            this.gMapMyMap.TabIndex = 0;
            this.gMapMyMap.Zoom = 0D;
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gMapMyMap);
            this.Name = "frmMap";
            this.Text = "Karte";
            this.Load += new System.EventHandler(this.FrmMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapMyMap;
    }
}