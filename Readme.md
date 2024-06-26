<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610204/16.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T467150)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - How to Emulate the MS Word Information Status Bar

This example demonstrates how to implement an information status bar that mimics the MS Word status bar:

![image](./media/150534eb-cd19-11e6-80bf-00155d62480c.png)

## Implementation Details

This task is accomplished by using the RichEditControl's Document Layout API.
In this example, we use different approaches to collect the required information:

* The [DocumentIterator](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.DocumentIterator) class to obtain the total word count.
* A custom [LayoutVisitor](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Layout.LayoutVisitor) descendant to get the caret position (the line and column indices).

## Files to Review

* [CustomLayoutVisitor.cs](./CS/WindowsFormsApplication1/CustomLayoutVisitor.cs) (VB: [CustomLayoutVisitor.vb](./VB/WindowsFormsApplication1/CustomLayoutVisitor.vb))
* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))

## More Examples

* [Rich Text Editor for WinForms - Layout API](https://github.com/DevExpress-Examples/winforms-richedit-layout-api)
* [Document Layout API - Practical Usage](https://github.com/DevExpress-Examples/winforms-richedit-layout-api-practical-usage)

## Documentation

* [Layout API](https://docs.devexpress.com/WindowsForms/114069/controls-and-libraries/rich-text-editor/page-layout/layout-api)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-emulate-the-ms-word-status-bar&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-emulate-the-ms-word-status-bar&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
