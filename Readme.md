# How to emulate the MS Word information status bar when using RichEditControl


<p>This example demonstrates how to implement an information status bar that mimics the MS Word status bar:<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-emulate-the-ms-word-information-status-bar-when-using-richeditcontrol-t467150/16.1.9+/media/150534eb-cd19-11e6-80bf-00155d62480c.png"></p>
<p>This task is accomplished by using the RichEditControl's DocumentLayout API. Review the following help topic for additional information:<br><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument114069">Layout API</a></p>
<p>In this example, we use different approaches to collect required information:</p>

* The <a href="https://documentation.devexpress.com/CoreLibraries/clsDevExpressXtraRichEditAPINativeDocumentIteratortopic.aspx">DocumentIterator</a> class to obtain the total word count.
* A custom <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditAPILayoutLayoutVisitortopic">LayoutVisitor</a> descendant to get the caret position (the line and column indices).
<p><strong>See also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/T245818">Layout API - Simple Example</a><br><a href="https://www.devexpress.com/Support/Center/p/T266080">Document Layout API - Practical usage</a></p>