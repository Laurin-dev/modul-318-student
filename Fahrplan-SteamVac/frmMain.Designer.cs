using System.Windows.Forms;

namespace Fahrplan_SteamVac
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnChangeAD = new System.Windows.Forms.Button();
            this.btnDpTable = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.clFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cboDeparture = new System.Windows.Forms.ComboBox();
            this.cboArrival = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(34, 105);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(83, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSearch.Location = new System.Drawing.Point(233, 101);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Verbindung suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnChangeAD
            // 
            this.btnChangeAD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangeAD.AutoSize = true;
            this.btnChangeAD.Location = new System.Drawing.Point(233, 29);
            this.btnChangeAD.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeAD.Name = "btnChangeAD";
            this.btnChangeAD.Size = new System.Drawing.Size(161, 32);
            this.btnChangeAD.TabIndex = 4;
            this.btnChangeAD.Text = "An-/Abfahrtsort wechseln";
            this.btnChangeAD.UseVisualStyleBackColor = true;
            this.btnChangeAD.Click += new System.EventHandler(this.BtnChangeAD_Click);
            // 
            // btnDpTable
            // 
            this.btnDpTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDpTable.Location = new System.Drawing.Point(440, 101);
            this.btnDpTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDpTable.Name = "btnDpTable";
            this.btnDpTable.Size = new System.Drawing.Size(90, 32);
            this.btnDpTable.TabIndex = 6;
            this.btnDpTable.Text = "Abfahrtstafel";
            this.btnDpTable.UseVisualStyleBackColor = true;
            this.btnDpTable.Click += new System.EventHandler(this.BtnDpTable_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.Location = new System.Drawing.Point(559, 101);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 32);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Senden";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(557, 74);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Verbindung via E-Mail";
            // 
            // dgvConnections
            // 
            this.dgvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFrom,
            this.clTo,
            this.clDeparture,
            this.clArrival,
            this.clDuration,
            this.clPanel});
            this.dgvConnections.Location = new System.Drawing.Point(34, 160);
            this.dgvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowHeadersWidth = 51;
            this.dgvConnections.RowTemplate.Height = 24;
            this.dgvConnections.Size = new System.Drawing.Size(615, 325);
            this.dgvConnections.TabIndex = 10;
            // 
            // clFrom
            // 
            this.clFrom.HeaderText = "Von";
            this.clFrom.MinimumWidth = 6;
            this.clFrom.Name = "clFrom";
            // 
            // clTo
            // 
            this.clTo.HeaderText = "Nach";
            this.clTo.MinimumWidth = 6;
            this.clTo.Name = "clTo";
            // 
            // clDeparture
            // 
            this.clDeparture.HeaderText = "Abfahrt";
            this.clDeparture.MinimumWidth = 6;
            this.clDeparture.Name = "clDeparture";
            // 
            // clArrival
            // 
            this.clArrival.HeaderText = "Ankunft";
            this.clArrival.MinimumWidth = 6;
            this.clArrival.Name = "clArrival";
            // 
            // clDuration
            // 
            this.clDuration.HeaderText = "Dauer";
            this.clDuration.MinimumWidth = 6;
            this.clDuration.Name = "clDuration";
            // 
            // clPanel
            // 
            this.clPanel.HeaderText = "Gleis";
            this.clPanel.MinimumWidth = 6;
            this.clPanel.Name = "clPanel";
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtpTime.Location = new System.Drawing.Point(121, 105);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(66, 20);
            this.dtpTime.TabIndex = 11;
            // 
            // cboDeparture
            // 
            this.cboDeparture.FormattingEnabled = true;
            this.cboDeparture.Location = new System.Drawing.Point(34, 36);
            this.cboDeparture.Name = "cboDeparture";
            this.cboDeparture.Size = new System.Drawing.Size(143, 21);
            this.cboDeparture.TabIndex = 12;
            // 
            // cboArrival
            // 
            this.cboArrival.FormattingEnabled = true;
            this.cboArrival.Location = new System.Drawing.Point(440, 36);
            this.cboArrival.Name = "cboArrival";
            this.cboArrival.Size = new System.Drawing.Size(143, 21);
            this.cboArrival.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 495);
            this.Controls.Add(this.cboArrival);
            this.Controls.Add(this.cboDeparture);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dgvConnections);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDpTable);
            this.Controls.Add(this.btnChangeAD);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Fahrplan-SteamVac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnChangeAD;
        private System.Windows.Forms.Button btnDpTable;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblEmail;
        private DataGridView dgvConnections;
        private DataGridViewTextBoxColumn clFrom;
        private DataGridViewTextBoxColumn clTo;
        private DataGridViewTextBoxColumn clDeparture;
        private DataGridViewTextBoxColumn clArrival;
        private DataGridViewTextBoxColumn clDuration;
        private DataGridViewTextBoxColumn clPanel;
        private DateTimePicker dtpTime;
        private ComboBox cboDeparture;
        private ComboBox cboArrival;
    }
}

