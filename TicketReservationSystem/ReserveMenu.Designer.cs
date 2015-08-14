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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeCodeDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.departTimeDataGridViewTextBoxColumn,
            this.arriveTimeDataGridViewTextBoxColumn,
            this.pricesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.airCraftBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // planeCodeDataGridViewTextBoxColumn
            // 
            this.planeCodeDataGridViewTextBoxColumn.DataPropertyName = "PlaneCode";
            this.planeCodeDataGridViewTextBoxColumn.HeaderText = "PlaneCode";
            this.planeCodeDataGridViewTextBoxColumn.Name = "planeCodeDataGridViewTextBoxColumn";
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // departTimeDataGridViewTextBoxColumn
            // 
            this.departTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartTime";
            this.departTimeDataGridViewTextBoxColumn.HeaderText = "DepartTime";
            this.departTimeDataGridViewTextBoxColumn.Name = "departTimeDataGridViewTextBoxColumn";
            // 
            // arriveTimeDataGridViewTextBoxColumn
            // 
            this.arriveTimeDataGridViewTextBoxColumn.DataPropertyName = "ArriveTime";
            this.arriveTimeDataGridViewTextBoxColumn.HeaderText = "ArriveTime";
            this.arriveTimeDataGridViewTextBoxColumn.Name = "arriveTimeDataGridViewTextBoxColumn";
            // 
            // pricesDataGridViewTextBoxColumn
            // 
            this.pricesDataGridViewTextBoxColumn.DataPropertyName = "Prices";
            this.pricesDataGridViewTextBoxColumn.HeaderText = "Prices";
            this.pricesDataGridViewTextBoxColumn.Name = "pricesDataGridViewTextBoxColumn";
            // 
            // ReserveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 430);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReserveMenu";
            this.Text = "ReserveMenu";
            this.Load += new System.EventHandler(this.ReserveMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airCraftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airAsianDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource airAsianDataBaseDataSetBindingSource;
        private AirAsianDataBaseDataSet airAsianDataBaseDataSet;
        private System.Windows.Forms.BindingSource airCraftBindingSource;
        private AirAsianDataBaseDataSetTableAdapters.AirCraftTableAdapter airCraftTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesDataGridViewTextBoxColumn;
    }
}