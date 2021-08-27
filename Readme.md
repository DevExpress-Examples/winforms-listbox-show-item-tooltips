<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1195)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication45/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication45/Form1.vb))
* [Program.cs](./CS/WindowsApplication45/Program.cs) (VB: [Program.vb](./VB/WindowsApplication45/Program.vb))
<!-- default file list end -->
# How to show a tooltip for the ListBoxControl item


<p>You should use the ToolTipController.ShowHint method to show an item tooltip. To get the item the mouse pointer is hovering over, use the ListBoxControl.IndexFromPoint method. In the ListBoxControl.MouseMove event handler, show your tooltip.</p>

<br/>


