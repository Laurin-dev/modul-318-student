namespace Fahrplan_SteamVac
{
    partial class frmAbfahrtstafel
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCurrentLoc = new System.Windows.Forms.Button();
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.clDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnCurrentLoc
            // 
            this.btnCurrentLoc.Location = new System.Drawing.Point(164, 10);
            this.btnCurrentLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurrentLoc.Name = "btnCurrentLoc";
            this.btnCurrentLoc.Size = new System.Drawing.Size(134, 25);
            this.btnCurrentLoc.TabIndex = 1;
            this.btnCurrentLoc.Text = "Aktueller Standort";
            this.btnCurrentLoc.UseVisualStyleBackColor = true;
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDeparture,
            this.clLine,
            this.clDescription1,
            this.clArrival});
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(9, 52);
            this.dgvAbfahrtstafel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.RowHeadersWidth = 51;
            this.dgvAbfahrtstafel.RowTemplate.Height = 24;
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(726, 386);
            this.dgvAbfahrtstafel.TabIndex = 2;
            // 
            // clDeparture
            // 
            this.clDeparture.HeaderText = "Abfahrts Zeit";
            this.clDeparture.Name = "clDeparture";
            // 
            // clLine
            // 
            this.clLine.HeaderText = "Linie";
            this.clLine.Name = "clLine";
            // 
            // clDescription1
            // 
            this.clDescription1.HeaderText = "Beschriftung";
            this.clDescription1.Name = "clDescription1";
            // 
            // clArrival
            // 
            this.clArrival.HeaderText = "Ankufts Zeit";
            this.clArrival.Name = "clArrival";
            // 
            // frmAbfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 454);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Controls.Add(this.btnCurrentLoc);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAbfahrtstafel";
            this.Text = "Abfahrtstafel-SteamVac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCurrentLoc;
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clArrival;
    }
}