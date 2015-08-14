namespace TicketReservationSystem
{
    partial class ReserveMenu
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
            this.components = new System.ComponentModel.Container();
            this.airCraftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airAsianDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airAsianDataBaseDataSet = new TicketReservationSystem.AirAsianDataBaseDataSet();
            this.airCraftTableAdapter = new TicketReservationSystem.AirAsianDataBaseDataSetTableAdapters.AirCraftTableAdapter();
            this.TripGridView = new System.Windows.Forms.DataGridView();
            this.planeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlaneCode = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtDepTime = new System.Windows.Forms.TextBox();
            this.txtArrTime = new System.Windows.Forms.TextBox();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboNumTicket = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCharges = new System.Windows.Forms.TextBox();
            this.btnBuyTrip = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboTripType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airCraftBindingSource
            // 
            this.airCraftBindingSource.DataMember = "AirCraft";
            this.airCraftBindingSource.DataSource = this.airAsianDataBaseDataSetBindingSource;
            // 
            // airAsianDataBaseDataSetBindingSource
            // 
            this.airAsianDataBaseDataSetBindingSource.DataSource = this.airAsianDataBaseDataSet;
            this.airAsianDataBaseDataSetBindingSource.Position = 0;
            // 
            // airAsianDataBaseDataSet
            // 
            this.airAsianDataBaseDataSet.DataSetName = "AirAsianDataBaseDataSet";
            this.airAsianDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airCraftTableAdapter
            // 
            this.airCraftTableAdapter.ClearBeforeFill = true;
            // 
            // TripGridView
            // 
            this.TripGridView.AllowUserToAddRows = false;
            this.TripGridView.AllowUserToDeleteRows = false;
            this.TripGridView.AutoGenerateColumns = false;
            this.TripGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TripGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeCodeDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.departTimeDataGridViewTextBoxColumn,
            this.arriveTimeDataGridViewTextBoxColumn,
            this.pricesDataGridViewTextBoxColumn});
            this.TripGridView.DataSource = this.airCraftBindingSource;
            this.TripGridView.Location = new System.Drawing.Point(12, 12);
            this.TripGridView.Name = "TripGridView";
            this.TripGridView.ReadOnly = true;
            this.TripGridView.Size = new System.Drawing.Size(732, 150);
            this.TripGridView.TabIndex = 0;
            this.TripGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TripGridView_CellContentClick);
            // 
            // planeCodeDataGridViewTextBoxColumn
            // 
            this.planeCodeDataGridViewTextBoxColumn.DataPropertyName = "PlaneCode";
            this.planeCodeDataGridViewTextBoxColumn.HeaderText = "PlaneCode";
            this.planeCodeDataGridViewTextBoxColumn.Name = "planeCodeDataGridViewTextBoxColumn";
            this.planeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departTimeDataGridViewTextBoxColumn
            // 
            this.departTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartTime";
            this.departTimeDataGridViewTextBoxColumn.HeaderText = "DepartTime";
            this.departTimeDataGridViewTextBoxColumn.Name = "departTimeDataGridViewTextBoxColumn";
            this.departTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arriveTimeDataGridViewTextBoxColumn
            // 
            this.arriveTimeDataGridViewTextBoxColumn.DataPropertyName = "ArriveTime";
            this.arriveTimeDataGridViewTextBoxColumn.HeaderText = "ArriveTime";
            this.arriveTimeDataGridViewTextBoxColumn.Name = "arriveTimeDataGridViewTextBoxColumn";
            this.arriveTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricesDataGridViewTextBoxColumn
            // 
            this.pricesDataGridViewTextBoxColumn.DataPropertyName = "Prices";
            this.pricesDataGridViewTextBoxColumn.HeaderText = "Prices";
            this.pricesDataGridViewTextBoxColumn.Name = "pricesDataGridViewTextBoxColumn";
            this.pricesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PlaneCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Depart Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Arrive Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prices";
            // 
            // txtPlaneCode
            // 
            this.txtPlaneCode.Enabled = false;
            this.txtPlaneCode.Location = new System.Drawing.Point(127, 180);
            this.txtPlaneCode.Name = "txtPlaneCode";
            this.txtPlaneCode.Size = new System.Drawing.Size(100, 20);
            this.txtPlaneCode.TabIndex = 7;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Enabled = false;
            this.txtOrigin.Location = new System.Drawing.Point(127, 215);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(100, 20);
            this.txtOrigin.TabIndex = 8;
            // 
            // txtDest
            // 
            this.txtDest.Enabled = false;
            this.txtDest.Location = new System.Drawing.Point(127, 242);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(100, 20);
            this.txtDest.TabIndex = 9;
            // 
            // txtDepTime
            // 
            this.txtDepTime.Enabled = false;
            this.txtDepTime.Location = new System.Drawing.Point(127, 271);
            this.txtDepTime.Name = "txtDepTime";
            this.txtDepTime.Size = new System.Drawing.Size(100, 20);
            this.txtDepTime.TabIndex = 10;
            // 
            // txtArrTime
            // 
            this.txtArrTime.Enabled = false;
            this.txtArrTime.Location = new System.Drawing.Point(127, 300);
            this.txtArrTime.Name = "txtArrTime";
            this.txtArrTime.Size = new System.Drawing.Size(100, 20);
            this.txtArrTime.TabIndex = 11;
            // 
            // txtPrices
            // 
            this.txtPrices.Enabled = false;
            this.txtPrices.Location = new System.Drawing.Point(127, 331);
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Size = new System.Drawing.Size(100, 20);
            this.txtPrices.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "How many seat you want?";
            // 
            // ComboNumTicket
            // 
            this.ComboNumTicket.FormattingEnabled = true;
            this.ComboNumTicket.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ComboNumTicket.Location = new System.Drawing.Point(514, 188);
            this.ComboNumTicket.Name = "ComboNumTicket";
            this.ComboNumTicket.Size = new System.Drawing.Size(121, 21);
            this.ComboNumTicket.TabIndex = 15;
            this.ComboNumTicket.SelectedIndexChanged += new System.EventHandler(this.ComboNumTicket_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Charges";
            // 
            // txtCharges
            // 
            this.txtCharges.Enabled = false;
            this.txtCharges.Location = new System.Drawing.Point(514, 215);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.Size = new System.Drawing.Size(121, 20);
            this.txtCharges.TabIndex = 17;
            // 
            // btnBuyTrip
            // 
            this.btnBuyTrip.Location = new System.Drawing.Point(514, 280);
            this.btnBuyTrip.Name = "btnBuyTrip";
            this.btnBuyTrip.Size = new System.Drawing.Size(75, 23);
            this.btnBuyTrip.TabIndex = 18;
            this.btnBuyTrip.Text = "Buy";
            this.btnBuyTrip.UseVisualStyleBackColor = true;
            this.btnBuyTrip.Click += new System.EventHandler(this.btnBuyTrip_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "SingleTrip or Return Trip?";
            // 
            // comboTripType
            // 
            this.comboTripType.FormattingEnabled = true;
            this.comboTripType.Items.AddRange(new object[] {
            "single",
            "return"});
            this.comboTripType.Location = new System.Drawing.Point(514, 244);
            this.comboTripType.Name = "comboTripType";
            this.comboTripType.Size = new System.Drawing.Size(121, 21);
            this.comboTripType.TabIndex = 20;
            this.comboTripType.SelectedIndexChanged += new System.EventHandler(this.comboTripType_SelectedIndexChanged);
            // 
            // ReserveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 430);
            this.Controls.Add(this.comboTripType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuyTrip);
            this.Controls.Add(this.txtCharges);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComboNumTicket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrices);
            this.Controls.Add(this.txtArrTime);
            this.Controls.Add(this.txtDepTime);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtPlaneCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TripGridView);
            this.Name = "ReserveMenu";
            this.Text = "ReserveMenu";
            this.Load += new System.EventHandler(this.ReserveMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource airAsianDataBaseDataSetBindingSource;
        private AirAsianDataBaseDataSet airAsianDataBaseDataSet;
        private System.Windows.Forms.BindingSource airCraftBindingSource;
        private AirAsianDataBaseDataSetTableAdapters.AirCraftTableAdapter airCraftTableAdapter;
        private System.Windows.Forms.DataGridView TripGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlaneCode;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtDepTime;
        private System.Windows.Forms.TextBox txtArrTime;
        private System.Windows.Forms.TextBox txtPrices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboNumTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCharges;
        private System.Windows.Forms.Button btnBuyTrip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboTripType;
    }
}