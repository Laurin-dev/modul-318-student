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
            this.dgvAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.clDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
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
            // frmAbfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 454);
            this.Controls.Add(this.btnAnzeigen);
            this.Controls.Add(this.dgvAbfahrtstafel);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAbfahrtstafel";
            this.Text = "Abfahrtstafel-SteamVac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtstafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvAbfahrtstafel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription1;
        private System.Windows.Forms.Button btnAnzeigen;
    }
}