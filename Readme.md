<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582395/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T555679)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - How to Implement Custom Summary Values for Total, Grand Total, and Data Cells

This example demonstrates how to determine the value type when you calculate custom summary values.

Follow the steps below to create a custom summary:

1. Create an [ExpressionDataBinding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.ExpressionDataBinding) object.
2. Pass the following expression in its constructor as a parameter:

    ```
    Iif(IsTotal([fieldCompanyName]), 'Grand Total', IsTotal([fieldYear]), 'Grand Total', IsTotal([fieldProductName]), 'Total', IsTotal([fieldQuarter]), 'Total', Sum([ProductAmount]))
    ``` 
3. Assign the `ExpressionDataBinding` instance to the _fieldProductAmount_ field's [DataBinding](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.DataBinding) property.

## Files to Review 

* [Form1.cs](./CS/WinPivotCustomSummaryCellType/Form1.cs) (VB: [Form1.vb](./VB/VBWinPivotCustomSummaryCellType/Form1.vb))

## Documentation

* [Summaries](https://docs.devexpress.com/WindowsForms/9384/controls-and-libraries/pivot-grid/data-shaping/summarization/summaries)

## More Examples 

* [Create a Custom Summary to Display a Distinct Value Count﻿](https://github.com/DevExpress-Examples/winforms-pivot-grid-implement-the-distinct-count-summary-type)
* [Use the Other Cell’s Values in the Current Cell Value Calculation﻿](https://github.com/DevExpress-Examples/winforms-pivot-access-other-cell-value-while-calculating-the-current-cell)
* [Aggregate Data by the Field’s First Value﻿](https://github.com/DevExpress-Examples/winforms-pivot-grid-custom-aggregates)


