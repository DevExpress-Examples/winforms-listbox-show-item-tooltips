<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication45/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication45/Form1.vb))
* [Program.cs](./CS/WindowsApplication45/Program.cs) (VB: [Program.vb](./VB/WindowsApplication45/Program.vb))
<!-- default file list end -->
# How to show a tooltip for the ListBoxControl item


<p>You should use the ToolTipController.ShowHint method to show an item tooltip. To get the item the mouse pointer is hovering over, use the ListBoxControl.IndexFromPoint method. In the ListBoxControl.MouseMove event handler, show your tooltip.</p>

<br/>


