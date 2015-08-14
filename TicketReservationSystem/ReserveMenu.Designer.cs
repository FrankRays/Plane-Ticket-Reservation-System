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
            this.TripGridView.Location = new System.Drawing.Point(76, 68);
            this.TripGridView.Name = "TripGridView";
            this.TripGridView.ReadOnly = true;
            this.TripGridView.Size = new System.Drawing.Size(701, 150);
            this.TripGridView.TabIndex = 0;
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
            // ReserveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 430);
            this.Controls.Add(this.TripGridView);
            this.Name = "ReserveMenu";
            this.Text = "ReserveMenu";
            this.Load += new System.EventHandler(this.ReserveMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripGridView)).EndInit();
            this.ResumeLayout(false);

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
    }
}