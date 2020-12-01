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
            this.txtDeparture = new System.Windows.Forms.RichTextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtArrival = new System.Windows.Forms.RichTextBox();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(34, 29);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeparture.Multiline = false;
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(162, 32);
            this.txtDeparture.TabIndex = 0;
            this.txtDeparture.Text = "Abfahrtsort";
            this.txtDeparture.TextChanged += new System.EventHandler(this.TxtDeparture_TextChanged);
            this.txtDeparture.Enter += new System.EventHandler(this.TxtDeparture_Enter);
            this.txtDeparture.Leave += new System.EventHandler(this.TxtDeparture_Leave);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(34, 105);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(83, 20);
            this.DateTimePicker.TabIndex = 2;
            // 
            // txtArrival
            // 
            this.txtArrival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArrival.Location = new System.Drawing.Point(431, 29);
            this.txtArrival.Margin = new System.Windows.Forms.Padding(2);
            this.txtArrival.Multiline = false;
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(162, 32);
            this.txtArrival.TabIndex = 1;
            this.txtArrival.Text = "Ankunftsort";
            this.txtArrival.TextChanged += new System.EventHandler(this.TxtArrival_TextChanged);
            this.txtArrival.Enter += new System.EventHandler(this.TxtArrival_Enter);
            this.txtArrival.Leave += new System.EventHandler(this.TxtArrival_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSearch.Location = new System.Drawing.Point(228, 101);
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
            this.btnChangeAD.Location = new System.Drawing.Point(228, 29);
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
            this.btnDpTable.Location = new System.Drawing.Point(431, 101);
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
            this.btnSend.Location = new System.Drawing.Point(550, 101);
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
            this.lblEmail.Location = new System.Drawing.Point(548, 74);
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
            this.dgvConnections.Size = new System.Drawing.Size(606, 325);
            this.dgvConnections.TabIndex = 10;
            // 
            // clFrom
            // 
            this.clFrom.HeaderText = "Von";
            this.clFrom.MinimumWidth = 6;
            this.clFrom.Name = "clFrom";
            this.clFrom.Width = 125;
            // 
            // clTo
            // 
            this.clTo.HeaderText = "Nach";
            this.clTo.MinimumWidth = 6;
            this.clTo.Name = "clTo";
            this.clTo.Width = 125;
            // 
            // clDeparture
            // 
            this.clDeparture.HeaderText = "Abfahrt";
            this.clDeparture.MinimumWidth = 6;
            this.clDeparture.Name = "clDeparture";
            this.clDeparture.Width = 125;
            // 
            // clArrival
            // 
            this.clArrival.HeaderText = "Ankunft";
            this.clArrival.MinimumWidth = 6;
            this.clArrival.Name = "clArrival";
            this.clArrival.Width = 125;
            // 
            // clDuration
            // 
            this.clDuration.HeaderText = "Dauer";
            this.clDuration.MinimumWidth = 6;
            this.clDuration.Name = "clDuration";
            this.clDuration.Width = 125;
            // 
            // clPanel
            // 
            this.clPanel.HeaderText = "Gleis";
            this.clPanel.MinimumWidth = 6;
            this.clPanel.Name = "clPanel";
            this.clPanel.Width = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 105);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(66, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 495);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvConnections);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDpTable);
            this.Controls.Add(this.btnChangeAD);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.txtDeparture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Fahrplan-SteamVac";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDeparture;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.RichTextBox txtArrival;
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
        private DateTimePicker dateTimePicker1;
    }
}

