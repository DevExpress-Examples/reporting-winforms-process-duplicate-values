# How to process duplicate values in a report
This example demonstrates how to use the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRC.ProcessDuplicatesMode">ProcessDuplicatesMode</a> and <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRC.ProcessDuplicatesTarget">ProcessDuplicatesTarget</a> properties to merge a report's duplicate values in WinForms applications.

Set the report control's **ProcessDuplicatesMode** property to <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.ProcessDuplicatesMode">Merge</a>. After that, set the **ProcessDuplicatesTarget** property to one of the following values:

- <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.ProcessDuplicatesTarget">Value</a> to merge identical values of a report control's data.

- <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.ProcessDuplicatesTarget">Tag</a> to merge  the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.Tag">XRControl.Tag</a> property's duplicate values. 


