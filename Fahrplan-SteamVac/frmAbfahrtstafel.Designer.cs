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
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.clDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbfahrtstafel
            // 
            this.dgvAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbfahrtstafel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDeparture,
            this.clLine,
            this.clDescription1});
            this.dgvAbfahrtstafel.Location = new System.Drawing.Point(9, 52);
            this.dgvAbfahrtstafel.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAbfahrtstafel.Name = "dgvAbfahrtstafel";
            this.dgvAbfahrtstafel.RowHeadersWidth = 51;
            this.dgvAbfahrtstafel.RowTemplate.Height = 24;
            this.dgvAbfahrtstafel.Size = new System.Drawing.Size(422, 386);
            this.dgvAbfahrtstafel.TabIndex = 3;
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
            this.clDescription1.HeaderText = "Ziel";
            this.clDescription1.Name = "clDescription1";
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Location = new System.Drawing.Point(151, 7);
            this.btnAnzeigen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(134, 25);
            this.btnAnzeigen.TabIndex = 1;
            this.btnAnzeigen.Text = "Anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.BtnAnzeigen_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(289, 7);
            this.btnMap.Margin = new System.Windows.Forms.Padding(2);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(134, 25);
            this.btnMap.TabIndex = 2;
            this.btnMap.Text = "Standort auf Karte";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(12, 10);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(134, 21);
            this.cboSearch.TabIndex = 0;
            this.cboSearch.Text = "Suchen";
            this.cboSearch.Enter += new System.EventHandler(this.CboSearch_Enter);
            this.cboSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CboSearch_KeyUp);
            this.cboSearch.Leave += new System.EventHandler(this.CboSearch_Leave);
            // 
            // frmAbfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 454);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnAnzeigen);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAbfahrtstafel";
            this.Text = "Abfahrtstafel-SteamVac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription1;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.ComboBox cboSearch;
    }
}