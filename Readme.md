<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582395/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T555679)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinPivotCustomSummaryCellType/Form1.cs) (VB: [Form1.vb](./VB/VBWinPivotCustomSummaryCellType/Form1.vb))
<!-- default file list end -->
# How to provide custom summary values for Total, Grand Total and ordinary cells


<p>This example demonstrates how to determine the value type when you calculate custom summary values.<br>1. Set the data field's <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.SummaryType.property">SummaryType</a> property to <em>Custom</em> to perform calculations manually, by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomSummarytopic"><u>CustomSummary</u></a> event. <br>2. Use the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridDataPivotGridCustomSummaryEventArgsBase~T~_ColumnFieldtopic"><u>PivotGridCustomSummaryEventArgs.ColumnField</u></a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridDataPivotGridCustomSummaryEventArgsBase~T~_RowFieldtopic"><u>PivotGridCustomSummaryEventArgs.RowField</u></a> properties to determine the kind of a processed cell. You can use the following rules to determine that a cell is being processed:</p>
<p>    a. If <strong>ColumnField</strong> or <strong>RowField</strong> is <em>null, </em>it means that this is a <a href="https://documentation.devexpress.com/WindowsForms/1692/Controls-and-Libraries/Pivot-Grid/UI-Elements/Grand-Totals">Grand Total</a> cell;<br>    b. If both ColumnField and RowField are last fields in a corresponding area, this means that this is an ordinary <a href="https://documentation.devexpress.com/WindowsForms/1681/Controls-and-Libraries/Pivot-Grid/UI-Elements/Cell">cell</a>.<br>    c. In other cases, this is a <a href="https://documentation.devexpress.com/WindowsForms/1691/Controls-and-Libraries/Pivot-Grid/UI-Elements/Totals">Total</a> cell.<br><br><br><strong>See Also<br><a href="https://www.devexpress.com/Support/Center/p/T158425">T158425: How to calculate Total cell values based on the low level Cell summary values</a> <br></strong></p>
<p><strong>Example versions for other platforms:</strong></p>
<p><a href="https://www.devexpress.com/Support/Center/p/E2592">E2592: How to provide custom summary values for Total, Grand Total and ordinary cells for ASPxPivotGrid</a><br><a href="https://www.devexpress.com/Support/Center/p/T555636">T555636: How to provide custom summary values for Total, Grand Total and ordinary cells for WPF PivotGridControl</a></p>

<br/>


