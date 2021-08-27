<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/180376285/18.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830426)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to process duplicate values in a report
This example demonstrates how to use the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRC.ProcessDuplicatesMode">ProcessDuplicatesMode</a> and <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRC.ProcessDuplicatesTarget">ProcessDuplicatesTarget</a> properties to merge a report's duplicate values in WinForms applications.

Set the report control's **ProcessDuplicatesMode** property to <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.ProcessDuplicatesMode">Merge</a>. After that, set the **ProcessDuplicatesTarget** property to one of the following values:

- <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.ProcessDuplicatesTarget">Value</a> to merge identical values of a report control's data.

- <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.ProcessDuplicatesTarget">Tag</a> to merge  the <a href="https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.Tag">XRControl.Tag</a> property's duplicate values. 


