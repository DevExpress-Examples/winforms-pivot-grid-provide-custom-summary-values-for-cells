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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.ExpressionDataBinding expressionDataBinding1 = new DevExpress.XtraPivotGrid.ExpressionDataBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.nwindDataSet1 = new WinPivotCustomSummaryCellType.Data.nwindDataSet();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.fieldProductName,
            this.fieldCompanyName,
            this.fieldYear,
            this.fieldProductAmount,
            this.fieldQuarter});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(919, 511);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            dataSourceColumnBinding1.ColumnName = "ProductName";
            this.fieldProductName.DataBinding = dataSourceColumnBinding1;
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldCompanyName
            // 
            this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCompanyName.AreaIndex = 0;
            dataSourceColumnBinding2.ColumnName = "CompanyName";
            this.fieldCompanyName.DataBinding = dataSourceColumnBinding2;
            this.fieldCompanyName.Name = "fieldCompanyName";
            this.fieldCompanyName.Width = 111;
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            dataSourceColumnBinding3.ColumnName = "OrderDate";
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.DataBinding = dataSourceColumnBinding3;
            this.fieldYear.Name = "fieldYear";
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.Caption = "Custom Summary";
            expressionDataBinding1.Expression = "Iif(IsTotal([fieldCompanyName]), \'Grand Total\', IsTotal([fieldYear]), \'Grand" +
    " Total\', IsTotal([fieldProductName]), \'Total\', IsTotal([fieldQuarter]), \'Tota" +
    "l\', Sum([ProductAmount]))";
            this.fieldProductAmount.DataBinding = expressionDataBinding1;
            this.fieldProductAmount.Name = "fieldProductAmount";
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            dataSourceColumnBinding4.ColumnName = "OrderDate";
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.DataBinding = dataSourceColumnBinding4;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom;
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuarter;
    }
}

