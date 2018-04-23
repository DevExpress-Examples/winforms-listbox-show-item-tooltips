# How to show a tooltip for the ListBoxControl item


<p>You should use the ToolTipController.ShowHint method to show an item tooltip. To get the item the mouse pointer is hovering over, use the ListBoxControl.IndexFromPoint method. In the ListBoxControl.MouseMove event handler, show your tooltip.</p>

<br/>


