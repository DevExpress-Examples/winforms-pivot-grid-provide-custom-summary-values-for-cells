<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim ExpressionDataBinding1 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
        Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.NwindDataSet1 = New VBWinPivotCustomSummaryCellType.nwindDataSet()
        Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductAmount1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.CustomerReportsTableAdapter1 = New VBWinPivotCustomSummaryCellType.nwindDataSetTableAdapters.CustomerReportsTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "CustomerReports"
        Me.PivotGridControl1.DataSource = Me.NwindDataSet1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldCompanyName, Me.fieldYear, Me.fieldProductAmount1, Me.fieldQuarter})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(919, 498)
        Me.PivotGridControl1.TabIndex = 0
        '
        'NwindDataSet1
        '
        Me.NwindDataSet1.DataSetName = "nwindDataSet"
        Me.NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldProductName
        '
        Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProductName.AreaIndex = 1
        DataSourceColumnBinding1.ColumnName = "ProductName"
        Me.fieldProductName.DataBinding = DataSourceColumnBinding1
        Me.fieldProductName.Name = "fieldProductName"
        '
        'fieldCompanyName
        '
        Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCompanyName.AreaIndex = 0
        DataSourceColumnBinding2.ColumnName = "CompanyName"
        Me.fieldCompanyName.DataBinding = DataSourceColumnBinding2
        Me.fieldCompanyName.Name = "fieldCompanyName"
        '
        'fieldYear
        '
        Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldYear.AreaIndex = 0
        Me.fieldYear.Caption = "Year"
        DataSourceColumnBinding3.ColumnName = "OrderDate"
        DataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldYear.DataBinding = DataSourceColumnBinding3
        Me.fieldYear.Name = "fieldYear"
        '
        'fieldProductAmount1
        '
        Me.fieldProductAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldProductAmount1.AreaIndex = 0
        Me.fieldProductAmount1.Caption = "Custom Summary"
        ExpressionDataBinding1.Expression = "Iif(IsTotal([fieldCompanyName]), 'Grand Total', IsTotal([fieldYear]), 'Grand Tota" &
    "l', IsTotal([fieldProductName]), 'Total', IsTotal([fieldQuarter]), 'Total', Sum(" &
    "[ProductAmount]))"
        Me.fieldProductAmount1.DataBinding = ExpressionDataBinding1
        Me.fieldProductAmount1.Name = "fieldProductAmount1"
        '
        'fieldQuarter
        '
        Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldQuarter.AreaIndex = 1
        Me.fieldQuarter.Caption = "Quarter"
        DataSourceColumnBinding4.ColumnName = "OrderDate"
        DataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
        Me.fieldQuarter.DataBinding = DataSourceColumnBinding4
        Me.fieldQuarter.Name = "fieldQuarter"
        Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
        Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'CustomerReportsTableAdapter1
        '
        Me.CustomerReportsTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 498)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "Form1"
        Me.Text = "DevExpress PivotGrid Custom Summary"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents NwindDataSet1 As VBWinPivotCustomSummaryCellType.nwindDataSet
    Friend WithEvents CustomerReportsTableAdapter1 As VBWinPivotCustomSummaryCellType.nwindDataSetTableAdapters.CustomerReportsTableAdapter
    Friend WithEvents fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYear As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductAmount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField

End Class
