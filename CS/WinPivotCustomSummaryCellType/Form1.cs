﻿using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WinPivotCustomSummaryCellType {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            
            customerReportsTableAdapter1.Fill(nwindDataSet1.CustomerReports);
        }
    }
}
