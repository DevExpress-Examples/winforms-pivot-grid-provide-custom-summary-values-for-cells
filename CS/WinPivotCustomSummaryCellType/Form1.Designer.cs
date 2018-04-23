namespace WinPivotCustomSummaryCellType
{
    partial class Form1
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.nwindDataSet1 = new WinPivotCustomSummaryCellType.Data.nwindDataSet();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCompanyName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.customerReportsTableAdapter1 = new WinPivotCustomSummaryCellType.Data.nwindDataSetTableAdapters.CustomerReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataMember = "CustomerReports";
            this.pivotGridControl1.DataSource = this.nwindDataSet1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName1,
            this.fieldCompanyName1,
            this.fieldOrderDate1,
            this.fieldProductAmount1,
            this.fieldOrderDate2});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(919, 511);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.AreaIndex = 0;
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldCompanyName1
            // 
            this.fieldCompanyName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCompanyName1.AreaIndex = 0;
            this.fieldCompanyName1.FieldName = "CompanyName";
            this.fieldCompanyName1.Name = "fieldCompanyName1";
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate1.AreaIndex = 0;
            this.fieldOrderDate1.Caption = "Year";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            // 
            // fieldProductAmount1
            // 
            this.fieldProductAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount1.AreaIndex = 0;
            this.fieldProductAmount1.FieldName = "ProductAmount";
            this.fieldProductAmount1.Name = "fieldProductAmount1";
            // 
            // fieldOrderDate2
            // 
            this.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate2.AreaIndex = 1;
            this.fieldOrderDate2.Caption = "Quarter";
            this.fieldOrderDate2.FieldName = "OrderDate";
            this.fieldOrderDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldOrderDate2.Name = "fieldOrderDate2";
            this.fieldOrderDate2.UnboundFieldName = "fieldOrderDate2";
            this.fieldOrderDate2.ValueFormat.FormatString = "Qtr {0}";
            this.fieldOrderDate2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // customerReportsTableAdapter1
            // 
            this.customerReportsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 511);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Pivot Grid Custom Summary";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private Data.nwindDataSet nwindDataSet1;
        private Data.nwindDataSetTableAdapters.CustomerReportsTableAdapter customerReportsTableAdapter1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate2;
    }
}

