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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.NwindDataSet1 = New VBWinPivotCustomSummaryCellType.nwindDataSet()
        Me.CustomerReportsTableAdapter1 = New VBWinPivotCustomSummaryCellType.nwindDataSetTableAdapters.CustomerReportsTableAdapter()
        Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCompanyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductAmount1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOrderDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "CustomerReports"
        Me.PivotGridControl1.DataSource = Me.NwindDataSet1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName1, Me.fieldCompanyName1, Me.fieldOrderDate1, Me.fieldProductAmount1, Me.fieldOrderDate2})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(919, 498)
        Me.PivotGridControl1.TabIndex = 0
        '
        'NwindDataSet1
        '
        Me.NwindDataSet1.DataSetName = "nwindDataSet"
        Me.NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerReportsTableAdapter1
        '
        Me.CustomerReportsTableAdapter1.ClearBeforeFill = True
        '
        'fieldProductName1
        '
        Me.fieldProductName1.AreaIndex = 0
        Me.fieldProductName1.FieldName = "ProductName"
        Me.fieldProductName1.Name = "fieldProductName1"
        '
        'fieldCompanyName1
        '
        Me.fieldCompanyName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCompanyName1.AreaIndex = 0
        Me.fieldCompanyName1.FieldName = "CompanyName"
        Me.fieldCompanyName1.Name = "fieldCompanyName1"
        '
        'fieldOrderDate1
        '
        Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldOrderDate1.AreaIndex = 0
        Me.fieldOrderDate1.Caption = "Year"
        Me.fieldOrderDate1.FieldName = "OrderDate"
        Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldOrderDate1.Name = "fieldOrderDate1"
        Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
        '
        'fieldProductAmount1
        '
        Me.fieldProductAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldProductAmount1.AreaIndex = 0
        Me.fieldProductAmount1.FieldName = "ProductAmount"
        Me.fieldProductAmount1.Name = "fieldProductAmount1"
        '
        'fieldOrderDate2
        '
        Me.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldOrderDate2.AreaIndex = 1
        Me.fieldOrderDate2.Caption = "Quarter"
        Me.fieldOrderDate2.FieldName = "OrderDate"
        Me.fieldOrderDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
        Me.fieldOrderDate2.Name = "fieldOrderDate2"
        Me.fieldOrderDate2.UnboundFieldName = "fieldOrderDate2"
        Me.fieldOrderDate2.ValueFormat.FormatString = "Qtr {0}"
        Me.fieldOrderDate2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
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
    Friend WithEvents fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCompanyName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductAmount1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOrderDate2 As DevExpress.XtraPivotGrid.PivotGridField

End Class
