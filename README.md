<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/180376285/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830426)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - How to Vertically Merge Cells With Duplicate Values

This example shows how to merge table cells with the same values vertically.

In this example, the adjacent cells in the **Products** column with the same values are merged.

The resulting report looks as follows:

![Merge Duplicate Cells Vertically](Images/screenshot.gif)

In the report code, the [ProcessDuplicatesMode](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.ProcessDuplicatesMode) property is set to `Merge`. The application allows you to set the [ProcessDuplicatesTarget](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.ProcessDuplicatesTarget) property to `Value` to merge cells with identical data field values, or to `Tag` to merge cells with the identical [Tag](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRControl.Tag) property content.

## Files to Look At

- [Form1.cs](CS/ProcessDuplicatesTarget/Form1.cs) (VB: [Form1.vb](VB/ProcessDuplicatesTarget/Form1.vb))
- [ProductReport.cs](CS/ProcessDuplicatesTarget/ProductReport.cs) (VB: [ProductReport.vb](VB/ProcessDuplicatesTarget/ProductReport.vb))

## Documentation

- [Arrange Dynamic Report Contents](https://docs.devexpress.com/XtraReports/5170/detailed-guide-to-devexpress-reporting/arrange-dynamic-report-contents)
- [Use Tables](https://docs.devexpress.com/XtraReports/9741/detailed-guide-to-devexpress-reporting/use-report-controls/use-tables)


## More Examples

- [How to Group Report Data by Days of the Week](https://github.com/DevExpress-Examples/reporting-group-by-days-of-week)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-process-duplicate-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-process-duplicate-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
