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
            this.lstConnections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(46, 36);
            this.txtDeparture.Multiline = false;
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(215, 39);
            this.txtDeparture.TabIndex = 0;
            this.txtDeparture.Text = "Abfahrtsort";
            this.txtDeparture.TextChanged += new System.EventHandler(this.TxtDeparture_TextChanged);
            this.txtDeparture.Enter += new System.EventHandler(this.TxtDeparture_Enter);
            this.txtDeparture.Leave += new System.EventHandler(this.TxtDeparture_Leave);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(46, 130);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(215, 22);
            this.DateTimePicker.TabIndex = 2;
            // 
            // txtArrival
            // 
            this.txtArrival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArrival.Location = new System.Drawing.Point(575, 36);
            this.txtArrival.Multiline = false;
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(215, 39);
            this.txtArrival.TabIndex = 1;
            this.txtArrival.Text = "Ankunftsort";
            this.txtArrival.TextChanged += new System.EventHandler(this.TxtArrival_TextChanged);
            this.txtArrival.Enter += new System.EventHandler(this.TxtArrival_Enter);
            this.txtArrival.Leave += new System.EventHandler(this.TxtArrival_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSearch.Location = new System.Drawing.Point(304, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(215, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Verbindung suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnChangeAD
            // 
            this.btnChangeAD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangeAD.Location = new System.Drawing.Point(304, 36);
            this.btnChangeAD.Name = "btnChangeAD";
            this.btnChangeAD.Size = new System.Drawing.Size(215, 39);
            this.btnChangeAD.TabIndex = 4;
            this.btnChangeAD.Text = "An-/Abfahrtsort wechseln";
            this.btnChangeAD.UseVisualStyleBackColor = true;
            this.btnChangeAD.Click += new System.EventHandler(this.BtnChangeAD_Click);
            // 
            // btnDpTable
            // 
            this.btnDpTable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDpTable.Location = new System.Drawing.Point(575, 124);
            this.btnDpTable.Name = "btnDpTable";
            this.btnDpTable.Size = new System.Drawing.Size(120, 39);
            this.btnDpTable.TabIndex = 6;
            this.btnDpTable.Text = "Abfahrtstafel";
            this.btnDpTable.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.Location = new System.Drawing.Point(734, 124);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 39);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Senden";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(731, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(146, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Verbindung via E-Mail";
            // 
            // lstConnections
            // 
            this.lstConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstConnections.FormattingEnabled = true;
            this.lstConnections.ItemHeight = 16;
            this.lstConnections.Location = new System.Drawing.Point(35, 189);
            this.lstConnections.Name = "lstConnections";
            this.lstConnections.Size = new System.Drawing.Size(819, 388);
            this.lstConnections.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 609);
            this.Controls.Add(this.lstConnections);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDpTable);
            this.Controls.Add(this.btnChangeAD);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.txtDeparture);
            this.Name = "frmMain";
            this.Text = "Fahrplan-SteamVac";
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
        private System.Windows.Forms.ListBox lstConnections;
    }
}

